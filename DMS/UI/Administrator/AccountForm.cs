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
        private AccessTable _selectAccess;

        public AccountForm(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
            InitializeComponent();

            cbxAccessTable.Properties.DisplayMember = "AccessTitle";
            cbxAccessTable.Properties.ValueMember = "ID";
            cbxAccessTable.Properties.DataSource =
                Task.Run(async () => await _applicationUserService.GetAccessList()).Result;
            UserList();
            Clear();
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
            cbxAccessTable.EditValue = _user.AccessID_FK;
            txtUsername.Text = _user.Username;
            txtJob.Text = _user.Job;
            txtPassword.ToolTip = PublicValues.Base64Decode(_user.Password);
            txtPassword.EditValue = PublicValues.Base64Decode(_user.Password);
            chkIsActive.EditValue = _user.IsActive;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (_user.UserID > 0)
                {
                    _user.Username = txtUsername.Text.Trim();
                    _user.Password =PublicValues.Base64Encode(txtPassword.EditValue.ToString());
                    _user.AccessID_FK = Convert.ToByte(_selectAccess.ID);
                    _user.Job = txtJob.Text.Trim();
                    _user.IsActive = Convert.ToBoolean(chkIsActive.CheckState);
                    var resultUpdate = Task.Run(async () => await _applicationUserService.UpdateUser(_user)).Result;
                    PublicValues.Message(resultUpdate);
                    if (resultUpdate)
                    {
                        Clear();
                    }
                }
                else
                {
                    _user = new ApplicationUser();
         
                    _user.Username = txtUsername.Text.Trim();
                    _user.Password = PublicValues.Base64Encode(txtPassword.EditValue.ToString());
                    _user.AccessID_FK = Convert.ToByte(_selectAccess.ID);
                    _user.Job = txtJob.Text.Trim();
                    _user.IsActive = Convert.ToBoolean(chkIsActive.CheckState);

                    var resultAdd = Task.Run(async () => await _applicationUserService.AddUser(_user)).Result;
                    PublicValues.Message(resultAdd);
                    if (resultAdd)
                    {
                        Clear();
                    }
                }
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }

        private void Clear()
        {
            txtJob.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();
            chkIsActive.CheckState = CheckState.Checked;
            cbxAccessTable.EditValue = 0;
            _user = new ApplicationUser();
            txtUsername.Focus();
        }

        private void cbxAccessTable_EditValueChanged(object sender, EventArgs e)
        {
             _selectAccess = (AccessTable)cbxAccessTable.GetSelectedDataRow();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_user.UserID > 0)
                Clear();
            else
                Close();
        }
    }
}
