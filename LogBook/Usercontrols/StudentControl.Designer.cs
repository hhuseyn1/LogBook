namespace LogBook.Usercontrols
{
    partial class StudentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ReComment = new System.Windows.Forms.Button();
            this.txtbox_Comment = new System.Windows.Forms.TextBox();
            this.btn_comment = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_dia2 = new System.Windows.Forms.Button();
            this.btn_dia3 = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_dia1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmb_Class = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_Lab = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_Absent = new System.Windows.Forms.RadioButton();
            this.rbtn_Late = new System.Windows.Forms.RadioButton();
            this.rbtn_Present = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_LastIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.pct_Student = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.34021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.37113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5567F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Save);
            this.panel8.Controls.Add(this.btn_ReComment);
            this.panel8.Controls.Add(this.txtbox_Comment);
            this.panel8.Controls.Add(this.btn_comment);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(836, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(189, 56);
            this.panel8.TabIndex = 6;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::LogBook.Properties.Resources.Save;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.Location = new System.Drawing.Point(0, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(24, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_ReComment
            // 
            this.btn_ReComment.BackgroundImage = global::LogBook.Properties.Resources.pen;
            this.btn_ReComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ReComment.Location = new System.Drawing.Point(0, 32);
            this.btn_ReComment.Name = "btn_ReComment";
            this.btn_ReComment.Size = new System.Drawing.Size(24, 23);
            this.btn_ReComment.TabIndex = 2;
            this.btn_ReComment.UseVisualStyleBackColor = true;
            this.btn_ReComment.Visible = false;
            this.btn_ReComment.Click += new System.EventHandler(this.btn_ReComment_Click);
            // 
            // txtbox_Comment
            // 
            this.txtbox_Comment.Location = new System.Drawing.Point(58, 9);
            this.txtbox_Comment.Multiline = true;
            this.txtbox_Comment.Name = "txtbox_Comment";
            this.txtbox_Comment.Size = new System.Drawing.Size(128, 34);
            this.txtbox_Comment.TabIndex = 1;
            this.txtbox_Comment.Visible = false;
            // 
            // btn_comment
            // 
            this.btn_comment.BackgroundImage = global::LogBook.Properties.Resources.comment__2_;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_comment.Location = new System.Drawing.Point(27, 19);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(25, 23);
            this.btn_comment.TabIndex = 0;
            this.btn_comment.UseVisualStyleBackColor = true;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_dia2);
            this.panel7.Controls.Add(this.btn_dia3);
            this.panel7.Controls.Add(this.btn_Delete);
            this.panel7.Controls.Add(this.btn_dia1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(731, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(99, 56);
            this.panel7.TabIndex = 5;
            // 
            // btn_dia2
            // 
            this.btn_dia2.BackgroundImage = global::LogBook.Properties.Resources.iconDiaNonSelect;
            this.btn_dia2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dia2.Location = new System.Drawing.Point(26, 20);
            this.btn_dia2.Name = "btn_dia2";
            this.btn_dia2.Size = new System.Drawing.Size(22, 22);
            this.btn_dia2.TabIndex = 4;
            this.btn_dia2.UseVisualStyleBackColor = true;
            this.btn_dia2.Click += new System.EventHandler(this.btn_dia2_Click);
            // 
            // btn_dia3
            // 
            this.btn_dia3.BackgroundImage = global::LogBook.Properties.Resources.iconDiaNonSelect;
            this.btn_dia3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dia3.Location = new System.Drawing.Point(49, 20);
            this.btn_dia3.Name = "btn_dia3";
            this.btn_dia3.Size = new System.Drawing.Size(22, 22);
            this.btn_dia3.TabIndex = 3;
            this.btn_dia3.UseVisualStyleBackColor = true;
            this.btn_dia3.Click += new System.EventHandler(this.btn_dia3_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::LogBook.Properties.Resources.icons8_delete_25;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.Location = new System.Drawing.Point(72, 20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(25, 22);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_dia1
            // 
            this.btn_dia1.BackgroundImage = global::LogBook.Properties.Resources.iconDiaNonSelect;
            this.btn_dia1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dia1.Location = new System.Drawing.Point(3, 20);
            this.btn_dia1.Name = "btn_dia1";
            this.btn_dia1.Size = new System.Drawing.Size(22, 22);
            this.btn_dia1.TabIndex = 0;
            this.btn_dia1.UseVisualStyleBackColor = true;
            this.btn_dia1.Click += new System.EventHandler(this.btn_dia1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cmb_Class);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(626, 3);
            this.panel6.MinimumSize = new System.Drawing.Size(99, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(99, 56);
            this.panel6.TabIndex = 4;
            // 
            // cmb_Class
            // 
            this.cmb_Class.FormattingEnabled = true;
            this.cmb_Class.Items.AddRange(new object[] {
            " -",
            " 1",
            " 2",
            " 3",
            " 4",
            " 5",
            " 6",
            " 7",
            " 8",
            " 9",
            "10",
            "11",
            "12"});
            this.cmb_Class.Location = new System.Drawing.Point(28, 19);
            this.cmb_Class.Name = "cmb_Class";
            this.cmb_Class.Size = new System.Drawing.Size(37, 23);
            this.cmb_Class.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmb_Lab);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(521, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(99, 56);
            this.panel5.TabIndex = 3;
            // 
            // cmb_Lab
            // 
            this.cmb_Lab.FormattingEnabled = true;
            this.cmb_Lab.Items.AddRange(new object[] {
            " -",
            " 1",
            " 2",
            " 3",
            " 4",
            " 5",
            " 6",
            " 7",
            " 8",
            " 9",
            "10",
            "11",
            "12"});
            this.cmb_Lab.Location = new System.Drawing.Point(32, 20);
            this.cmb_Lab.Name = "cmb_Lab";
            this.cmb_Lab.Size = new System.Drawing.Size(37, 23);
            this.cmb_Lab.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtn_Absent);
            this.panel4.Controls.Add(this.rbtn_Late);
            this.panel4.Controls.Add(this.rbtn_Present);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(394, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 56);
            this.panel4.TabIndex = 2;
            // 
            // rbtn_Absent
            // 
            this.rbtn_Absent.AutoSize = true;
            this.rbtn_Absent.BackColor = System.Drawing.Color.Firebrick;
            this.rbtn_Absent.Location = new System.Drawing.Point(89, 23);
            this.rbtn_Absent.Name = "rbtn_Absent";
            this.rbtn_Absent.Size = new System.Drawing.Size(14, 13);
            this.rbtn_Absent.TabIndex = 2;
            this.rbtn_Absent.UseVisualStyleBackColor = false;
            this.rbtn_Absent.CheckedChanged += new System.EventHandler(this.rbtn_Absent_CheckedChanged);
            // 
            // rbtn_Late
            // 
            this.rbtn_Late.AutoSize = true;
            this.rbtn_Late.BackColor = System.Drawing.Color.Yellow;
            this.rbtn_Late.Location = new System.Drawing.Point(55, 23);
            this.rbtn_Late.Name = "rbtn_Late";
            this.rbtn_Late.Size = new System.Drawing.Size(14, 13);
            this.rbtn_Late.TabIndex = 1;
            this.rbtn_Late.UseVisualStyleBackColor = false;
            // 
            // rbtn_Present
            // 
            this.rbtn_Present.AutoSize = true;
            this.rbtn_Present.BackColor = System.Drawing.Color.ForestGreen;
            this.rbtn_Present.Location = new System.Drawing.Point(22, 23);
            this.rbtn_Present.Name = "rbtn_Present";
            this.rbtn_Present.Size = new System.Drawing.Size(14, 13);
            this.rbtn_Present.TabIndex = 0;
            this.rbtn_Present.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(278, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 56);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_LastIn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 56);
            this.panel3.TabIndex = 1;
            // 
            // lbl_LastIn
            // 
            this.lbl_LastIn.AutoSize = true;
            this.lbl_LastIn.Location = new System.Drawing.Point(35, 22);
            this.lbl_LastIn.Name = "lbl_LastIn";
            this.lbl_LastIn.Size = new System.Drawing.Size(38, 15);
            this.lbl_LastIn.TabIndex = 0;
            this.lbl_LastIn.Text = "LastIn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_FullName);
            this.panel1.Controls.Add(this.lbl_No);
            this.panel1.Controls.Add(this.pct_Student);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 56);
            this.panel1.TabIndex = 0;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(128, 23);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(58, 15);
            this.lbl_FullName.TabIndex = 2;
            this.lbl_FullName.Text = "FullName";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Location = new System.Drawing.Point(3, 23);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(23, 15);
            this.lbl_No.TabIndex = 1;
            this.lbl_No.Text = "No";
            // 
            // pct_Student
            // 
            this.pct_Student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pct_Student.BackgroundImage")));
            this.pct_Student.Location = new System.Drawing.Point(47, 3);
            this.pct_Student.Name = "pct_Student";
            this.pct_Student.Size = new System.Drawing.Size(50, 50);
            this.pct_Student.TabIndex = 0;
            this.pct_Student.TabStop = false;
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1145, 62);
            this.MinimumSize = new System.Drawing.Size(1028, 62);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(1028, 62);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private Panel panel7;
        public ComboBox cmb_Class;
        private Panel panel5;
        public ComboBox cmb_Lab;
        private Panel panel4;
        public RadioButton rbtn_Absent;
        public RadioButton rbtn_Late;
        public RadioButton rbtn_Present;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        public Label lbl_FullName;
        public Label lbl_No;
        public PictureBox pct_Student;
        public Button btn_dia2;
        public Button btn_dia3;
        public Button btn_Delete;
        public Button btn_dia1;
        public Button btn_comment;
        public Panel panel6;
        public Label lbl_LastIn;
        public TextBox txtbox_Comment;
        public Button btn_Save;
        public Button btn_ReComment;
    }
}
