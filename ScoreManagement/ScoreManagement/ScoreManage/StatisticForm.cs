using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            string sqlA = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='"+tBoxClass .Text +"' and grade>=90";
            string A = (string)CommonMethods.QueryToObject(sqlA);
            textBox1.Text = A;
            string sqlB = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='" + tBoxClass.Text + "' and grade>=80 and grade<90";
            string B = (string)CommonMethods.QueryToObject(sqlB);
            textBox2.Text = B;
            string sqlC = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='" + tBoxClass.Text + "' and grade>=70 and grade<80";
            string C = (string)CommonMethods.QueryToObject(sqlC);
            textBox3.Text = C;
            string sqlD = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='" + tBoxClass.Text + "' and grade>=60 and grade<70";
            string D = (string)CommonMethods.QueryToObject(sqlD);
            textBox4.Text = D;
            string sqlF = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='" + tBoxClass.Text + "' and grade<60";
            string F = (string)CommonMethods.QueryToObject(sqlF);
            textBox5.Text = F;
            string sqlO = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='" + tBoxClass.Text + "' and grade is Null";
            string O = (string)CommonMethods.QueryToObject(sqlO);
            textBox6.Text = O;
            string sqlSum = " select COUNT(studentNo) from SelectCourse where teachCourseNo ='" + tBoxClass.Text + "'";
            string sum = (string)CommonMethods.QueryToObject(sqlSum);
            int Sum = int.Parse(sum);
            textBox7.Text = sum;
            string sqlCourseName = "select course.courseName from TeachCourse  join SelectCourse on TeachCourse  .teachcourseNo =SelectCourse .teachCourseNo join Course on Course .courseNo =TeachCourse .courseNo where SelectCourse.teachCourseNo='" + tBoxClass.Text + "' ";
            string name = (string)CommonMethods.QueryToObject(sqlCourseName);
            labelClassName.Text = name;
            string sqlTeachName = "select Teacher .workerName  from TeachCourse  join SelectCourse on TeachCourse.teachCourseNo =SelectCourse .teachCourseNo join Course on Course .courseNo =TeachCourse .courseNo join Teacher on Teacher .workerNo =TeachCourse .workerNo  where SelectCourse.teachCourseNo='" + tBoxClass.Text + "'   ";
            string teachname = (string)CommonMethods.QueryToObject(sqlTeachName);
            labelTeacher.Text = teachname;
            textBox8.Text = (100*int.Parse(F) / Sum).ToString ()+'%';
            textBox9.Text = (100 * int.Parse(D) / Sum).ToString() + '%';
            textBox10.Text = (100 * int.Parse(C) / Sum).ToString() + '%';
            textBox11.Text = (100 * int.Parse(B) / Sum).ToString() + '%';
            textBox12.Text = (100 * int.Parse(A) / Sum).ToString() + '%';

        }
    }
}
