using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;

namespace DMS.UI.Dormitories
{
    public partial class TradodForm : XtraForm
    {
        private readonly ITradodService _tradodService;
        private readonly ITrafficTypeService _trafficTypeService;
        private readonly IStudentService _studentService;
        private readonly IDestinationService _destinationService;

        public TradodForm(ITradodService tradodService
            ,ITrafficTypeService trafficTypeService,IStudentService studentService,IDestinationService destinationService)
        {
            _tradodService = tradodService;
            _trafficTypeService = trafficTypeService;
            _studentService = studentService;
            _destinationService = destinationService;
            InitializeComponent();
            cbxStudentList.Properties.DisplayMember = "FullName";
            cbxTrafficType.Properties.DisplayMember = "TrafficTypeTitle";
            cbxMagsad.Properties.DisplayMember = "DestinationTitle";
            cbxStudentList.Properties.DataSource = Task.Run(async () => await _studentService.StudentList()).Result;
            cbxTrafficType.Properties.DataSource =
                Task.Run(async () => await _trafficTypeService.TrafficTypeList()).Result;
            cbxMagsad.Properties.DataSource =
                Task.Run(async () => await _destinationService.GetDestinationList()).Result;
        }

        private void Clear()
        {
            txtMobile.ResetText();
            txtBastega.ResetText();
            txtBasteganTel.ResetText();
            txtCodemelii.ResetText();
            txtDescription.ResetText();
            txtFatherName.ResetText();
            txtFatherTel.ResetText();
            txtHomeTel.ResetText();
            txtSmariDanshjoi.ResetText();
            picPerson.Image = null;
        }
        private void cbxStudentList_EditValueChanged(object sender, EventArgs e)
        {
            var _selectStudent = (Student)cbxStudentList.GetSelectedDataRow();
            if (_selectStudent == null)
            {
                Clear();
                return;
            }

            txtBastega.EditValue = _selectStudent.OtherName;
            txtMobile.EditValue = _selectStudent.StudentTel;
            txtCodemelii.EditValue = _selectStudent.NationalCode;
            txtFatherName.EditValue = _selectStudent.FatherName;
            txtFatherTel.EditValue = _selectStudent.FatherTel;
            txtHomeTel.EditValue = _selectStudent.HomeTel;
            txtSmariDanshjoi.EditValue = _selectStudent.StudentCode;
            txtBasteganTel.EditValue = _selectStudent.OtherTel;
            if (_selectStudent.Img != null)
            {
                MemoryStream ms = new MemoryStream(_selectStudent.Img);
                picPerson.Image = Image.FromStream(ms);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {

        }
    }
}
