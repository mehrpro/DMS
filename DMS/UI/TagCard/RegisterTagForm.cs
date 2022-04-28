using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace DMS.UI.TagCard
{
    public partial class RegisterTagForm : XtraForm
    {
        private readonly IRegisterTagService _registerTagService;
        private readonly IStudentService _studentService;
        private readonly ITagService _tagService;
        private Student _studentSelected;
        private Tag _selectTag;
        public RegisterTagForm(IRegisterTagService registerTagService, IStudentService studentService, ITagService tagService)
        {
            _studentService = studentService;
            _tagService = tagService;
            _registerTagService = registerTagService;
            InitializeComponent();
            StudentList();
            TagList();
            cbxStudent.Properties.DisplayMember = "FullName";
            cbxTag.Properties.DisplayMember = "CartView";
        }

        private void StudentList()
        {
            cbxStudent.Properties.DataSource = Task.Run(async () => await _studentService.StudentList()).Result;
        }

        private void TagList()
        {
            cbxTag.Properties.DataSource = Task.Run(async () => await _tagService.GetTagsEnabled()).Result;
        }

        private void Clear()
        {
            txtMobile.ResetText();
            txtFatherName.ResetText();
            txtFatherTel.ResetText();
            txtCodemelii.ResetText();
            txtHomeTel.ResetText();
            txtSmariDanshjoi.ResetText();
            TagList();
            cbxStudent.EditValue = 0;

        }

        private void cbxStudent_EditValueChanged(object sender, EventArgs e)
        {
            _studentSelected = (Student)cbxStudent.GetSelectedDataRow();
            if (_studentSelected == null)
            {
                dgvRegisterTagList.DataSource = null;
                dgvRegisterTagList.RefreshDataSource();
                return;
            }

            txtMobile.EditValue = _studentSelected.StudentTel;
            txtFatherName.EditValue = _studentSelected.FatherName;
            txtFatherTel.EditValue = _studentSelected.FatherTel;
            txtCodemelii.EditValue = _studentSelected.NationalCode;
            txtHomeTel.EditValue = _studentSelected.HomeTel;
            txtSmariDanshjoi.EditValue = _studentSelected.StudentCode;
            if (_studentSelected.Img != null)
            {
                MemoryStream ms = new MemoryStream(_studentSelected.Img);
                picPerson.Image = Image.FromStream(ms);
            }
            TagList();
            dgvRegisterTagList.DataSource = Task.Run(async () =>
                await _registerTagService.GetRegisterTagByStudentId(_studentSelected.StudentID)).Result;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                var result = _registerTagService.Add(_studentSelected.StudentID, _selectTag.ID);
                PublicValues.Message(result);
                Clear();

            }
            else
                PublicValues.ErrorValidate(Text);
        }

        private void cbxTag_EditValueChanged(object sender, EventArgs e)
        {
            _selectTag = (Tag)cbxTag.GetSelectedDataRow();
            if (_selectTag == null)
            {
                return;
            }

        }
    }
}
