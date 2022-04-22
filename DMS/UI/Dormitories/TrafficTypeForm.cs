using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;

namespace DMS.UI.Dormitories
{
    public partial class TrafficTypeForm : XtraForm
    {
        private readonly ITrafficTypeService _trafficTypeService;
        private TrafficType _trafficType;

        public TrafficTypeForm(ITrafficTypeService trafficTypeService)
        {
            _trafficTypeService = trafficTypeService;
            InitializeComponent();
            dgvTrafficTypeList();
            _trafficType = new TrafficType();
        }

        private void Clear()
        {
            txtTrafficTypeTitle.ResetText();
            txtTrafficTypeTitle.Focus();
            _trafficType = new TrafficType();
            dgvTrafficTypeList();
        }
        private async void dgvTrafficTypeList()
        {
            dgvTrafficType.DataSource = await _trafficTypeService.TrafficTypeList();
        }
        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (_trafficType.ID > 0)
                {
                    _trafficType.TrafficTypeTitle = txtTrafficTypeTitle.Text;
                    var resultUpdate = await _trafficTypeService.Update(_trafficType);
                    PublicValues.Message(resultUpdate);
                    if (resultUpdate)

                        Clear();


                }
                else
                {
                    _trafficType = new TrafficType();
                    _trafficType.TrafficTypeTitle = txtTrafficTypeTitle.Text.Trim();
                    var resultAdd = _trafficTypeService.Add(_trafficType);
                    PublicValues.Message(resultAdd);
                    if (resultAdd)

                        Clear();

                }
            }
            else
            {
                PublicValues.ErrorValidate(Text);
            }
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _trafficType = new TrafficType();
            _trafficType = (TrafficType)focusedRow;
            txtTrafficTypeTitle.Text = _trafficType.TrafficTypeTitle;

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            if (_trafficType.ID > 0)
            {
                Clear();
            }
            else
            {
                Close();
            }
        }
    }
}
