using DMS.UI.Dormitories;
using DMS.UI.TagCard;
using DMS.UI.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DMS.Entities;
using DMS.Repositories;
using DMS.UI.Administrator;


namespace DMS.UI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUnitOfWork _unitOfWork;
        private StructureMap.Container _mainContainer;

        public StructureMap.Container MainContainer
        {
            get => _mainContainer;
            set => _mainContainer = value;
        }

        public MainForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }



        private void mnuDormitoryForm_Click(object sender, EventArgs e)
        {
            //foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<DormitoryForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
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
            //foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<TrafficTypeForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void btnEducationalCenter_Click(object sender, EventArgs e)
        {
            //foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<EducationalCentersForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
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
            //foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<FieldOfStudyForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
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
            //foreach (var x in this.MdiChildren) x.Close();
            var frm = _mainContainer.GetInstance<RegisterTagForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void btnTradod_Click(object sender, EventArgs e)
        {
            var frm = _mainContainer.GetInstance<TradodForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.MainContainer = _mainContainer;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var frm = _mainContainer.GetInstance<AccountForm>();
            //frm.ControlBox = false;
            //frm.Dock = DockStyle.Fill;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.MainContainer = _mainContainer;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void btnMenuBuilder_Click(object sender, EventArgs e)
        {
            var mu = munMain.Elements.ToArray();
            var master = new List<AccordionControl>();
            foreach (var accordionControlElement in mu)
            {
                var item = accordionControlElement.Text;
                foreach (var element in accordionControlElement.Elements)
                {
                    _unitOfWork.AccordionElement.Add(new AccordionElement()
                    {
                        AccTag = accordionControlElement.Tag.ToString(),
                        EleTag = element.Tag.ToString(),
                        IsActive = true,
                    });
                }

            }
            _unitOfWork.Commit();


        }
    }
}
