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
        private readonly IApplicationUserService _applicationUserService;
        private ApplicationUser _user;

        public AccountForm(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
            InitializeComponent();

            cbxAccessTable.Properties.DisplayMember = "AccessTitle";
            cbxAccessTable.Properties.DataSource =
                Task.Run(async () => await _applicationUserService.GetAccessList()).Result;
            UserList();
        }

        private void UserList()
        {
            dgvUser.DataSource = Task.Run(async () => await _applicationUserService.GetAllUser()).Result;
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
