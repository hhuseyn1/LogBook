using LogBook.Models;
using LogBook.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook.Usercontrols;

public partial class StudentControl : UserControl
{
    public StudentControl()
    {
        InitializeComponent();
    }
    public byte diaCount = 5;
    private void btn_comment_Click(object sender, EventArgs e)
    {
        txtbox_Comment.Visible=true;
        btn_comment.Visible=false;
        txtbox_Comment.Location = new Point(27, 9);
        btn_Save.Location=new Point(162,3);
        btn_Save.Visible=true;
    }

    private void btn_Save_Click(object sender, EventArgs e)
    {
        if (txtbox_Comment.Text.Length > 0)
        {
            btn_ReComment.Visible = true;
            btn_ReComment.Location = new Point(162, 30);
            txtbox_Comment.ReadOnly = true;
            btn_Save.Visible = false;
        }
        else
        {
            btn_Save.Visible = false;
            btn_comment.Visible = true;
            txtbox_Comment.Visible = false;
        }
    }

    private void btn_ReComment_Click(object sender, EventArgs e)
    {
        btn_Save.Visible = true;
        btn_ReComment.Visible = false;
        txtbox_Comment.ReadOnly = false;
    }

    private void btn_dia1_Click(object sender, EventArgs e)
    {
        if (Diamond.diaLeft> 0)
        {
            Diamond.diaLeft--;
            btn_dia1.BackgroundImage = Resources.iconDiaSelect;
        }
    }

    private void btn_dia2_Click(object sender, EventArgs e)
    {
        if (Diamond.diaLeft > 1)
        {
            Diamond.diaLeft-=2;
            btn_dia1.BackgroundImage = Resources.iconDiaSelect;
            btn_dia2.BackgroundImage = Resources.iconDiaSelect;
        }
    }

    private void btn_dia3_Click(object sender, EventArgs e)
    {
        if (Diamond.diaLeft > 2)
        {
            Diamond.diaLeft-=3;
            btn_dia1.BackgroundImage = Resources.iconDiaSelect;
            btn_dia2.BackgroundImage = Resources.iconDiaSelect;
            btn_dia3.BackgroundImage = Resources.iconDiaSelect;
        }

    }

    private void btn_Delete_Click(object sender, EventArgs e)
    {
        if(btn_dia1.BackgroundImage== Resources.iconDiaSelect)
        Diamond.diaLeft +=1;
        if(btn_dia2.BackgroundImage== Resources.iconDiaSelect)
        Diamond.diaLeft +=2;
        if(btn_dia3.BackgroundImage== Resources.iconDiaSelect)
        Diamond.diaLeft +=3;
        btn_dia1.BackgroundImage = Resources.iconDiaNonSelect;
        btn_dia2.BackgroundImage = Resources.iconDiaNonSelect;
        btn_dia3.BackgroundImage = Resources.iconDiaNonSelect;
    }

    private void rbtn_Absent_CheckedChanged(object sender, EventArgs e)
    {
        if (rbtn_Absent.Checked)
        {
            cmb_Class.Enabled=false;
            cmb_Lab.Enabled=false;
            btn_dia1.Enabled=false;
            btn_dia2.Enabled=false;
            btn_dia3.Enabled = false;
            btn_comment.Enabled=false;
            btn_Delete.Enabled=false;
        }
        else
        {
            cmb_Class.Enabled = true;
            cmb_Lab.Enabled = true;
            btn_dia1.Enabled = true;
            btn_dia2.Enabled = true;
            btn_dia3.Enabled = true;
            btn_comment.Enabled = true;
            btn_Delete.Enabled = true;
        }
    }
}
