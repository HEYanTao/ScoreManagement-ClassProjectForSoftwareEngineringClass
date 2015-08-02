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
    public partial class UpdateScoreForm : Form
    {
        public UpdateScoreForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectCourse.queryByStudentNo(tBoxNO.Text, listViewSearch);
        }

        private void listViewSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSearch.SelectedItems.Count == 0)
                return;
            tBoxNoUpdate.Text = listViewSearch.SelectedItems[listViewSearch.SelectedItems.Count-1].SubItems[0].Text;
            tBoxClassUpdate.Text = listViewSearch.SelectedItems[listViewSearch.SelectedItems.Count - 1].SubItems[1].Text;
            tBoxScoreupdate.Text = listViewSearch.SelectedItems[listViewSearch.SelectedItems.Count - 1].SubItems[2].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SelectCourse.update(tBoxNoUpdate.Text, tBoxClassUpdate.Text,tBoxScoreupdate.Text);
            tBoxClassUpdate.Clear();
            tBoxNoUpdate.Clear();
            tBoxScoreupdate.Clear();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            SelectCourse.queryByStudentNo(tBoxNoDelete.Text, listView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.CheckedItems.Count; i++)
            {
                SelectCourse sc = new SelectCourse(listView1.CheckedItems[i].SubItems[0].Text, listView1.CheckedItems[i].SubItems[1].Text,0);
                sc.delete();
            }
            btnSearchDelete_Click(sender, e);
        }
    }
}
