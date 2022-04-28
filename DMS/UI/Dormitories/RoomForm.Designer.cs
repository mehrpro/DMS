
namespace DMS.UI.Dormitories
{
    partial class RoomForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtZarfitOtagh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtShomareOtagh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxEmkanat = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cbxDormitory = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DormitoryNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValenceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvRoom = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SelectColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RoomIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomCapacityColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FacilitiesColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZarfitOtagh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShomareOtagh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmkanat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDormitory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtZarfitOtagh);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtShomareOtagh);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.cbxEmkanat);
            this.panelControl1.Controls.Add(this.cbxDormitory);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(499, 102);
            this.panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(20, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "انصراف";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(94, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(426, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "نام خوابگاه";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(426, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "شماره اتاق";
            // 
            // txtZarfitOtagh
            // 
            this.txtZarfitOtagh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZarfitOtagh.Location = new System.Drawing.Point(253, 68);
            this.txtZarfitOtagh.Name = "txtZarfitOtagh";
            this.txtZarfitOtagh.Parmida_ActivePlusMultiKeys = false;
            this.txtZarfitOtagh.Size = new System.Drawing.Size(167, 20);
            this.txtZarfitOtagh.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.Value1 = 0;
            this.dxValidationProvider1.SetValidationRule(this.txtZarfitOtagh, conditionValidationRule1);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(426, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "ظرفیت";
            // 
            // txtShomareOtagh
            // 
            this.txtShomareOtagh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShomareOtagh.Location = new System.Drawing.Point(253, 42);
            this.txtShomareOtagh.Name = "txtShomareOtagh";
            this.txtShomareOtagh.Parmida_ActivePlusMultiKeys = false;
            this.txtShomareOtagh.Size = new System.Drawing.Size(167, 20);
            this.txtShomareOtagh.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtShomareOtagh, conditionValidationRule2);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(193, 18);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "امکانات";
            // 
            // cbxEmkanat
            // 
            this.cbxEmkanat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEmkanat.EditValue = "";
            this.cbxEmkanat.Location = new System.Drawing.Point(20, 16);
            this.cbxEmkanat.Name = "cbxEmkanat";
            this.cbxEmkanat.Parmida_ActivePlusMultiKeys = false;
            this.cbxEmkanat.Properties.AllowMultiSelect = true;
            this.cbxEmkanat.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxEmkanat.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxEmkanat.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxEmkanat.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxEmkanat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmkanat.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(1, "کولر"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "اجاق گاز"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(3, "یخچال")});
            this.cbxEmkanat.Properties.SelectAllItemVisible = false;
            this.cbxEmkanat.Size = new System.Drawing.Size(167, 20);
            this.cbxEmkanat.TabIndex = 7;
            // 
            // cbxDormitory
            // 
            this.cbxDormitory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDormitory.Location = new System.Drawing.Point(253, 16);
            this.cbxDormitory.Name = "cbxDormitory";
            this.cbxDormitory.Parmida_ActivePlusMultiKeys = false;
            this.cbxDormitory.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDormitory.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDormitory.Properties.AppearanceDropDown.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDormitory.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDormitory.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDormitory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cbxDormitory.Properties.NullText = "";
            this.cbxDormitory.Properties.PopupSizeable = false;
            this.cbxDormitory.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxDormitory.Size = new System.Drawing.Size(167, 20);
            this.cbxDormitory.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.Value1 = 0;
            this.dxValidationProvider1.SetValidationRule(this.cbxDormitory, conditionValidationRule3);
            this.cbxDormitory.EditValueChanged += new System.EventHandler(this.cbxDormitory_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDColumn,
            this.DormitoryNameColumn,
            this.RoomColumn,
            this.ValenceColumn});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDColumn
            // 
            this.IDColumn.Caption = "شناسه";
            this.IDColumn.FieldName = "ID";
            this.IDColumn.MaxWidth = 100;
            this.IDColumn.MinWidth = 100;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 100;
            // 
            // DormitoryNameColumn
            // 
            this.DormitoryNameColumn.Caption = "خوابگاه";
            this.DormitoryNameColumn.FieldName = "DormitoryName";
            this.DormitoryNameColumn.MinWidth = 100;
            this.DormitoryNameColumn.Name = "DormitoryNameColumn";
            this.DormitoryNameColumn.Visible = true;
            this.DormitoryNameColumn.VisibleIndex = 0;
            this.DormitoryNameColumn.Width = 150;
            // 
            // RoomColumn
            // 
            this.RoomColumn.Caption = "تعداد اتاق";
            this.RoomColumn.FieldName = "Room";
            this.RoomColumn.MaxWidth = 100;
            this.RoomColumn.MinWidth = 100;
            this.RoomColumn.Name = "RoomColumn";
            this.RoomColumn.Visible = true;
            this.RoomColumn.VisibleIndex = 1;
            this.RoomColumn.Width = 100;
            // 
            // ValenceColumn
            // 
            this.ValenceColumn.Caption = "ظرفیت کل خوابگاه";
            this.ValenceColumn.FieldName = "Valence";
            this.ValenceColumn.MaxWidth = 100;
            this.ValenceColumn.MinWidth = 100;
            this.ValenceColumn.Name = "ValenceColumn";
            this.ValenceColumn.Visible = true;
            this.ValenceColumn.VisibleIndex = 2;
            this.ValenceColumn.Width = 100;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvRoom);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 102);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(499, 347);
            this.panelControl2.TabIndex = 0;
            // 
            // dgvRoom
            // 
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoom.Location = new System.Drawing.Point(2, 2);
            this.dgvRoom.MainView = this.gridView1;
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelect});
            this.dgvRoom.Size = new System.Drawing.Size(495, 343);
            this.dgvRoom.TabIndex = 0;
            this.dgvRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SelectColumn,
            this.RoomIDColumn,
            this.RoomNumberColumn,
            this.RoomCapacityColumn,
            this.FacilitiesColumn});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.dgvRoom;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SelectColumn
            // 
            this.SelectColumn.ColumnEdit = this.btnSelect;
            this.SelectColumn.MaxWidth = 30;
            this.SelectColumn.MinWidth = 30;
            this.SelectColumn.Name = "SelectColumn";
            this.SelectColumn.Visible = true;
            this.SelectColumn.VisibleIndex = 0;
            this.SelectColumn.Width = 30;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoHeight = false;
            this.btnSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left)});
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSelect.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSelect_ButtonClick);
            // 
            // RoomIDColumn
            // 
            this.RoomIDColumn.Caption = "gridColumn1";
            this.RoomIDColumn.FieldName = "RoomID";
            this.RoomIDColumn.MinWidth = 15;
            this.RoomIDColumn.Name = "RoomIDColumn";
            this.RoomIDColumn.Width = 56;
            // 
            // RoomNumberColumn
            // 
            this.RoomNumberColumn.Caption = "شماره اتاق";
            this.RoomNumberColumn.FieldName = "RoomNumber";
            this.RoomNumberColumn.MaxWidth = 75;
            this.RoomNumberColumn.MinWidth = 75;
            this.RoomNumberColumn.Name = "RoomNumberColumn";
            this.RoomNumberColumn.Visible = true;
            this.RoomNumberColumn.VisibleIndex = 1;
            // 
            // RoomCapacityColumn
            // 
            this.RoomCapacityColumn.Caption = "ظرفیت اتاق";
            this.RoomCapacityColumn.FieldName = "RoomCapacity";
            this.RoomCapacityColumn.MaxWidth = 75;
            this.RoomCapacityColumn.MinWidth = 75;
            this.RoomCapacityColumn.Name = "RoomCapacityColumn";
            this.RoomCapacityColumn.Visible = true;
            this.RoomCapacityColumn.VisibleIndex = 2;
            // 
            // FacilitiesColumn
            // 
            this.FacilitiesColumn.Caption = "امکانات";
            this.FacilitiesColumn.FieldName = "Facilities";
            this.FacilitiesColumn.MinWidth = 15;
            this.FacilitiesColumn.Name = "FacilitiesColumn";
            this.FacilitiesColumn.Visible = true;
            this.FacilitiesColumn.VisibleIndex = 3;
            this.FacilitiesColumn.Width = 557;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 449);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "RoomForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اتاق";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZarfitOtagh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShomareOtagh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmkanat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDormitory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtZarfitOtagh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtShomareOtagh;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl dgvRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbxEmkanat;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxDormitory;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DormitoryNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RoomColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ValenceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SelectColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelect;
        private DevExpress.XtraGrid.Columns.GridColumn RoomIDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RoomNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RoomCapacityColumn;
        private DevExpress.XtraGrid.Columns.GridColumn FacilitiesColumn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}