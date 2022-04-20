using DevExpress.XtraEditors;
using DMS.IServices;

namespace DMS.UI.Dormitories
{
    public partial class RoomForm : XtraForm
    {
        private readonly IDormitoryService _dormitoryService;
        private readonly IRoomService _roomService;

        public RoomForm(IDormitoryService dormitoryService, IRoomService roomService)
        {
            _dormitoryService = dormitoryService;
            _roomService = roomService;
            InitializeComponent();
            cbxDormitory.Properties.DisplayMember = "DormitoryName";
            cbxDormitory.Properties.ValueMember = "ID";
            cbxDormitoryList();
        }

        private async void cbxDormitoryList()
        {
            cbxDormitory.Properties.DataSource = await _dormitoryService.ListDormitory();
        }

        private void cbxDormitory_EditValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
