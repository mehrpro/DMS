﻿using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.UI.Dormitories
{
    public partial class RegisterRoomForm : XtraForm
    {
        private readonly IRegisterRoomService _registerRoomService;
        private readonly IDormitoryService _dormitoryService;
        private readonly IRoomService _roomService;
        private readonly IStudentService _studentService;
        private RegisterRoom _registerRoom;
        private Room _selectRoom;
        private Dormitory _selectDormitory;
        private Student _selectStudent;
        private RegisterRoom _resultFelii;

        public RegisterRoomForm(IRegisterRoomService registerRoomService, IDormitoryService dormitoryService,
            IRoomService roomService, IStudentService studentService)
        {
            _registerRoomService = registerRoomService;
            _dormitoryService = dormitoryService;
            _roomService = roomService;
            _studentService = studentService;
            InitializeComponent();

            cbxDormitory.Properties.DisplayMember = "DormitoryName";
            cbxDormitory.Properties.ValueMember = "ID";
            cbxDormitory.Properties.DataSource = Task.Run(async () => await _dormitoryService.ListDormitory()).Result;

            cbxRooms.Properties.DisplayMember = "RoomNumber";
            cbxRooms.Properties.ValueMember = "RoomID";


            cbxStudent.Properties.DisplayMember = "FullName";
            cbxStudent.Properties.ValueMember = "StudentID";


        }

        private void cbxStudentList()
        {
            var resultAll = Task.Run(async () => await _studentService.StudentList()).Result;
            var x = resultAll.ToList();
            var resultRemove = Task.Run(async () => await _registerRoomService.GetRegisterRoomByRoomID(_selectRoom.RoomID)).Result;
            var registers = resultRemove.ToList();
            var removeIdList = registers.GroupBy(x => x.StudentID_FK).Select(x => x.First()).ToList().Select(x=>x.StudentID_FK);
            foreach (var item in removeIdList)
            {
                var findRemove = resultAll.FirstOrDefault(x => x.StudentID == item);
                if (findRemove != null)
                {
                    x.Remove(findRemove);
                }
            }
            cbxStudent.Properties.DataSource = x;
        }

        private void Clear()
        {
           
            cbxStudentList();
            cbxStudent.EditValue = 0;

        }



        private void cbxDormitory_EditValueChanged(object sender, System.EventArgs e)
        {
            _selectDormitory = (Dormitory)cbxDormitory.GetSelectedDataRow();
            if (_selectDormitory == null)
            {
                cbxRooms.Properties.DataSource = null;
                cbxStudent.Properties.DataSource = null;
                txtOtagh.ResetText();
                txtMandehKol.ResetText();
                txtMandehOtagh.ResetText();
                txtZarfit.ResetText();
                return;
            }
            cbxRooms.Properties.DataSource = Task.Run(async () => await _roomService.GetRoomByDormitoryID(_selectDormitory.ID)).Result;
            txtOtagh.Text = _selectDormitory.Room.ToString();
            txtZarfit.Text = _selectDormitory.Valence.ToString();
            txtMandehKol.EditValue = Task.Run(async () => await _dormitoryService.MandehKol(_selectDormitory.ID)).Result;

        }
        private void dgvRegisterRoomList()
        {
            dgvRegisterRoom.DataSource =
                          Task.Run(async () => await _registerRoomService.GetRegisterRoomByRoomID(_selectRoom.RoomID)).Result;
        }
        private void cbxRooms_EditValueChanged(object sender, System.EventArgs e)
        {
            _selectRoom = (Room)cbxRooms.GetSelectedDataRow();
            if (_selectRoom == null)
            {
                txtMandehOtagh.ResetText();
                cbxStudent.Properties.DataSource = null;
                return;
            }
            txtZarfiatOtagh.EditValue = _selectRoom.RoomCapacity;
            txtEmkanatOtagh.EditValue = _selectRoom.Facilities;
            cbxStudentList();
            dgvRegisterRoomList();
            txtMandehOtagh.EditValue =
                Task.Run(async () => await _registerRoomService.MandehOtagh(_selectRoom.RoomID)).Result;



        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            //if (_registerRoom.ID > 0)
            //{
            //    Clear();
            //}
            //else
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                int mandeh = Convert.ToInt32(txtMandehOtagh.EditValue);
                int zarfiatOtagh = Convert.ToInt32(txtZarfiatOtagh.EditValue);
                //var listOtagh = 
                if (mandeh < 1)
                {
                    XtraMessageBox.Show(@"ظرفیت اتاق تکمیل است", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else if (dgvRegisterRoom.)
                //{

                //}
                else
                {
                    _registerRoom = new RegisterRoom();
                    _registerRoom.IsActive = true;
                    _registerRoom.RoomID_FK = _selectRoom.RoomID;
                    _registerRoom.StudentID_FK = _selectStudent.StudentID;
                    var resultAdd = _registerRoomService.Add(_registerRoom);
                    PublicValues.Message(resultAdd);
                    if(resultAdd)
                    {
                        Clear();
                        dgvRegisterRoomList();
                    }
                }
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }

        private void cbxStudent_EditValueChanged(object sender, System.EventArgs e)
        {
            _selectStudent = (Student)cbxStudent.GetSelectedDataRow();
            if (_selectStudent == null)
            {
                txtOtaghFelii.ResetText();
                txtOtaghFelii.EditValue = null;
                txtEmkanatFelli.EditValue = null;
                return;
            }

            _resultFelii = Task.Run(async () => await _registerRoomService.GetRoomByStudentID(_selectStudent.StudentID)).Result;
            if (_resultFelii == null)
            {
                txtOtaghFelii.Text = txtEmkanatFelli.Text = "";
            }
            else
            {
                txtOtaghFelii.Text = _resultFelii.Room.RoomNumber;
                txtEmkanatFelli.Text = _resultFelii.Room.Facilities;
            }
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (layoutView1.GetFocusedRowCellValue("ID") == null) return;
            var selected =(RegisterRoom)layoutView1.GetFocusedRow();
            var dialog = XtraMessageBox.Show(@"آیا شما از حذف این مورد اطمینان دارید ؟", "خروج نفر از اتاق", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                var resultRemove = Task.Run(async () => await _registerRoomService.RemoveStudentFromRoom(selected.ID)).Result;
                if (!resultRemove)
                {
                    PublicValues.ErrorSave(Text);
                }
                else
                {
                    Clear();
                }
            }
        }
    }
}
