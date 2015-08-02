using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ScoreManagement
{
    public class SelectCourse
    {
        public string sno{get;set;}
        public string tcno{get;set;}
        public int grade{get;set;}
        public SelectCourse(string insno, string intcno, int ingrade)
        {
            sno = insno;
            tcno = intcno;
            grade = ingrade;
        }
      public static bool update(string sno,string tcno, string grade) //更新成绩               
        {
            bool success = true;
            try
            {
                MessageBox.Show( "Are you sure that you want to update this record?","Confirm Update",MessageBoxButtons .OKCancel );
                string sql = "update SelectCourse set grade = " + grade + " where studentNo = '" + sno + "' and teachCourseNo = '" + tcno + "'";
                CommonMethods.NonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update failed!");
                success= false;
            }
            return success;
        }
        public bool delete() //删除
        {
            bool success = true;
            try
            {
                MessageBox.Show("Are you sure that you want to delete this record?", "Confirm Delete", MessageBoxButtons.OKCancel);
                string sql = "delete from SelectCourse where studentNo='" + sno + "' and teachCourseNo='" + tcno + "'";
                CommonMethods.NonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed!");
                success = false;
            }
            return success;
        }
        public static void queryByStudentNo(string no, ListView lv)//查询
        {
            string sql1 = "select studentNo  ,TeachCourse .teachCourseNo,SelectCourse .grade    from Course join TeachCourse on Course.courseNo=TeachCourse.courseNo join SelectCourse on SelectCourse.teachCourseNo=TeachCourse.teachCourseNo  where studentNo like'" + no + "%'";
            CommonMethods.QueryToListView(sql1, lv);
        }
    }
}
