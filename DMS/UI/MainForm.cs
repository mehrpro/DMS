using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS.UI.Dormitories;
using Container = StructureMap.Container;

namespace DMS.UI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private Container _mainContainer;

        public StructureMap.Container MainContainer
        {
            get => _mainContainer;
            set => _mainContainer = value;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuDormitoryForm_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<DormitoryForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<RoomForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
