namespace WindowsFormsApp30
{
    partial class DatabaseWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.password = new MyControl.LabelText();
            this.userName = new MyControl.LabelText();
            this.database = new MyControl.LabelText();
            this.url = new MyControl.LabelText();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.test);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 100);
            this.panel1.TabIndex = 4;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(434, 65);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(310, 65);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "确定";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(66, 65);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(148, 23);
            this.test.TabIndex = 0;
            this.test.Text = "测试连接";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(66, 176);
            this.password.MyContent = "密码：      ";
            this.password.MyText = "";
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(383, 25);
            this.password.TabIndex = 3;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(66, 130);
            this.userName.MyContent = "用户名：    ";
            this.userName.MyText = "";
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.Size = new System.Drawing.Size(383, 24);
            this.userName.TabIndex = 2;
            // 
            // database
            // 
            this.database.AutoSize = true;
            this.database.Location = new System.Drawing.Point(66, 86);
            this.database.MyContent = "数据库名：  ";
            this.database.MyText = "";
            this.database.Name = "database";
            this.database.PasswordChar = '\0';
            this.database.Size = new System.Drawing.Size(383, 24);
            this.database.TabIndex = 1;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(66, 38);
            this.url.MyContent = "数据库地址：";
            this.url.MyText = "";
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.Size = new System.Drawing.Size(383, 23);
            this.url.TabIndex = 0;
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.database);
            this.Controls.Add(this.url);
            this.Name = "DatabaseWindow";
            this.Text = "连接数据库";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseWindow_FormClosed);
            this.Load += new System.EventHandler(this.DatabaseWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControl.LabelText url;
        private MyControl.LabelText database;
        private MyControl.LabelText userName;
        private MyControl.LabelText password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button test;
    }
}