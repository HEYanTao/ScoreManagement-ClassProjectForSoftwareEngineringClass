using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;

namespace ScoreManagement
{
    public static class CommonMethods
    {
        public static OleDbConnection DBconn()  //连接方法,创建连接对象
        {
            try
            {
                StreamReader t = new StreamReader(Application.StartupPath.ToString()+"\\config.txt", Encoding.Default);
                char[] delimeters = { ' ' };
                string[] info = t.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                string Provider = info[0];
                string DataSource = info[1];
                string IntegratedSecurity = info[2];
                string InitialCatalog = info[3];
                OleDbConnection conn = new OleDbConnection("Provider=" + Provider + ";Data Source=" + DataSource + ";Integrated Security=" + IntegratedSecurity + ";Initial Catalog=" + InitialCatalog);
                t.Close();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open SQL failed!");
                return null;
            }
        }

        public static bool NonQuery(string sql) // 数据库写操作
        {
            OleDbConnection conn = DBconn();
            if (conn == null)
            {
                return false;
            }
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            bool flag = false;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update success");
                flag = true;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Update data failed!");
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public static void QueryToListView(string sql, ListView lv)// 从数据库中读取数据存入ListView操作
        {
            lv.Items.Clear();
            OleDbConnection conn = DBconn();
            if (conn == null)
            {
                return;
            }
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader dbReader = cmd.ExecuteReader();
                int fieldCount = dbReader.FieldCount;
                while (dbReader.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems[0].Text = dbReader[0].ToString();
                    for (int i = 1; i < fieldCount; i++)
                        li.SubItems.Add(dbReader[i].ToString());
                    lv.Items.Add(li);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Failed in getting list data!");
            }
            finally
            {
                conn.Close();
            }
        }


        public static Hashtable QueryToHashtable(string sql)//从数据库某表中读取“名称/代码”操作
        {
            Hashtable ht = new Hashtable();
            OleDbConnection conn = DBconn();
            if (conn == null)
            {
                return null;
            }
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    string key = dbReader[0].ToString();
                    string value = dbReader[1].ToString();
                    ht.Add(key, value);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Error in getting info!");
            }
            conn.Close();
            return ht;
        }

         public static Object QueryToObject(string sql)
         {
             Object t = new Object();
             OleDbConnection conn = DBconn();
             if (conn == null)
             {
                 return null;
             }
             OleDbCommand cmd = new OleDbCommand(sql, conn);
             try
             {
                 conn.Open();
                 OleDbDataReader dbReader = cmd.ExecuteReader();
                 dbReader.Read();
                 if (dbReader.HasRows == false)
                 {
                     MessageBox.Show("No such result!");
                     return null;
                 }
                 string tt = dbReader[0].ToString();
                 t = tt;

             }
             catch (OleDbException ex)
             {
                 MessageBox.Show(ex.Message, "Error in getting info!");
             }
             conn.Close();
             return t;
        }
    }
}
