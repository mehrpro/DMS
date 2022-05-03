using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS.Entities;
using DMS.IServices;

namespace DMS.UI.Administrator
{
    public partial class AccountForm : XtraForm
    {
        private ApplicationUser _user;
        public AccountForm(IApplicationUserSer)
        {
            InitializeComponent();
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
                        if (gridView1.GetFocusedRowCellValue("UserID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _user = new ApplicationUser();
            _user = (ApplicationUser)focusedRow;
            txtUsername.Text = _user.Username;
            txtJob.Text = _user.Job;
            
        }
    }
}
