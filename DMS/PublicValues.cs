using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DMS
{
    public static class PublicValues
    {
        public static string LoginError = "نام کاربری یا رمز عبور معتبر نمی باشد";

        public static void ErrorValidate(string formText)
        {
            XtraMessageBox.Show(@"مقادریر فرم را درست وارد کنید", formText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void SuccessSave(string formText)
        {
            XtraMessageBox.Show(@"اطلاعات در بانک اطلاعاتی دخیره شد", formText, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ErrorSave(string formText)
        {
            XtraMessageBox.Show(@"خطا در ذخیره بانک اطلاعاتی ، پس از بررسی مجدداً تلاش کنید", formText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Message(bool result, string msg = null)
        {
            if (result)
            {
                if (msg == null)
                    SuccessSave(@"اتوماسیون خوابگاه");
                else
                    SuccessSave(msg);
            }
            else
            {
                if (msg == null)
                    ErrorSave(@"اتوماسیون خوابگاه");
                else
                    ErrorSave(msg);
            }

        }

        public static byte[] ImageToByte(this Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
