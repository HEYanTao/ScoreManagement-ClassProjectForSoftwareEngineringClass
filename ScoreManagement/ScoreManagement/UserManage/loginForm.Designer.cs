namespace ScoreManagement.UserManage
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbPasswords = new System.Windows.Forms.TextBox();
            this.btblogin = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(104, 65);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(100, 20);
            this.tbAccount.TabIndex = 2;
            // 
            // tbPasswords
            // 
            this.tbPasswords.Location = new System.Drawing.Point(104, 99);
            this.tbPasswords.Name = "tbPasswords";
            this.tbPasswords.PasswordChar = '*';
            this.tbPasswords.Size = new System.Drawing.Size(100, 20);
            this.tbPasswords.TabIndex = 3;
            // 
            // btblogin
            // 
            this.btblogin.Location = new System.Drawing.Point(128, 139);
            this.btblogin.Name = "btblogin";
            this.btblogin.Size = new System.Drawing.Size(75, 23);
            this.btblogin.TabIndex = 4;
            this.btblogin.Text = "登录";
            this.btblogin.UseVisualStyleBackColor = true;
            this.btblogin.Click += new System.EventHandler(this.btblogin_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(210, 106);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 5;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btblogin);
            this.Controls.Add(this.tbPasswords);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginForm";
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbPasswords;
        private System.Windows.Forms.Button btblogin;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}