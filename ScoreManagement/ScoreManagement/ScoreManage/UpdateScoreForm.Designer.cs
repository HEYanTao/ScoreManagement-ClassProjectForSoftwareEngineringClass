namespace ScoreManagement
{
    partial class UpdateScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tBoxScoreupdate = new System.Windows.Forms.TextBox();
            this.tBoxClassUpdate = new System.Windows.Forms.TextBox();
            this.tBoxNoUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBoxNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchDelete = new System.Windows.Forms.Button();
            this.tBoxNoDelete = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(47, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelUpdate);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.tBoxScoreupdate);
            this.tabPage1.Controls.Add(this.tBoxClassUpdate);
            this.tabPage1.Controls.Add(this.tBoxNoUpdate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "更新";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(350, 248);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(63, 25);
            this.btnCancelUpdate.TabIndex = 8;
            this.btnCancelUpdate.Text = "取消";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(277, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 25);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tBoxScoreupdate
            // 
            this.tBoxScoreupdate.Location = new System.Drawing.Point(313, 194);
            this.tBoxScoreupdate.Name = "tBoxScoreupdate";
            this.tBoxScoreupdate.Size = new System.Drawing.Size(100, 20);
            this.tBoxScoreupdate.TabIndex = 6;
            // 
            // tBoxClassUpdate
            // 
            this.tBoxClassUpdate.Location = new System.Drawing.Point(313, 137);
            this.tBoxClassUpdate.Name = "tBoxClassUpdate";
            this.tBoxClassUpdate.ReadOnly = true;
            this.tBoxClassUpdate.Size = new System.Drawing.Size(100, 20);
            this.tBoxClassUpdate.TabIndex = 5;
            // 
            // tBoxNoUpdate
            // 
            this.tBoxNoUpdate.Location = new System.Drawing.Point(313, 73);
            this.tBoxNoUpdate.Name = "tBoxNoUpdate";
            this.tBoxNoUpdate.ReadOnly = true;
            this.tBoxNoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tBoxNoUpdate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "成绩：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "班号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tBoxNO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询待更新的记录";
            // 
            // listViewSearch
            // 
            this.listViewSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSearch.FullRowSelect = true;
            this.listViewSearch.GridLines = true;
            this.listViewSearch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSearch.Location = new System.Drawing.Point(24, 85);
            this.listViewSearch.MultiSelect = false;
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(158, 144);
            this.listViewSearch.TabIndex = 3;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            this.listViewSearch.View = System.Windows.Forms.View.Details;
            this.listViewSearch.SelectedIndexChanged += new System.EventHandler(this.listViewSearch_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "开课班号";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "成绩";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(131, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBoxNO
            // 
            this.tBoxNO.Location = new System.Drawing.Point(45, 40);
            this.tBoxNO.Name = "tBoxNO";
            this.tBoxNO.Size = new System.Drawing.Size(79, 20);
            this.tBoxNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelDelete);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.Location = new System.Drawing.Point(277, 229);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(63, 25);
            this.btnCancelDelete.TabIndex = 17;
            this.btnCancelDelete.Text = "取消";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            this.btnCancelDelete.Click += new System.EventHandler(this.btnCancelDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 25);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btnSearchDelete);
            this.groupBox2.Controls.Add(this.tBoxNoDelete);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(24, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 278);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询待删除的记录";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(9, 86);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(188, 158);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "学号";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "开课班号";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "成绩";
            // 
            // btnSearchDelete
            // 
            this.btnSearchDelete.Location = new System.Drawing.Point(131, 40);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(66, 25);
            this.btnSearchDelete.TabIndex = 2;
            this.btnSearchDelete.Text = "查询";
            this.btnSearchDelete.UseVisualStyleBackColor = true;
            this.btnSearchDelete.Click += new System.EventHandler(this.btnSearchDelete_Click);
            // 
            // tBoxNoDelete
            // 
            this.tBoxNoDelete.Location = new System.Drawing.Point(45, 40);
            this.tBoxNoDelete.Name = "tBoxNoDelete";
            this.tBoxNoDelete.Size = new System.Drawing.Size(79, 20);
            this.tBoxNoDelete.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "学号：";
            // 
            // UpdateScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateScoreForm";
            this.Text = "更新成绩";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tBoxScoreupdate;
        private System.Windows.Forms.TextBox tBoxClassUpdate;
        private System.Windows.Forms.TextBox tBoxNoUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tBoxNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSearchDelete;
        private System.Windows.Forms.TextBox tBoxNoDelete;
        private System.Windows.Forms.Label label8;
    }
}