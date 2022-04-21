using System;
using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;

namespace DMS.UI.Dormitories
{
    public partial class RoomForm : XtraForm
    {
        private readonly IDormitoryService _dormitoryService;
        private readonly IRoomService _roomService;
        private Room _room;

        public RoomForm(IDormitoryService dormitoryService, IRoomService roomService)
        {
            _dormitoryService = dormitoryService;
            _roomService = roomService;
            InitializeComponent();
            cbxDormitory.Properties.DisplayMember = "DormitoryName";
            cbxDormitory.Properties.ValueMember = "ID";
            CbxDormitoryList();
            Clear();
        }

        private async void CbxDormitoryList()
        {
            cbxDormitory.Properties.DataSource = await _dormitoryService.ListDormitory();
        }

        private async void dgvRoomList()
        {
            var select = (Dormitory)cbxDormitory.GetSelectedDataRow();
            if (select == null)
            {
                return;
            }
            dgvRoom.DataSource = await _roomService.GetRoomByDormitoryID(select.ID);
        }
        private async void cbxDormitory_EditValueChanged(object sender, EventArgs e)
        {
            dgvRoomList();
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("RoomID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _room = new Room();
            _room = (Room)focusedRow;
            txtID.EditValue = _room.RoomID;
            cbxDormitory.Enabled = false;
            txtShomareOtagh.EditValue = _room.RoomNumber;
            txtZarfitOtagh.EditValue = _room.RoomCapacity;

            cbxEmkanat.EditValue = _room.IntFacilities;
            cbxEmkanat.RefreshEditValue();
            // cbxEmkanat.Text = _room.Facilities;

        }

        private void Clear()
        {
            txtID.EditValue = 0;
            txtShomareOtagh.EditValue = 0;
            txtZarfitOtagh.EditValue = 0;
            cbxEmkanat.EditValue = 0;
            cbxDormitory.Enabled = true;
 
            cbxEmkanat.EditValue = 0;
            cbxEmkanat.RefreshEditValue();


            _room = new Room();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_room.RoomID > 0)
            {
                Clear();
            }
            else
            {
                Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (_room.RoomID > 0)
                {
                    _room.DormitoryID_FK = Convert.ToInt32(cbxDormitory.EditValue);
                    _room.RoomCapacity = Convert.ToInt32(txtZarfitOtagh.Text);
                    _room.RoomNumber = txtShomareOtagh.Text.Trim();
                    _room.Facilities = cbxEmkanat.Text;
                    _room.IntFacilities = cbxEmkanat.EditValue.ToString();
                    var resultUpdate = await _roomService.Update(_room);
                    PublicValues.Message(resultUpdate);
                    if (resultUpdate)
                    {
                        Clear();
                        dgvRoomList();
                    }



                }
                else
                {
                    _room = new Room();
                    _room.DormitoryID_FK = Convert.ToInt32(cbxDormitory.EditValue);
                    _room.RoomCapacity = Convert.ToInt32(txtZarfitOtagh.Text);
                    _room.RoomNumber = txtShomareOtagh.Text.Trim();
                    _room.Facilities = cbxEmkanat.Text;
                    _room.IntFacilities = cbxEmkanat.EditValue.ToString();
                    var resultUpdate = _roomService.Add(_room);
                    PublicValues.Message(resultUpdate);
                    if (resultUpdate)
                    {
                        Clear();
                        dgvRoomList();
                    }
                }
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }
    }
}
