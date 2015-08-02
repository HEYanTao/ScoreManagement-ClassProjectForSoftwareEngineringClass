using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ScoreManagement
{
    public partial class InputSingleScoreForm : Form
    {
        public InputSingleScoreForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql11 = " select studentName from Student where studentNo ='" + tBoxNo.Text + "'";
            string result = (string)CommonMethods.QueryToObject(sql11);
            tBoxName.Text = result;
            string sql = "select courseName ,TeachCourse .teachCourseNo   from Course join TeachCourse on Course.courseNo=TeachCourse.courseNo join SelectCourse on SelectCourse.teachCourseNo=TeachCourse.teachCourseNo  where studentNo='" + tBoxNo.Text + "'";
            Hashtable combolist=CommonMethods.QueryToHashtable(sql);
            comboBox1.Items.Clear();
            foreach (DictionaryEntry t in combolist)
            {
                comboBox1.Items.Add(t.Key);
            }
            string sql1 = "select studentNo  ,TeachCourse .teachCourseNo,SelectCourse .grade    from Course join TeachCourse on Course.courseNo=TeachCourse.courseNo join SelectCourse on SelectCourse.teachCourseNo=TeachCourse.teachCourseNo  where studentNo='" + tBoxNo.Text + "' and grade is not NULL";
            CommonMethods.QueryToListView(sql1, listView1);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            string sql2 = "select courseName ,TeachCourse .teachCourseNo   from Course join TeachCourse on Course.courseNo=TeachCourse.courseNo join SelectCourse on SelectCourse.teachCourseNo=TeachCourse.teachCourseNo  where studentNo='" + tBoxNo.Text + "'";
            Hashtable combolist = CommonMethods.QueryToHashtable(sql2);
            string sql = "update SelectCourse set grade = " + tBoxScore.Text + " where studentNo ='" + tBoxNo.Text + "' and teachCourseNo ='" + (string)combolist [comboBox1.SelectedItem .ToString ()] + "'";
            CommonMethods.NonQuery(sql);
            string sql1 = "select studentNo  ,TeachCourse .teachCourseNo,SelectCourse .grade    from Course join TeachCourse on Course.courseNo=TeachCourse.courseNo join SelectCourse on SelectCourse.teachCourseNo=TeachCourse.teachCourseNo  where studentNo='" + tBoxNo.Text + "' and grade is not NULL";
            CommonMethods.QueryToListView(sql1, listView1);
        }
    }
}
