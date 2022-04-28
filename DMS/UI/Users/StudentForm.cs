using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace DMS.UI.Users
{
    public partial class StudentForm : XtraForm
    {
        private readonly IStudentService _studentService;
        private readonly IEducationalCenterService _educationalCenterService;
        private readonly IFieldOfStudyService _studyService;
        private Student _student;
        public StudentForm(IStudentService studentService,
                            IEducationalCenterService educationalCenterService,
                            IFieldOfStudyService studyService)
        {
            _studentService = studentService;
            _educationalCenterService = educationalCenterService;
            _studyService = studyService;
            InitializeComponent();
            cbxEducational.Properties.DisplayMember = "EducationalName";
            cbxEducational.Properties.ValueMember = "ID";
            cbxStudy.Properties.DisplayMember = "StudyTitle";
            cbxStudy.Properties.ValueMember = "ID";
            //cbxEducationList();
            CbxEducationList();
            StudentList();
            Clear();

        }

        private  void StudentList()
        {
            dgvStudentList.DataSource =Task.Run(async ()=> await _studentService.StudentList()).Result;
        }

        private void Clear()
        {
            txtBastega.ResetText();
            txtBasteganTel.ResetText();
            txtCodemelii.ResetText();
            txtFatherName.ResetText();
            txtFatherTel.ResetText();
            txtFullName.ResetText();
            txtHomeTel.ResetText();
            txtMobile.ResetText();
            txtSmariDanshjoi.ResetText();
            cbxEducational.EditValue = cbxStudy.EditValue = 0;
            datTavalod.DateTime = DateTime.Today;
            picPerson.Image = null;
            _student = new Student();
            StudentList();


        }
        private  void CbxEducationList()
        {
            cbxEducational.Properties.DataSource =Task.Run(async ()=> await _educationalCenterService.EducationalCenterList()).Result;
            cbxStudy.Properties.DataSource =Task.Run(async ()=>  await _studyService.StudyList()).Result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_student.StudentID > 0)
            {
                Clear();
            }
            else
            {
                Close();
            }
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("StudentID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _student = new Student();
            _student = (Student)focusedRow;
            cbxStudy.EditValue = _student.StudyID_FK;
            cbxEducational.EditValue = _student.EducationalID_FK;
            txtBastega.Text = _student.OtherName;
            txtBasteganTel.Text = _student.OtherTel;
            txtCodemelii.Text = _student.NationalCode;
            txtFatherName.Text = _student.FatherName;
            txtFatherTel.Text = _student.FatherTel;
            txtFullName.Text = _student.FullName;
            txtHomeTel.Text = _student.HomeTel;
            txtMobile.Text = _student.StudentTel;
            txtSmariDanshjoi.Text = _student.StudentCode;
            datTavalod.DateTime = _student.Birthday.Date;
            if (_student.Img != null)
            {
                MemoryStream ms = new MemoryStream(_student.Img);
                picPerson.Image = Image.FromStream(ms);
            }
        }

        private async Task SaveMethod()
        {
            if (_student.StudentID > 0)
            {
                _student.StudyID_FK = Convert.ToInt32(cbxStudy.EditValue);
                _student.EducationalID_FK = Convert.ToInt32(cbxEducational.EditValue);
                _student.OtherName = txtBastega.Text;
                _student.OtherTel = txtBasteganTel.Text;
                _student.NationalCode = txtCodemelii.Text;
                _student.FatherName = txtFatherName.Text;
                _student.FatherTel = txtFatherTel.Text;
                _student.FullName = txtFullName.Text;
                _student.HomeTel = txtHomeTel.Text;
                _student.StudentTel = txtMobile.Text;
                _student.StudentCode = txtSmariDanshjoi.Text;
                _student.Birthday = datTavalod.DateTime.Date;
                if (picPerson.Image != null)
                    _student.Img = picPerson.Image.ImageToByte();
                else
                    _student.Img = null;
                var resultUpdate = await _studentService.Update(_student);
                PublicValues.Message(resultUpdate);
                if (resultUpdate) Clear();
            }
            else
            {
                _student = new Student();
                _student.StudyID_FK = Convert.ToInt32(cbxStudy.EditValue);
                _student.EducationalID_FK = Convert.ToInt32(cbxEducational.EditValue);
                _student.OtherName = txtBastega.Text;
                _student.OtherTel = txtBasteganTel.Text;
                _student.NationalCode = txtCodemelii.Text;
                _student.FatherName = txtFatherName.Text;
                _student.FatherTel = txtFatherTel.Text;
                _student.FullName = txtFullName.Text;
                _student.HomeTel = txtHomeTel.Text;
                _student.StudentTel = txtMobile.Text;
                _student.StudentCode = txtSmariDanshjoi.Text;
                _student.Birthday = datTavalod.DateTime.Date;
                var resultAdd = _studentService.Add(_student);
                PublicValues.Message(resultAdd);
                if (resultAdd) Clear();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                SaveMethod().Wait();
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }
    }
}
