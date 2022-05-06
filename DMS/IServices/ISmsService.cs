using DMS.Entities;
using DMS.Repositories;
using DMS.ServiceReference1;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.IServices
{
    public interface ISmsService
    {
        Task<ResultMessage> SendSms(long mobile, string[] content);
    }

    public class SmsService : ISmsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SmsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<ResultMessage> SendSms(long mobile, string[] content)
        {
            var resultConnection = Task.Run(async () => await ConnectionSms()).Result;
            if (resultConnection.Success)
            {
                try
                {
                    if (resultConnection.Info == null) return new ResultMessage(success: false, errorMessage: "اطلاعات حساب کاربری صحیح نیست", resultCode: "0");
                    string[] smsNumber = { resultConnection.Info.SendNumber };
                    string[] to = { mobile.ToString("00000000000") };
                    var result = await _unitOfWork.TsmsService.sendSmsAsync(PublicValues.Base64Decode(resultConnection.Info.Username), PublicValues.Base64Decode(resultConnection.Info.Password), smsNumber, to, content, new string[] { }, "");
                    if (result == null) return new ResultMessage(false, @"خطا در ارسال پیامک و دریافت مقدار نامعتبر در زمان ارسال", "0");
                    if (result[0] > 0) return new ResultMessage(true, $"پیامک برای شماره همراه  {to[0]} با موفقیت ارسال گردید : کد پیگیری سامانه {result[0]}", result[0].ToString());
                }
                catch (Exception e)
                {
                    return new ResultMessage(false, @"خطای نرم افزاری لطفا دوباره امتحان کنید", "0");
                }
            }
            else
                return new ResultMessage(false, @"خطای نرم افزاری لطفا دوباره امتحان کنید", "0");
            return new ResultMessage(false, @"خطای نرم افزاری لطفا دوباره امتحان کنید", "0");
        }
        private async Task CreditMid(objectInfo[] resultUsernfo, PanelInfo info)
        {
            string[] smsNumber = { info.SendNumber };
            string[] vs = { info.WarningReceiver };
            string[] creditMessage = { $"اعتبار سامانه پیامکی {resultUsernfo[0].credit} ریال می باشد بزودی سرویس متوقف می گردد" };
            if (await _unitOfWork.CreditWarning.AnyByCondition(x =>
                        x.ReciverWarning == info.WarningReceiver &&
                        x.SendTime.Date == DateTime.Now.Date &&
                        !x.IsDelete &&
                        x.CreditLevel == info.MidCredit)) return;
            var resultSend = await _unitOfWork.TsmsService.sendSmsAsync(PublicValues.Base64Decode(info.Username), PublicValues.Base64Decode(info.Password), smsNumber, vs, creditMessage, new string[] { }, "");
            if (resultSend[0] > 0)
            {
                //_eventList.Add($"اخظار کاهش اعتبار ارسال شد به :  {vs} , {resultSend[0]}");
                var creditWarning = new CreditWarning
                {
                    ReciverWarning = info.WarningReceiver,
                    SendTime = DateTime.Today,
                    Delivery = resultSend[0].ToString(),
                    IsDelete = false,
                    CreditLevel = info.MidCredit
                };
                _unitOfWork.CreditWarning.Add(creditWarning);
                _unitOfWork.Commit();
            }
        }

        private async Task CreditMin(objectInfo[] resultUsernfo, PanelInfo info)
        {
            string[] smsNumber = { info.SendNumber };
            string[] vs = { info.WarningReceiver };
            string[] creditMessage =
                { $"اعتبار سامانه پیامکی {resultUsernfo[0].credit} ریال می باشد سرویس متوقف گردید" };
            if (await _unitOfWork.CreditWarning
                    .AnyByCondition(x =>
                        x.ReciverWarning == info.WarningReceiver &&
                        x.SendTime.Date == DateTime.Now.Date &&
                        !x.IsDelete &&
                        x.CreditLevel == info.MinCredit)) return;
            var resultSend = await _unitOfWork.TsmsService.sendSmsAsync(PublicValues.Base64Decode(info.Username), PublicValues.Base64Decode(info.Password), smsNumber, vs,
                creditMessage, new string[] { }, "");
            if (resultSend[0] > 0)
            {
                //_eventList.Add($"پیامک توقف سرویس ارسال شد به  :  {vs} , {resultSend[0]}");
                var creditWarning = new CreditWarning
                {
                    ReciverWarning = info.WarningReceiver,
                    SendTime = DateTime.Today,
                    Delivery = resultSend[0].ToString(),
                    IsDelete = false,
                    CreditLevel = info.MinCredit
                };
                _unitOfWork.CreditWarning.Add(creditWarning);
                _unitOfWork.Commit();
            }
        }

        private async Task CreditMax()
        {
            var resultFind = await _unitOfWork.CreditWarning.FindAllByCondition(x => x.IsDelete == false);
            var creditWarnings = resultFind.ToList();
            if (creditWarnings.Any())
            {
                foreach (var creditWarning in creditWarnings) creditWarning.IsDelete = false;
                _unitOfWork.Commit();
            }

        }

        private async Task<ResultConnection> ConnectionSms()
        {
            try
            {
                var info = await _unitOfWork.PanelInfo.FirstRecorder();
                if (info == null)
                {
                    //_eventList.Add("اطلاعات حساب کاربری وجود ندارد");
                    return new ResultConnection() { Success = false, Info = null };
                }

                var userInfoAsync = await _unitOfWork.TsmsService.UserInfoAsync(PublicValues.Base64Decode(info.Username), PublicValues.Base64Decode(info.Password));

                if (userInfoAsync[0].sms_numebrs.Contains(info.SendNumber))
                {
                    if (userInfoAsync[0].credit < info.MinCredit) //چک کردن اعتبار زیر 1200 تومن و توقف سرویس ارسال
                    {
                        await CreditMin(userInfoAsync, info);
                        return new ResultConnection() { Success = false, Info = null };
                    }

                    if (userInfoAsync[0].credit < info.MidCredit &&
                        userInfoAsync[0].credit > info.MinCredit) //چک کردن اعتبار زیر 5000 تومن و ارسال پیامک هشدار
                    {
                        await CreditMid(userInfoAsync, info);
                        return new ResultConnection() { Success = true, Info = info };
                    }

                    if (userInfoAsync[0].credit > info.MidCredit + 1)
                    {
                        await CreditMax();
                        return new ResultConnection() { Success = true, Info = info };
                    }

                    return new ResultConnection() { Success = false, Info = null };
                }

                //_eventList.Add("شماره پیامک صحیح نیست");
                return new ResultConnection() { Success = false, Info = null };
            }
            catch
            {
                //_eventList.Add("خطا در برقراری ارتباط با سامانه پیام کوتاه!");
                return new ResultConnection() { Success = false, Info = null };
            }

        }

        private record ResultConnection
        {
            private bool _success;
            private PanelInfo? _info;

            public bool Success
            {
                get => _success;
                set => _success = value;
            }

            public PanelInfo? Info
            {
                get => _info;
                set => _info = value;
            }
        }

        private static string PersianCalender(DateTime dt)
        {
            var pc = new PersianCalendar();
            var years = pc.GetYear(dt);
            var month = pc.GetMonth(dt);
            var day = pc.GetDayOfMonth(dt);
            var hou = pc.GetHour(dt);
            var minu = pc.GetMinute(dt);
            var sec = pc.GetSecond(dt);
            return new DateTime(years, month, day, hou, minu, sec).ToString("yyyy/MM/dd hh:mm");
        }


    }
}