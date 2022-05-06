using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DMS.Entities;
using DMS.IServices;

namespace DMS.UI.Administrator
{
    public partial class AccessForm : XtraForm
    {
        private readonly IApplicationUserService _applicationUserService;
        private readonly IElementUserService _elementUserService;
        private readonly IAccordionElementService _accordionElementService;
        private ApplicationUser _selectUser;

        public AccessForm(IApplicationUserService applicationUserService, IElementUserService elementUserService,
            IAccordionElementService accordionElementService)
        {
            _applicationUserService = applicationUserService;
            _elementUserService = elementUserService;
            _accordionElementService = accordionElementService;
            InitializeComponent();
            cbxUserList.Properties.DisplayMember = "Username";
            cbxUserList.Properties.ValueMember = "UserID";
            UserList();
            CreateColumnsTreeList(treeListAccess);
        }


        private void CreateColumnsTreeList(TreeList tl)
        {
            tl.BeginUpdate();
            TreeListColumn col = tl.Columns.Add();
            col.Caption = "منوهای نرم افزار";
            col.VisibleIndex = 0;
            tl.EndUpdate();
        }


        private void CreateTreeList(int userId)
        {
            treeListAccess.BeginUnboundLoad();
            treeListAccess.ClearNodes();
            TreeListNode treeListNodeParent = null;
            var cleamList = _elementUserService.GetCleamByUserId(userId);
            var getGroup = _accordionElementService.GetGroup();
            var groupList = getGroup.GroupBy(x => x.AccTag).Select(x => x.First()).ToList();
            foreach (var item in groupList)
            {
                var app = treeListAccess.AppendNode(new object[] { item.AccStr },
                    treeListNodeParent, CheckState.Unchecked, NodeCheckBoxStyle.Check, item.AccTag);
                var itemGroup = getGroup.Where(x => x.AccTag == item.AccTag);
                foreach (var menuItem in itemGroup)
                {
                    var child = treeListAccess.AppendNode(new object[] { menuItem.EleStr }, app.Id, menuItem.ID);
                    if (cleamList.Count() > 0)
                    {
                        var isdelete = cleamList.SingleOrDefault(x => x.AccordionElement.EleTag == menuItem.EleTag);
                        child.Checked = isdelete == null ? false : isdelete.IsActive;
                    }
                    else
                        child.Checked = false;
                }
            }
            treeListAccess.EndUnboundLoad();
            treeListAccess.ExpandAll();


        }
        private void UserList()
        {
            cbxUserList.Properties.DataSource = Task.Run(async () => await _applicationUserService.GetAllUser()).Result;
        }

        private void cbxUserList_EditValueChanged(object sender, EventArgs e)
        {
            _selectUser = (ApplicationUser)cbxUserList.GetSelectedDataRow();
            if (_selectUser == null)
            {
                return;
            }
            CreateTreeList(_selectUser.UserID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newCleam = new List<ElementUser>();
            var grp = treeListAccess.Nodes.ToList();
            foreach (var group in grp)
            {
                var itm = group.Nodes.ToList();
                foreach (var item in itm )
                {
                    var elementUser = new ElementUser();
                    elementUser.UserID_FK = _selectUser.UserID;
                    elementUser.AccordionID_FK =Convert.ToInt32( item.Tag);
                    elementUser.IsActive = Convert.ToBoolean(item.CheckState);
                    newCleam.Add(elementUser);
                }
            }

            var result = _elementUserService.AddOrUpdateCleam(newCleam);
            PublicValues.Message(result);
             CreateTreeList(_selectUser.UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
