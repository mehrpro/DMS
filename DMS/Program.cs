using DMS.UI;
using System;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new StructureMap.Container(new TypeRegister());
            var frm = container.GetInstance<LoginForm>();
            Application.Run(frm);
            if (frm.DialogResult == DialogResult.OK)
            {
                var mainForm = container.GetInstance<MainForm>();
                mainForm.MainContainer = container;
                mainForm.ShowDialog();
            }
            else
                Environment.Exit(0);
        }
    }
}
