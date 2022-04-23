using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;

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
            cbxStudent.Properties.DataSource =
                Task.Run(async () => await _studentService.StudentList()).Result;
        }

        private void CbxDormitoryList()
        {

        }

        private void Clear()
        {

        }

        private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

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

        private void cbxRooms_EditValueChanged(object sender, System.EventArgs e)
        {
            _selectRoom = (Room)cbxRooms.GetSelectedDataRow();
            if (_selectRoom == null)
            {
                txtMandehOtagh.ResetText();
                cbxStudent.Properties.DataSource = null;
                return;
            }
            dgvRegisterRoom.DataSource =
                Task.Run(async () => await _registerRoomService.GetRegisterRoomByRoomID(_selectRoom.RoomID)).Result;
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
                _registerRoom = new RegisterRoom();
                _registerRoom.IsActive = true;
                _registerRoom.RoomID_FK = _selectRoom.RoomID;
                _registerRoom.StudentID_FK = _selectStudent.StudentID;
                if (_resultFelii != null)
                {
                    if (_resultFelii.RoomID_FK == _selectRoom.RoomID)
                    {
                        XtraMessageBox.Show(@"بدون تغیرات ثبت شد!");
                    }

                    if (_resultFelii.RoomID_FK != _selectRoom.RoomID)
                    {

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
                return;
            }

            _resultFelii = Task.Run(async () => await _registerRoomService.GetRoomByStudentID(_selectStudent.StudentID)).Result;
            if (_resultFelii == null)
            {
                txtOtaghFelii.Text = txtEmkanat.Text = "";
            }
            else
            {
                txtOtaghFelii.Text = _resultFelii.Room.RoomNumber;
                txtEmkanat.Text = _resultFelii.Room.Facilities;
            }
        }
    }
}
