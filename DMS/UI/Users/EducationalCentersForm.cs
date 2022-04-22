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

namespace DMS.UI.Users
{
    public partial class EducationalCentersForm : XtraForm
    {
        private readonly IEducationalCenterService _educationalCenterService;
        private EducationalCenter _educationalCenter;
        public EducationalCentersForm(IEducationalCenterService educationalCenterService)
        {
            _educationalCenterService = educationalCenterService;
            _educationalCenter = new EducationalCenter();
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            txtEducation.ResetText();
            chkIsActive.IsOn = true;
            txtEducation.Focus();
            _educationalCenter = new EducationalCenter();
            dgvEducationalCenterList();
        }

        private async void dgvEducationalCenterList()
        {
            dgvEducationalList.DataSource = await _educationalCenterService.EducationalCenterList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_educationalCenter.ID > 0)
                Clear();
            else
                Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (_educationalCenter.ID > 0)
                {
                    _educationalCenter.EducationalName = txtEducation.Text.Trim();
                    _educationalCenter.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
                    var resultUpdate = await _educationalCenterService.Update(_educationalCenter);
                    PublicValues.Message(resultUpdate);
                    if (resultUpdate)
                    {
                        Clear();
                    }
                }
                else
                {
                    _educationalCenter = new EducationalCenter();
                    _educationalCenter.EducationalName = txtEducation.Text.Trim();
                    _educationalCenter.IsActive = chkIsActive.IsOn;
                    var resultAdd = _educationalCenterService.Add(_educationalCenter);
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

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _educationalCenter = new EducationalCenter();
            _educationalCenter = (EducationalCenter)focusedRow;
            txtID.EditValue = _educationalCenter.ID;
            chkIsActive.IsOn = _educationalCenter.IsActive;
            txtEducation.Text = _educationalCenter.EducationalName;

        }
    }
}
