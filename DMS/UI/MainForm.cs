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
using DMS.Entities;
using DMS.UI.Dormitories;
using DMS.UI.Users;
using Container = StructureMap.Container;
using DMS.UI.TagCard;

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

        private void btnTrafficType_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<TrafficTypeForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEducationalCenter_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<EducationalCentersForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<StudentForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnStudyForm_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<FieldOfStudyForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRegisterRoom_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<RegisterRoomForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRegisterTag_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<RegisterTagForm>();
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
