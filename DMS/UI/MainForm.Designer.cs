
namespace DMS.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnuDormitoryForm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRoom = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTrafficType = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRegisterRoom = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTradod = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRegisterTag = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudentForm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnEducationalCenter = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudyForm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement7,
            this.accordionControlElement4,
            this.accordionControlElement5});
            this.accordionControl1.Location = new System.Drawing.Point(623, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(203, 559);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "مدیریت سیستم";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "کاربران";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "سامانه پیام کوتاه";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnuDormitoryForm,
            this.btnRoom,
            this.btnTrafficType,
            this.btnRegisterRoom,
            this.btnTradod});
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "خوابگاه";
            // 
            // mnuDormitoryForm
            // 
            this.mnuDormitoryForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuDormitoryForm.ImageOptions.Image")));
            this.mnuDormitoryForm.Name = "mnuDormitoryForm";
            this.mnuDormitoryForm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnuDormitoryForm.Text = "خوابگاه";
            this.mnuDormitoryForm.Click += new System.EventHandler(this.mnuDormitoryForm_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.ImageOptions.Image")));
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRoom.Text = "اتاق";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnTrafficType
            // 
            this.btnTrafficType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrafficType.ImageOptions.Image")));
            this.btnTrafficType.Name = "btnTrafficType";
            this.btnTrafficType.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTrafficType.Text = "نوع تردد";
            this.btnTrafficType.Click += new System.EventHandler(this.btnTrafficType_Click);
            // 
            // btnRegisterRoom
            // 
            this.btnRegisterRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterRoom.ImageOptions.Image")));
            this.btnRegisterRoom.Name = "btnRegisterRoom";
            this.btnRegisterRoom.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRegisterRoom.Text = "مدیریت اتاق";
            this.btnRegisterRoom.Click += new System.EventHandler(this.btnRegisterRoom_Click);
            // 
            // btnTradod
            // 
            this.btnTradod.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement8.ImageOptions.Image")));
            this.btnTradod.Name = "btnTradod";
            this.btnTradod.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTradod.Text = "ثبت تردد";
            this.btnTradod.Click += new System.EventHandler(this.btnTradod_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.btnRegisterTag});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "تگ کارت";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "تگ کارت";
            // 
            // btnRegisterTag
            // 
            this.btnRegisterTag.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterTag.ImageOptions.Image")));
            this.btnRegisterTag.Name = "btnRegisterTag";
            this.btnRegisterTag.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRegisterTag.Text = "ثبت کارت";
            this.btnRegisterTag.Click += new System.EventHandler(this.btnRegisterTag_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnStudentForm,
            this.btnEducationalCenter,
            this.btnStudyForm});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "دانشجو";
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentForm.ImageOptions.Image")));
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudentForm.Text = "دانشجو";
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // btnEducationalCenter
            // 
            this.btnEducationalCenter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEducationalCenter.ImageOptions.Image")));
            this.btnEducationalCenter.Name = "btnEducationalCenter";
            this.btnEducationalCenter.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnEducationalCenter.Text = "دانشگاه";
            this.btnEducationalCenter.Click += new System.EventHandler(this.btnEducationalCenter_Click);
            // 
            // btnStudyForm
            // 
            this.btnStudyForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudyForm.ImageOptions.Image")));
            this.btnStudyForm.Name = "btnStudyForm";
            this.btnStudyForm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudyForm.Text = "رشته تحصیلی";
            this.btnStudyForm.Click += new System.EventHandler(this.btnStudyForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 559);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnuDormitoryForm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRoom;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTrafficType;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRegisterTag;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudentForm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnEducationalCenter;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudyForm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRegisterRoom;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTradod;
    }
}