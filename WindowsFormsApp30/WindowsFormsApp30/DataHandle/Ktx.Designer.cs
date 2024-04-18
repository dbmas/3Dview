namespace WindowsFormsApp30
{
    partial class Ktx
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelText1 = new MyControl.LabelText();
            this.labelText2 = new MyControl.LabelText();
            this.labelText3 = new MyControl.LabelText();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.panel1.Size = new System.Drawing.Size(379, 233);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelText3);
            this.groupBox1.Controls.Add(this.labelText2);
            this.groupBox1.Controls.Add(this.labelText1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "勘探线剖面";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 69);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Location = new System.Drawing.Point(33, 31);
            this.labelText1.Multiline = false;
            this.labelText1.MyContent = "勘探线编号：";
            this.labelText1.MyText = "";
            this.labelText1.Name = "labelText1";
            this.labelText1.PasswordChar = '\0';
            this.labelText1.Size = new System.Drawing.Size(260, 29);
            this.labelText1.SizeL = new System.Drawing.Size(100, 29);
            this.labelText1.SizeT = new System.Drawing.Size(160, 21);
            this.labelText1.TabIndex = 0;
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Location = new System.Drawing.Point(33, 66);
            this.labelText2.Multiline = false;
            this.labelText2.MyContent = "钻孔编号：";
            this.labelText2.MyText = "";
            this.labelText2.Name = "labelText2";
            this.labelText2.PasswordChar = '\0';
            this.labelText2.Size = new System.Drawing.Size(260, 29);
            this.labelText2.SizeL = new System.Drawing.Size(100, 29);
            this.labelText2.SizeT = new System.Drawing.Size(160, 21);
            this.labelText2.TabIndex = 1;
            // 
            // labelText3
            // 
            this.labelText3.AutoSize = true;
            this.labelText3.Location = new System.Drawing.Point(33, 101);
            this.labelText3.Multiline = false;
            this.labelText3.MyContent = "钻孔在该勘探线中的编号：";
            this.labelText3.MyText = "";
            this.labelText3.Name = "labelText3";
            this.labelText3.PasswordChar = '\0';
            this.labelText3.Size = new System.Drawing.Size(260, 35);
            this.labelText3.SizeL = new System.Drawing.Size(100, 35);
            this.labelText3.SizeT = new System.Drawing.Size(160, 21);
            this.labelText3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Ktx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 233);
            this.Controls.Add(this.panel1);
            this.Name = "Ktx";
            this.Text = "勘探线剖面";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyControl.LabelText labelText1;
        private MyControl.LabelText labelText3;
        private MyControl.LabelText labelText2;
        private System.Windows.Forms.Button button2;
    }
}