using DevExpress.XtraEditors;
using DMS.IServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace DMS.UI.Dormitories
{
    public partial class SendSMSForm : XtraForm
    {
        private readonly ISmsService _smsService;
        private BackgroundWorker _backgroundWorker;
        private Sms _sms;

        public Sms Sms
        {
            get => _sms;
            set => _sms = value;
        }

        public SendSMSForm(ISmsService smsService)
        {
            _smsService = smsService;
            InitializeComponent();
            _backgroundWorker = new BackgroundWorker();
            //_backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorkerOnRunWorkerCompleted;

        }

        private void BackgroundWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel.Text = "Done!";
            }
        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                //Close();

            }
            else
            {
                var result = Send(_sms.Mobile1, new string[] { _sms.Content });
                if (result.Success)
                {

                    txtStatus1.Text = result.ResultCode;
                    txtStatus1.BackColor = Color.DarkSlateGray;
                    Thread.Sleep(1000);

                }
                else
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        //Close();

                    }

                    txtStatus1.Text = result.ErrorMessage;
                    txtStatus1.BackColor = Color.IndianRed;
                    txtStatus2.Text = @"در حال ارسال";
                    var result2 = Send(_sms.Mobile2, new string[] { _sms.Content });
                    if (result2.Success)
                    {

                        txtStatus2.Text = result.ResultCode;
                        txtStatus2.BackColor = Color.DarkSlateGray;
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private ResultMessage Send(long mobile, string[] contentStrings)
        {
            return Task.Run(async () => await _smsService.SendSms(mobile, contentStrings)).Result;
        }



        private void SendSMSForm_Load(object sender, EventArgs e)
        {
            txtReciver1.Text = _sms.ReciverName1;
            txtReciver2.Text = _sms.ReciverName2;
            txtmobile1.Text = _sms.Mobile1.ToString();
            txtMobile2.Text = _sms.Mobile2.ToString();
            txtStatus1.Text = @"در حال ارسال";
            txtStatus2.Text = @"انتظار";

            if (_backgroundWorker.IsBusy == false)
            {
                _backgroundWorker.RunWorkerAsync();
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_backgroundWorker.WorkerSupportsCancellation == true)
            {
                _backgroundWorker.CancelAsync();
            }
        }
    }
}
