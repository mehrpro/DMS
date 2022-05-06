using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DMS.UI.Dormitories
{
    public partial class TradodForm : XtraForm
    {
        private readonly ITradodService _tradodService;
        private readonly ITrafficTypeService _trafficTypeService;
        private readonly IStudentService _studentService;
        private readonly IDestinationService _destinationService;
        private readonly ISmsService _smsService;
        private BackgroundWorker _backgroundWorker;
        private Student _selectStudent;
        private TrafficType _selectTardod;
        private Destination _selectMagsad;

        public TradodForm(ITradodService tradodService
            , ITrafficTypeService trafficTypeService, IStudentService studentService, IDestinationService destinationService, ISmsService smsService)
        {
            _tradodService = tradodService;
            _trafficTypeService = trafficTypeService;
            _studentService = studentService;
            _destinationService = destinationService;
            _smsService = smsService;
            InitializeComponent();
            cbxStudentList.Properties.DisplayMember = "FullName";
            cbxStudentList.Properties.ValueMember = "StudentID";
            cbxTrafficType.Properties.DisplayMember = "TrafficTypeTitle";
            cbxMagsad.Properties.DisplayMember = "DestinationTitle";
            cbxStudentList.Properties.DataSource = Task.Run(async () => await _studentService.StudentList()).Result;
            cbxTrafficType.Properties.DataSource =
                Task.Run(async () => await _trafficTypeService.TrafficTypeList()).Result;
            cbxMagsad.Properties.DataSource =
                Task.Run(async () => await _destinationService.GetDestinationList()).Result;
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorkerOnRunWorkerCompleted;
            _backgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            marqueeProgressBarControl1.Visible = true;
        }

        private void BackgroundWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            marqueeProgressBarControl1.Visible = false;
            cbxStudentList.EditValue = 0;
            //if (e.Cancelled == true)
            //{
            //    resultLabel.Text = "Canceled!";
            //}
            //else if (e.Error != null)
            //{
            //    resultLabel.Text = "Error: " + e.Error.Message;
            //}
            //else
            //{
            //    resultLabel.Text = "Done!";
            //}
        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(10);
            var time = PublicValues.Convert_PersianCalender(DateTime.Now);
            var content = $" خروج {cbxStudentList.Text} به مقصد {cbxTrafficType.Text} {cbxMagsad.Text} در {time} ثبت گردید";
            var result = Send(Convert.ToInt64(_selectStudent.FatherTel), new string[] { content });
            if (result.Success)
            {
                XtraMessageBox.Show(result.ErrorMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                var newTradod = new Tradod();
                newTradod.StudentID_FK = _selectStudent.StudentID;
                newTradod.TrfficTypeID_FK = _selectTardod.ID;
                newTradod.DestinationID_FK = _selectMagsad.ID;
                newTradod.OutTime = DateTime.Now;
                newTradod.InCommingTime = DateTime.Now;
                newTradod.IsActive = true;
                newTradod.IsDelete = false;
                newTradod.UserID_FK = PublicValues.UserId;
                newTradod.SendSMS1 = true;
                newTradod.ReciverNumber1 = _selectStudent.FatherTel;
                newTradod.Delivery1 = result.ResultCode;
                newTradod.SendSMS2 = false;
                newTradod.ReciverNumber2 = "null";
                newTradod.Delivery2 = "null";
                var resultSave = _tradodService.Add(newTradod);
                PublicValues.Message(resultSave);
                
            }
            else
            {
                if (worker.CancellationPending) e.Cancel = true;
                var result2 = Send(Convert.ToInt64(_selectStudent.OtherTel), new string[] { content });
                if (result2.Success)
                {
                    XtraMessageBox.Show(result.ErrorMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var newTradod = new Tradod();
                    newTradod.StudentID_FK = _selectStudent.StudentID;
                    newTradod.TrfficTypeID_FK = _selectTardod.ID;
                    newTradod.DestinationID_FK = _selectMagsad.ID;
                    newTradod.OutTime = DateTime.Now;
                    newTradod.InCommingTime = default;
                    newTradod.IsActive = true;
                    newTradod.IsDelete = false;
                    newTradod.UserID_FK = PublicValues.UserId;
                    newTradod.SendSMS1 = false;
                    newTradod.ReciverNumber1 = "Error";
                    newTradod.Delivery1 = "Error";
                    newTradod.SendSMS2 = true;
                    newTradod.ReciverNumber2 = _selectStudent.OtherTel;
                    newTradod.Delivery2 = result2.ResultCode;
                    var resultSave = _tradodService.Add(newTradod);
                    PublicValues.Message(resultSave);
                    
                }
                else
                    e.Cancel = true;
            }
        }

        private ResultMessage Send(long mobile, string[] contentStrings)
        {
            return Task.Run(async () => await _smsService.SendSms(mobile, contentStrings)).Result;
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
            _selectStudent = (Student)cbxStudentList.GetSelectedDataRow();
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
            if (dxValidationProvider1.Validate())
            {
                if (_backgroundWorker.IsBusy == false) _backgroundWorker.RunWorkerAsync();
            }
            else
                PublicValues.ErrorValidate(Text);
        }

        private void cbxTrafficType_EditValueChanged(object sender, EventArgs e)
        {
             _selectTardod = (TrafficType)cbxTrafficType.GetSelectedDataRow();

        }

        private void cbxMagsad_EditValueChanged(object sender, EventArgs e)
        {
            _selectMagsad = (Destination)cbxMagsad.GetSelectedDataRow();
        }
    }
}
