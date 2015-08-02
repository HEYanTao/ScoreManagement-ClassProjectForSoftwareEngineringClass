using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreManagement.UserManage;

namespace ScoreManagement
{
    public partial class Form1 : Form
    {
        private User user = null;
        public Form1()
        {
            InitializeComponent();
        }
      /*  private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("!");
            if (this.Validate() == true) this.Hide();
            loginForm loginf = new loginForm();
            //loginf.MdiParent = this;
            loginf.ShowDialog ();//首先调用登录窗体
            user = loginf.user;
            if (user == null)
                this.Close();//关闭窗体，退出程序
            else
                setMenuStrip();  //设置对该用户可见的菜单
        }
        */
        private void setMenuStrip() //设定主窗体菜单
{  
    for (int i = 0; i < menuStrip1.Items.Count; i++)
              menuStrip1.Items[i].Visible = false; //将menuStrip1中所有选项置为不可见
   for (int i = 0; i < this.学生管理ToolStripMenuItem.DropDownItems.Count; i++)
    {    
         if (user.hasRight(this.学生管理ToolStripMenuItem.DropDownItems[i].Text))
          {   //设置学生管理菜单栏对该用户可见
               this.学生管理ToolStripMenuItem.Visible = true;   
          } 
          else
          {    this.学生管理ToolStripMenuItem.DropDownItems[i].Visible = false;     }
    }
    for (int j = 0; j < this.教师管理ToolStripMenuItem.DropDownItems.Count; j++)
    {    
          if (user.hasRight(this.教师管理ToolStripMenuItem.DropDownItems[j].Text))
          {   //设置教师管理菜单栏对该用户可见
                this.教师管理ToolStripMenuItem.Visible = true;  
           }
          else
          {     this.教师管理ToolStripMenuItem.DropDownItems[j].Visible = false ; }
     }
    for (int i = 0; i < this.课程管理ToolStripMenuItem.DropDownItems.Count; i++)
    {
        if (user.hasRight(this.课程管理ToolStripMenuItem.DropDownItems[i].Text))
        {   //设置课程管理菜单栏对该用户可见
            this.课程管理ToolStripMenuItem.Visible = true;
        }
        else
        { this.课程管理ToolStripMenuItem.DropDownItems[i].Visible = false; }
    }
    for (int j = 0; j < this.成绩管理ToolStripMenuItem.DropDownItems.Count; j++)
    {
        if (user.hasRight(this.成绩管理ToolStripMenuItem.DropDownItems[j].Text))
        {   //设置成绩管理菜单栏对该用户可见
            this.成绩管理ToolStripMenuItem.Visible = true;
        }
        else
        { this.成绩管理ToolStripMenuItem.DropDownItems[j].Visible = false; }
    }
    for (int j = 0; j < this.角色与权限管理ToolStripMenuItem.DropDownItems.Count; j++)
    {
        if (user.hasRight(this.角色与权限管理ToolStripMenuItem.DropDownItems[j].Text))
        {   //设置角色与权限管理菜单栏对该用户可见
            this.角色与权限管理ToolStripMenuItem.Visible = true;
        }
        else
        { this.角色与权限管理ToolStripMenuItem.DropDownItems[j].Visible = false; }
    }
}


        private void 修改成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateScoreForm f1 = new UpdateScoreForm();
            f1.Show();
        }

        private void 输入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputSingleScoreForm f2 = new InputSingleScoreForm();
            f2.Show();
        }

        private void 查询成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentScoreForm f3 = new SearchStudentScoreForm();
            f3.Show();
        }

        private void 统计成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm f4 = new StatisticForm();
            f4.Show ();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.Validate() == true) this.Hide();
            loginForm loginf = new loginForm();
            //loginf.MdiParent = this;
            loginf.ShowDialog();//首先调用登录窗体
            user = loginf.user;
            if (user == null)
                this.Close();//关闭窗体，退出程序
            else
                setMenuStrip();  //设置对该用户可见的菜单
        }

       

    }
}
