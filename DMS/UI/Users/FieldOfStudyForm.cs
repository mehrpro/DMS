using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DMS.Entities;
using DMS.IServices;
using System;

namespace DMS.UI.Users
{
    public partial class FieldOfStudyForm : XtraForm
    {
        private readonly IFieldOfStudyService _studyService;
        private Study _study;
        public FieldOfStudyForm(IFieldOfStudyService studyService)
        {
            _studyService = studyService;
            InitializeComponent();

            Clear();
        }





        private async void StudyList()
        {
            dgvStudyList.DataSource = await _studyService.StudyList();
        }
        private void Clear()
        {
            txtStudy.ResetText();
            chkIsActive.IsOn = true;
            txtStudy.Focus();
            _study = new Study();
            StudyList();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_study.ID > 0)
                Clear();
            else
                Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (_study.ID > 0)
                {
                    _study.StudyTitle = txtStudy.Text.Trim();
                    _study.IsActive = chkIsActive.IsOn;
                    var resultUpdate = await _studyService.Update(_study);
                    PublicValues.Message(resultUpdate);
                    if (resultUpdate) Clear();
                }
                else
                {
                    _study = new Study();
                    _study.StudyTitle = txtStudy.Text.Trim();
                    _study.IsActive = chkIsActive.IsOn;
                    var resultAdd = _studyService.Add(_study);
                    PublicValues.Message(resultAdd);
                    if (resultAdd) Clear();
                }
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }

        private void btnSelect_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _study = new Study();
            _study = (Study)focusedRow;
            txtStudy.Text = _study.StudyTitle;
            chkIsActive.IsOn = _study.IsActive;
        }
    }
}
