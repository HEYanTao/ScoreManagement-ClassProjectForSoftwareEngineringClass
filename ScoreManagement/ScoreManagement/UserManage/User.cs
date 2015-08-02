using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ScoreManagement.UserManage
{
    public class User
    {
        private string account;
        private ArrayList rightList = null;//用户权限列表
        public User(string account)   //构造函数
        { this.account = account; }
        public bool hasRight(string rightName) //判断用户是否有指定的权限
        {
            return rightList == null ? false : rightList.Contains(rightName);
        }
        public static User validUser(string account, string passwords)
        {
            string sql = "select * from Account where accountId='" + account;
            sql += "' and passwords = '" + passwords + "'";//查询Account表
            OleDbConnection conn = CommonMethods.DBconn();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteScalar() == null)//是否查到该用户
                { return null; }
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { conn.Close(); }
            User user = new User(account);//验证成功，生成新用户对象
            sql = "select rightName from AccountRole ar,RoleRight rr,Rights";
            sql += " where ar.roleId=rr.roleId";
            sql += " and rr.rightId=Rights.rightId and accountId='" + account + "'";
            cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                ArrayList alRight = new ArrayList();
                while (reader.Read())
                {
                    string rightName = reader["rightName"].ToString();
                    alRight.Add(rightName); //每得到一个权限，就将其加入到顺序表中
                }
                user.rightList = alRight; //把权限给用户
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { conn.Close(); }
            return user;
        }
    }

}
