using DevExpress.XtraEditors;
using DMS.Entities;
using DMS.IServices;
using System;
using System.Windows.Forms;

namespace DMS.UI.Dormitories
{
    public partial class DormitoryForm : XtraForm
    {

        private readonly IDormitoryService _dormitoryService;
        private Dormitory _dormitory;

        public DormitoryForm(IDormitoryService dormitoryService)
        {
            _dormitoryService = dormitoryService;
            InitializeComponent();
            Clear();
        }
        private async void UpdateList()
        {
            dgvList.DataSource = await _dormitoryService.ListDormitory();
        }
        private void Clear()
        {
            _dormitory = new Dormitory();
             txtOtagh.EditValue = txtZarfiat.EditValue = 0;
            txtTitle.EditValue = "";
            txtTitle.Focus();
            UpdateList();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (_dormitory.ID > 0)
                {
                    _dormitory.DormitoryName = txtTitle.Text.Trim();
                    _dormitory.Room = Convert.ToInt32(txtOtagh.Text);
                    _dormitory.Valence = Convert.ToInt32(txtZarfiat.Text);
                    var resultu = await _dormitoryService.Update(_dormitory);
                    if (resultu)
                    {
                        PublicValues.SuccessSave(Text);
                        Clear();
                    }
                    else
                    {
                        PublicValues.ErrorSave(Text);
                    }
                }
                else
                {


                    _dormitory = new Dormitory();
                    _dormitory.DormitoryName = txtTitle.Text.Trim();
                    _dormitory.Room = Convert.ToInt32(txtOtagh.Text);
                    _dormitory.Valence = Convert.ToInt32(txtZarfiat.Text);
                    var result = _dormitoryService.AddDormitory(_dormitory);
                    if (result)
                    {
                        PublicValues.SuccessSave(Text);
                        Clear();
                    }
                    else
                        PublicValues.ErrorSave(Text);
                }
            }
            else
                PublicValues.ErrorValidate(this.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") == null) return;
            var focusedRow = gridView1.GetFocusedRow();
            _dormitory = new Dormitory();
            _dormitory = (Dormitory)focusedRow;
           
            txtOtagh.EditValue = _dormitory.Room;
            txtTitle.EditValue = _dormitory.DormitoryName;
            txtZarfiat.EditValue = _dormitory.Valence;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_dormitory.ID > 0)
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
