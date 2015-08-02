using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreManagement;

namespace ScoreManagement.UserManage
{
    public partial class loginForm : Form
    {
        
        public loginForm()
        {
            InitializeComponent();
        }
        public User user = null;
        private void btblogin_Click(object sender, EventArgs e)
        {
            string userAccount = tbAccount.Text;
            string passwords = tbPasswords.Text;
            user = User.validUser(userAccount, passwords);//得到当前user
            if (user != null)
                this.Close();  //退出登录窗体
            else
                lblErrorMessage.Text = "用户名和密码不匹配";
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
