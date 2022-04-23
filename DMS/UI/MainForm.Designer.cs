
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
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudentForm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnEducationalCenter = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudyForm = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.btnRegisterRoom = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.accordionControl1.Location = new System.Drawing.Point(584, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(223, 472);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "مدیریت سیستم";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "کاربران";
            // 
            // accordionControlElement3
            // 
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
            this.btnRegisterRoom});
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "خوابگاه";
            // 
            // mnuDormitoryForm
            // 
            this.mnuDormitoryForm.Name = "mnuDormitoryForm";
            this.mnuDormitoryForm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnuDormitoryForm.Text = "خوابگاه";
            this.mnuDormitoryForm.Click += new System.EventHandler(this.mnuDormitoryForm_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRoom.Text = "اتاق";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnTrafficType
            // 
            this.btnTrafficType.Name = "btnTrafficType";
            this.btnTrafficType.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTrafficType.Text = "نوع تردد";
            this.btnTrafficType.Click += new System.EventHandler(this.btnTrafficType_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.accordionControlElement11});
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "تگ کارت";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "تگ کارت";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "ثبت کارت";
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
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudentForm.Text = "دانشجو";
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // btnEducationalCenter
            // 
            this.btnEducationalCenter.Name = "btnEducationalCenter";
            this.btnEducationalCenter.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnEducationalCenter.Text = "دانشگاه";
            this.btnEducationalCenter.Click += new System.EventHandler(this.btnEducationalCenter_Click);
            // 
            // btnStudyForm
            // 
            this.btnStudyForm.Name = "btnStudyForm";
            this.btnStudyForm.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudyForm.Text = "رشته تحصیلی";
            this.btnStudyForm.Click += new System.EventHandler(this.btnStudyForm_Click);
            // 
            // btnRegisterRoom
            // 
            this.btnRegisterRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterRoom.ImageOptions.Image")));
            this.btnRegisterRoom.Name = "btnRegisterRoom";
            this.btnRegisterRoom.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRegisterRoom.Text = "مدیریت اتاق";
            this.btnRegisterRoom.Click += new System.EventHandler(this.btnRegisterRoom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 472);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudentForm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnEducationalCenter;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudyForm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRegisterRoom;
    }
}