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
            var selectDormitory = (Dormitory)cbxDormitory.GetSelectedDataRow();
            if (selectDormitory == null)
            {
                cbxRooms.Properties.DataSource = null;
                cbxStudent.Properties.DataSource = null;
                txtOtagh.ResetText();
                txtMandehKol.ResetText();
                txtMandehOtagh.ResetText();
                txtZarfit.ResetText();
                return;
            }
            cbxRooms.Properties.DataSource = Task.Run(async () => await _roomService.GetRoomByDormitoryID(selectDormitory.ID)).Result;
            txtOtagh.Text = selectDormitory.Room.ToString();
            txtZarfit.Text = selectDormitory.Valence.ToString();
            txtMandehKol.EditValue = Task.Run(async () => await _dormitoryService.MandehKol(selectDormitory.ID)).Result;

        }

        private void cbxRooms_EditValueChanged(object sender, System.EventArgs e)
        {
            var selectRoom = (Room)cbxRooms.GetSelectedDataRow();
            if (selectRoom == null)
            {
                txtMandehOtagh.ResetText();
                cbxStudent.Properties.DataSource = null;
                return;
            }
            dgvRegisterRoom.DataSource =
                Task.Run(async () => await _registerRoomService.GetRegisterRoomByRoomID(selectRoom.RoomID)).Result;
            txtMandehOtagh.EditValue =
                Task.Run(async () => await _registerRoomService.MandehOtagh(selectRoom.RoomID)).Result;

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
                
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }

        private void cbxStudent_EditValueChanged(object sender, System.EventArgs e)
        {
            var selectStudent = (Student)cbxStudent.GetSelectedDataRow();
            if (selectStudent == null)
            {
                txtOtaghFelii.ResetText();
                txtOtaghFelii.EditValue = null;
                return;
            }

            var resultFelii = Task.Run(async () => await _registerRoomService.GetRoomByStudentID(selectStudent.StudentID)).Result;
            if (resultFelii == null)
            {
                txtOtaghFelii.Text = "";
            }
            else
            {
                txtOtaghFelii.Text = resultFelii.Room.RoomNumber;
            }
        }
    }
}
