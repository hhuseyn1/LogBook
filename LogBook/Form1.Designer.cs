namespace LogBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_LessonSave = new System.Windows.Forms.Button();
            this.btn_ChangeLessonName = new System.Windows.Forms.Button();
            this.lbl_LessonTopic = new System.Windows.Forms.Label();
            this.lbl_GroupName = new System.Windows.Forms.Label();
            this.txtbox_LessonName = new System.Windows.Forms.TextBox();
            this.panel_Teacher = new System.Windows.Forms.Panel();
            this.rbtn_Helper = new System.Windows.Forms.RadioButton();
            this.rbtn_Main = new System.Windows.Forms.RadioButton();
            this.studentControl1 = new LogBook.Usercontrols.StudentControl();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.pnl_ = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_DiaLeft = new System.Windows.Forms.Label();
            this.lbl_Cpmment = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.lbl_Lab = new System.Windows.Forms.Label();
            this.lbl_MarkAllPres = new System.Windows.Forms.Label();
            this.rbtn_AllPresent = new System.Windows.Forms.RadioButton();
            this.lbl_LastIn = new System.Windows.Forms.Label();
            this.lbl_FullnameExp = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.panel_Teacher.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            this.pnl_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_LessonSave);
            this.pnl_Header.Controls.Add(this.btn_ChangeLessonName);
            this.pnl_Header.Controls.Add(this.lbl_LessonTopic);
            this.pnl_Header.Controls.Add(this.lbl_GroupName);
            this.pnl_Header.Controls.Add(this.txtbox_LessonName);
            this.pnl_Header.Controls.Add(this.panel_Teacher);
            this.pnl_Header.Location = new System.Drawing.Point(0, -3);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1013, 105);
            this.pnl_Header.TabIndex = 0;
            // 
            // btn_LessonSave
            // 
            this.btn_LessonSave.BackgroundImage = global::LogBook.Properties.Resources.Save;
            this.btn_LessonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LessonSave.Location = new System.Drawing.Point(857, 76);
            this.btn_LessonSave.Name = "btn_LessonSave";
            this.btn_LessonSave.Size = new System.Drawing.Size(20, 20);
            this.btn_LessonSave.TabIndex = 5;
            this.btn_LessonSave.UseVisualStyleBackColor = true;
            this.btn_LessonSave.Visible = false;
            this.btn_LessonSave.Click += new System.EventHandler(this.btn_LessonSave_Click);
            // 
            // btn_ChangeLessonName
            // 
            this.btn_ChangeLessonName.BackgroundImage = global::LogBook.Properties.Resources.pen;
            this.btn_ChangeLessonName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChangeLessonName.Location = new System.Drawing.Point(831, 76);
            this.btn_ChangeLessonName.Name = "btn_ChangeLessonName";
            this.btn_ChangeLessonName.Size = new System.Drawing.Size(20, 20);
            this.btn_ChangeLessonName.TabIndex = 4;
            this.btn_ChangeLessonName.UseVisualStyleBackColor = true;
            this.btn_ChangeLessonName.Click += new System.EventHandler(this.btn_ChangeLessonName_Click);
            // 
            // lbl_LessonTopic
            // 
            this.lbl_LessonTopic.AutoSize = true;
            this.lbl_LessonTopic.Location = new System.Drawing.Point(831, 22);
            this.lbl_LessonTopic.Name = "lbl_LessonTopic";
            this.lbl_LessonTopic.Size = new System.Drawing.Size(73, 15);
            this.lbl_LessonTopic.TabIndex = 3;
            this.lbl_LessonTopic.Text = "Lesson topic";
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GroupName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_GroupName.Location = new System.Drawing.Point(3, 12);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(150, 30);
            this.lbl_GroupName.TabIndex = 2;
            this.lbl_GroupName.Text = "FBMS_4213_az";
            // 
            // txtbox_LessonName
            // 
            this.txtbox_LessonName.BackColor = System.Drawing.Color.White;
            this.txtbox_LessonName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbox_LessonName.ForeColor = System.Drawing.Color.Black;
            this.txtbox_LessonName.Location = new System.Drawing.Point(831, 40);
            this.txtbox_LessonName.Multiline = true;
            this.txtbox_LessonName.Name = "txtbox_LessonName";
            this.txtbox_LessonName.PlaceholderText = "Lesson name";
            this.txtbox_LessonName.ReadOnly = true;
            this.txtbox_LessonName.Size = new System.Drawing.Size(182, 36);
            this.txtbox_LessonName.TabIndex = 1;
            // 
            // panel_Teacher
            // 
            this.panel_Teacher.Controls.Add(this.rbtn_Helper);
            this.panel_Teacher.Controls.Add(this.rbtn_Main);
            this.panel_Teacher.Location = new System.Drawing.Point(3, 54);
            this.panel_Teacher.Name = "panel_Teacher";
            this.panel_Teacher.Size = new System.Drawing.Size(264, 42);
            this.panel_Teacher.TabIndex = 0;
            // 
            // rbtn_Helper
            // 
            this.rbtn_Helper.AutoSize = true;
            this.rbtn_Helper.Location = new System.Drawing.Point(137, 17);
            this.rbtn_Helper.Name = "rbtn_Helper";
            this.rbtn_Helper.Size = new System.Drawing.Size(121, 19);
            this.rbtn_Helper.TabIndex = 1;
            this.rbtn_Helper.Text = "Substitute Teacher";
            this.rbtn_Helper.UseVisualStyleBackColor = true;
            this.rbtn_Helper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtn_Helper_MouseClick);
            // 
            // rbtn_Main
            // 
            this.rbtn_Main.AutoCheck = false;
            this.rbtn_Main.AutoSize = true;
            this.rbtn_Main.Location = new System.Drawing.Point(3, 17);
            this.rbtn_Main.Name = "rbtn_Main";
            this.rbtn_Main.Size = new System.Drawing.Size(108, 19);
            this.rbtn_Main.TabIndex = 0;
            this.rbtn_Main.Text = "Regular Teacher";
            this.rbtn_Main.UseVisualStyleBackColor = true;
            this.rbtn_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtn_Helper_MouseClick);
            // 
            // studentControl1
            // 
            this.studentControl1.Location = new System.Drawing.Point(0, 6);
            this.studentControl1.MaximumSize = new System.Drawing.Size(1145, 62);
            this.studentControl1.MinimumSize = new System.Drawing.Size(1013, 64);
            this.studentControl1.Name = "studentControl1";
            this.studentControl1.Size = new System.Drawing.Size(1013, 64);
            this.studentControl1.TabIndex = 1;
            this.studentControl1.Visible = false;
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.studentControl1);
            this.pnl_Students.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Students.Location = new System.Drawing.Point(0, 165);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1012, 330);
            this.pnl_Students.TabIndex = 1;
            // 
            // pnl_
            // 
            this.pnl_.AutoScroll = true;
            this.pnl_.AutoSize = true;
            this.pnl_.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_.Controls.Add(this.pictureBox1);
            this.pnl_.Controls.Add(this.lbl_DiaLeft);
            this.pnl_.Controls.Add(this.lbl_Cpmment);
            this.pnl_.Controls.Add(this.lbl_Class);
            this.pnl_.Controls.Add(this.lbl_Lab);
            this.pnl_.Controls.Add(this.lbl_MarkAllPres);
            this.pnl_.Controls.Add(this.rbtn_AllPresent);
            this.pnl_.Controls.Add(this.lbl_LastIn);
            this.pnl_.Controls.Add(this.lbl_FullnameExp);
            this.pnl_.Location = new System.Drawing.Point(0, 99);
            this.pnl_.MaximumSize = new System.Drawing.Size(1145, 74);
            this.pnl_.Name = "pnl_";
            this.pnl_.Size = new System.Drawing.Size(1013, 66);
            this.pnl_.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LogBook.Properties.Resources.iconDiaNonSelect;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(766, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_DiaLeft
            // 
            this.lbl_DiaLeft.AutoSize = true;
            this.lbl_DiaLeft.Location = new System.Drawing.Point(747, 26);
            this.lbl_DiaLeft.Name = "lbl_DiaLeft";
            this.lbl_DiaLeft.Size = new System.Drawing.Size(13, 15);
            this.lbl_DiaLeft.TabIndex = 8;
            this.lbl_DiaLeft.Text = "5";
            // 
            // lbl_Cpmment
            // 
            this.lbl_Cpmment.AutoSize = true;
            this.lbl_Cpmment.Location = new System.Drawing.Point(843, 26);
            this.lbl_Cpmment.Name = "lbl_Cpmment";
            this.lbl_Cpmment.Size = new System.Drawing.Size(61, 15);
            this.lbl_Cpmment.TabIndex = 7;
            this.lbl_Cpmment.Text = "Comment";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(646, 26);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(34, 15);
            this.lbl_Class.TabIndex = 6;
            this.lbl_Class.Text = "Class";
            // 
            // lbl_Lab
            // 
            this.lbl_Lab.AutoSize = true;
            this.lbl_Lab.Location = new System.Drawing.Point(548, 26);
            this.lbl_Lab.Name = "lbl_Lab";
            this.lbl_Lab.Size = new System.Drawing.Size(26, 15);
            this.lbl_Lab.TabIndex = 5;
            this.lbl_Lab.Text = "Lab";
            // 
            // lbl_MarkAllPres
            // 
            this.lbl_MarkAllPres.AutoSize = true;
            this.lbl_MarkAllPres.Location = new System.Drawing.Point(408, 26);
            this.lbl_MarkAllPres.Name = "lbl_MarkAllPres";
            this.lbl_MarkAllPres.Size = new System.Drawing.Size(93, 15);
            this.lbl_MarkAllPres.TabIndex = 4;
            this.lbl_MarkAllPres.Text = "Mark All Present";
            // 
            // rbtn_AllPresent
            // 
            this.rbtn_AllPresent.AutoSize = true;
            this.rbtn_AllPresent.BackColor = System.Drawing.Color.ForestGreen;
            this.rbtn_AllPresent.Location = new System.Drawing.Point(440, 47);
            this.rbtn_AllPresent.Name = "rbtn_AllPresent";
            this.rbtn_AllPresent.Size = new System.Drawing.Size(14, 13);
            this.rbtn_AllPresent.TabIndex = 3;
            this.rbtn_AllPresent.TabStop = true;
            this.rbtn_AllPresent.UseVisualStyleBackColor = false;
            // 
            // lbl_LastIn
            // 
            this.lbl_LastIn.AutoSize = true;
            this.lbl_LastIn.Location = new System.Drawing.Point(288, 26);
            this.lbl_LastIn.Name = "lbl_LastIn";
            this.lbl_LastIn.Size = new System.Drawing.Size(81, 15);
            this.lbl_LastIn.TabIndex = 1;
            this.lbl_LastIn.Text = "Last in MyStat";
            // 
            // lbl_FullnameExp
            // 
            this.lbl_FullnameExp.AutoSize = true;
            this.lbl_FullnameExp.Location = new System.Drawing.Point(118, 26);
            this.lbl_FullnameExp.Name = "lbl_FullnameExp";
            this.lbl_FullnameExp.Size = new System.Drawing.Size(110, 15);
            this.lbl_FullnameExp.TabIndex = 0;
            this.lbl_FullnameExp.Text = "Student\'s FullName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 495);
            this.Controls.Add(this.pnl_);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Header);
            this.MaximumSize = new System.Drawing.Size(1145, 550);
            this.MinimumSize = new System.Drawing.Size(1028, 534);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.panel_Teacher.ResumeLayout(false);
            this.panel_Teacher.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_.ResumeLayout(false);
            this.pnl_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Usercontrols.StudentControl studentControl1;
        public Panel pnl_Students;
        public Panel pnl_Header;
        private Panel panel_Teacher;
        public RadioButton rbtn_Helper;
        public RadioButton rbtn_Main;
        public Label lbl_LessonTopic;
        private Label lbl_GroupName;
        private TextBox txtbox_LessonName;
        public Panel pnl_;
        public Label lbl_FullnameExp;
        public Label lbl_MarkAllPres;
        private RadioButton rbtn_AllPresent;
        public Label lbl_LastIn;
        public Label lbl_DiaLeft;
        public Label lbl_Cpmment;
        public Label lbl_Lab;
        public Label lbl_Class;
        public PictureBox pictureBox1;
        public Button btn_LessonSave;
        public Button btn_ChangeLessonName;
    }
}