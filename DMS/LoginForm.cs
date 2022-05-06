using DMS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;

namespace DMS
{
    public partial class LoginForm : XtraForm
    {
        private readonly IApplicationUserService _applicationUserService;
        private readonly IElementUserService _elementUserService;
        //private readonly IUnitOfWork _unitOfWork;

        //public IEnumerable<ElementUser> AccList { get; set; }

        public LoginForm(IApplicationUserService applicationUserService , IElementUserService elementUserService)
        {
            _applicationUserService = applicationUserService;
            _elementUserService = elementUserService;
            InitializeComponent();
            txtUsername.Text = "administrator";
            txtPassword.Text = "123456789";

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result =  _applicationUserService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (result != null)
            {
                if (result.IsActive && result.UserID > 0)
                {
                    PublicValues.UserId = result.UserID;
                    PublicValues.AccessLists = _elementUserService.GetCleamByUserId(result.UserID);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    XtraMessageBox.Show(PublicValues.LoginError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(PublicValues.LoginError, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }
    }
}
