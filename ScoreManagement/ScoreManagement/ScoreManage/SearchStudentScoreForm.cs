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
    public partial class SearchStudentScoreForm : Form
    {
        public SearchStudentScoreForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select student.studentNo ,Course .courseName , SelectCourse .grade  from Student join SelectCourse on Student .studentNo =SelectCourse .studentNo join TeachCourse on TeachCourse .teachCourseNo =SelectCourse .teachCourseNo join Course on Course .courseNo =TeachCourse .courseNo where student.studentNo ='"+tBoxNoSearch .Text +"'";
            CommonMethods.QueryToListView(sql, listView1);
            string sql1=" select studentName from Student where studentNo='"+tBoxNoSearch .Text +"'";
            string result = (string)CommonMethods.QueryToObject(sql1);
            labelName.Text = result;
        }
    }
}
