using DMS.UI;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new StructureMap.Container(new TypeRegister());
            var frm = container.GetInstance<LoginForm>();
            Application.Run(frm);
            if (frm.DialogResult == DialogResult.OK)
            {
                if (frm.AccList.Any())
                {
                    var mainForm = container.GetInstance<MainForm>();
                    mainForm.AccessLists = frm.AccList;
                    mainForm.MainContainer = container;
                    mainForm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show(PublicValues.AccessError, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                Environment.Exit(0);
        }
    }
}
