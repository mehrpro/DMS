
namespace DMS.UI.Administrator
{
    partial class AccessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cbxUserList = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsernameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JobColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccessColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.treeListAccess = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.cbxUserList);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(501, 66);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(22, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "انصراف";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(96, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxUserList
            // 
            this.cbxUserList.Location = new System.Drawing.Point(181, 24);
            this.cbxUserList.Name = "cbxUserList";
            this.cbxUserList.Parmida_ActivePlusMultiKeys = false;
            this.cbxUserList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxUserList.Properties.PopupFormSize = new System.Drawing.Size(480, 0);
            this.cbxUserList.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbxUserList.Size = new System.Drawing.Size(271, 20);
            this.cbxUserList.TabIndex = 1;
            this.cbxUserList.EditValueChanged += new System.EventHandler(this.cbxUserList_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.Empty.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.Row.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridLookUpEdit1View.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserIDColumn,
            this.UsernameColumn,
            this.JobColumn,
            this.AccessColumn,
            this.IsActiveColumn});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.Caption = "USerID";
            this.UserIDColumn.FieldName = "UserID";
            this.UserIDColumn.Name = "UserIDColumn";
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.Caption = "نام کاربری";
            this.UsernameColumn.FieldName = "Username";
            this.UsernameColumn.MinWidth = 120;
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.Visible = true;
            this.UsernameColumn.VisibleIndex = 0;
            this.UsernameColumn.Width = 120;
            // 
            // JobColumn
            // 
            this.JobColumn.Caption = "عنوان شغلی";
            this.JobColumn.FieldName = "Job";
            this.JobColumn.MaxWidth = 120;
            this.JobColumn.MinWidth = 120;
            this.JobColumn.Name = "JobColumn";
            this.JobColumn.Visible = true;
            this.JobColumn.VisibleIndex = 1;
            this.JobColumn.Width = 120;
            // 
            // AccessColumn
            // 
            this.AccessColumn.Caption = "سطح دسترسی";
            this.AccessColumn.FieldName = "AccessTable.AccessTitle";
            this.AccessColumn.MaxWidth = 120;
            this.AccessColumn.MinWidth = 120;
            this.AccessColumn.Name = "AccessColumn";
            this.AccessColumn.Visible = true;
            this.AccessColumn.VisibleIndex = 2;
            this.AccessColumn.Width = 120;
            // 
            // IsActiveColumn
            // 
            this.IsActiveColumn.Caption = "وضعیت";
            this.IsActiveColumn.FieldName = "IsActive";
            this.IsActiveColumn.MaxWidth = 80;
            this.IsActiveColumn.MinWidth = 80;
            this.IsActiveColumn.Name = "IsActiveColumn";
            this.IsActiveColumn.Visible = true;
            this.IsActiveColumn.VisibleIndex = 3;
            this.IsActiveColumn.Width = 80;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(458, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "کاربر";
            // 
            // treeListAccess
            // 
            this.treeListAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListAccess.Location = new System.Drawing.Point(0, 66);
            this.treeListAccess.Name = "treeListAccess";
            this.treeListAccess.Size = new System.Drawing.Size(501, 422);
            this.treeListAccess.TabIndex = 1;
            // 
            // AccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 488);
            this.Controls.Add(this.treeListAccess);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(503, 515);
            this.Name = "AccessForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مجوز کاربران";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListAccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeListAccess;
        private DevExpress.XtraEditors.GridLookUpEdit cbxUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn UserIDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn UsernameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn JobColumn;
        private DevExpress.XtraGrid.Columns.GridColumn AccessColumn;
        private DevExpress.XtraGrid.Columns.GridColumn IsActiveColumn;
    }
}