using LogBook.Usercontrols;
using LogBook.Repositories;
using LogBook.Models;
using System.Diagnostics.Tracing;
using Models;

namespace LogBook;


public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        rbtn_Helper.Checked=false;
        rbtn_Main.Checked=false;
        var student = FakeRepos.GetStudents();

        for (int i = student.Count - 1; i >= 0; i--)
        {
            StudentControl uc = new();
            uc.lbl_No.Text = student[i].Number.ToString();
            uc.pct_Student.Load(@$".\..\..\..\Resources\{student[i].PictureUrl}");
            uc.lbl_FullName.Text = student[i].FullName();
            uc.lbl_LastIn.Text = student[i].LastIn.Value.Date.ToShortDateString();
            uc.Dock = DockStyle.Top;
            pnl_Students.Controls.Add(uc);
        }

    }

    private void btn_ChangeLessonName_Click(object sender, EventArgs e)
    {
        if (btn_ChangeLessonName.Enabled == false)
            return;
        txtbox_LessonName.ReadOnly = false;
        if (txtbox_LessonName.Text.Length >= 0)
            btn_LessonSave.Visible = true;
    }

    private void btn_LessonSave_Click(object sender, EventArgs e)
    {
        txtbox_LessonName.ReadOnly=true;
    }

    private void rbtn_Helper_MouseClick(object sender, MouseEventArgs e)
    {
        if(rbtn_Main.Checked || rbtn_Helper.Checked)
        {
            return;
        }
        else
        {
            btn_ChangeLessonName.Enabled = false;
            studentControl1.cmb_Class.Enabled = false;
            studentControl1.cmb_Lab.Enabled = false;
            studentControl1.rbtn_Absent.Enabled = false;
            studentControl1.rbtn_Late.Enabled = false;
            studentControl1.rbtn_Present.Enabled = false;
            studentControl1.btn_dia1.Enabled = false;
            studentControl1.btn_dia2.Enabled = false;
            studentControl1.btn_dia3.Enabled = false;
            studentControl1.btn_Delete.Enabled = false;
            studentControl1.btn_comment.Enabled = false;
        }

    }
}