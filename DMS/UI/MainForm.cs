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
        //private readonly IUnitOfWork _unitOfWork;
        private StructureMap.Container _mainContainer;
        private IEnumerable<ElementUser> _accessLists;
        public IEnumerable<ElementUser> AccessLists
        {
            get => _accessLists;
            set => _accessLists = value;
        }
        public StructureMap.Container MainContainer
        {
            get => _mainContainer;
            set => _mainContainer = value;
        }

        public MainForm()
        {
            //_unitOfWork = unitOfWork;
            InitializeComponent();
            //if (AccessLists.Any())
            //{
            //    DisableMenu();
            //}
            //else
            //{
            //    Environment.Exit(1);
            //}
        }


        private void DisableMenu()
        {
            
            foreach (var item in munMain.Elements.ToList())
            {
                item.Visible = false;
                foreach (var itemElement in item.Elements)
                {
                    itemElement.Visible = false;
                }
            }

            var grp = _accessLists.Where(x => x.IsActive).GroupBy(x => x.AccordionElement.AccTag).Select(x => x.First()).ToList();
            foreach (var elementUser in grp)
            {
                var find = munMain.Elements.FirstOrDefault(x => x.Tag.ToString() == elementUser.AccordionElement.AccTag);
                if (find != null)
                {
                    find.Visible = true;
                    var list = munMain.Elements.Where(x => x.Tag.ToString() ==find.Tag.ToString());
                    foreach (var user in _accessLists.Where(x=>x.AccordionElement.AccTag == elementUser.AccordionElement.AccTag && x.IsActive))
                    {
                        var findItem = list.FirstOrDefault(x => x.Elements.Element.Tag.ToString() == user.AccordionElement.EleTag);
                        if (findItem != null)
                        {
                            findItem.Visible = true;
                        }
                    }
                }

            }

        }


        private void mnuDormitoryForm_Click(object sender, EventArgs e)
        {
            var frm = _mainContainer.GetInstance<DormitoryForm>();
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
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
            //var mu = munMain.Elements.ToArray();
            //var master = new List<AccordionControl>();
            //foreach (var accordionControlElement in mu)
            //{
            //    var item = accordionControlElement.Text;
            //    foreach (var element in accordionControlElement.Elements)
            //    {
            //        _unitOfWork.AccordionElement.Add(new AccordionElement()
            //        {
            //            AccTag = accordionControlElement.Tag.ToString(),
            //            AccStr = accordionControlElement.Text.Trim(),
            //            EleStr = element.Text.Trim(),
            //            EleTag = element.Tag.ToString()
            //        });
            //    }

            //}
            //_unitOfWork.Commit();


        }

        private void btnUserAccess_Click(object sender, EventArgs e)
        {
            var frm = _mainContainer.GetInstance<AccessForm>();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (AccessLists.Any())
            {
                DisableMenu();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
