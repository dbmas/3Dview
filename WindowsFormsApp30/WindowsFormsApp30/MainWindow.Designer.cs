namespace WindowsFormsApp30
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataHandle = new System.Windows.Forms.ToolStripMenuItem();
            this.勘探线剖面图KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三维显示WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
            this.ZkBase = new System.Windows.Forms.ToolStripMenuItem();
            this.ZkYanXing = new System.Windows.Forms.ToolStripMenuItem();
            this.Ktx = new System.Windows.Forms.ToolStripMenuItem();
            this.DataImport = new System.Windows.Forms.ToolStripMenuItem();
            this.DataView = new System.Windows.Forms.ToolStripMenuItem();
            this.ZbCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.DataCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.CzCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.dataHandle,
            this.勘探线剖面图KToolStripMenuItem,
            this.三维显示WToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.文件FToolStripMenuItem.Text = "文件（F）";
            // 
            // dataHandle
            // 
            this.dataHandle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZkBase,
            this.ZkYanXing,
            this.Ktx,
            this.DataImport,
            this.DataView,
            this.ZbCalculate,
            this.DataCreate,
            this.CzCalculate});
            this.dataHandle.Name = "dataHandle";
            this.dataHandle.Size = new System.Drawing.Size(99, 21);
            this.dataHandle.Text = "数据处理（S）";
            this.dataHandle.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dataHandle_DropDownItemClicked);
            // 
            // 勘探线剖面图KToolStripMenuItem
            // 
            this.勘探线剖面图KToolStripMenuItem.Name = "勘探线剖面图KToolStripMenuItem";
            this.勘探线剖面图KToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.勘探线剖面图KToolStripMenuItem.Text = "勘探线剖面图（K）";
            // 
            // 三维显示WToolStripMenuItem
            // 
            this.三维显示WToolStripMenuItem.Name = "三维显示WToolStripMenuItem";
            this.三维显示WToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.三维显示WToolStripMenuItem.Text = "三维显示（W）";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助HToolStripMenuItem.Text = "帮助（H）";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "新建";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "打开";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "保存";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton4.Text = "缩小";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton5.Text = "放大";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton6.Text = "移动";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton7.Text = "旋转";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton8.Text = "刷新";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton9.Text = "复位";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton10.Text = "连接数据";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton11.Text = "勘探剖图";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton12.Text = "三维地层";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton13.Text = "钻孔柱状";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(52, 21);
            this.toolStripButton14.Text = "切割";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel1.Text = "欢迎使用地层三维可视化模拟系统！";
            // 
            // renderWindowControl1
            // 
            this.renderWindowControl1.AddTestActors = false;
            this.renderWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderWindowControl1.Location = new System.Drawing.Point(0, 50);
            this.renderWindowControl1.Name = "renderWindowControl1";
            this.renderWindowControl1.Size = new System.Drawing.Size(800, 378);
            this.renderWindowControl1.TabIndex = 3;
            this.renderWindowControl1.TestText = null;
            // 
            // ZkBase
            // 
            this.ZkBase.Name = "ZkBase";
            this.ZkBase.Size = new System.Drawing.Size(184, 22);
            this.ZkBase.Text = "钻孔基本信息录入";
            // 
            // ZkYanXing
            // 
            this.ZkYanXing.Name = "ZkYanXing";
            this.ZkYanXing.Size = new System.Drawing.Size(184, 22);
            this.ZkYanXing.Text = "钻孔岩性信息录入";
            // 
            // Ktx
            // 
            this.Ktx.Name = "Ktx";
            this.Ktx.Size = new System.Drawing.Size(184, 22);
            this.Ktx.Text = "勘探线剖面数据录入";
            // 
            // DataImport
            // 
            this.DataImport.Name = "DataImport";
            this.DataImport.Size = new System.Drawing.Size(184, 22);
            this.DataImport.Text = "数据导入";
            // 
            // DataView
            // 
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(184, 22);
            this.DataView.Text = "数据浏览";
            // 
            // ZbCalculate
            // 
            this.ZbCalculate.Name = "ZbCalculate";
            this.ZbCalculate.Size = new System.Drawing.Size(184, 22);
            this.ZbCalculate.Text = "坐标计算";
            // 
            // DataCreate
            // 
            this.DataCreate.Name = "DataCreate";
            this.DataCreate.Size = new System.Drawing.Size(184, 22);
            this.DataCreate.Text = "数据生成";
            // 
            // CzCalculate
            // 
            this.CzCalculate.Name = "CzCalculate";
            this.CzCalculate.Size = new System.Drawing.Size(184, 22);
            this.CzCalculate.Text = "插值计算";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renderWindowControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "地层三维可视化模拟系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataHandle;
        private System.Windows.Forms.ToolStripMenuItem 勘探线剖面图KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三维显示WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Kitware.VTK.RenderWindowControl renderWindowControl1;
        private System.Windows.Forms.ToolStripMenuItem ZkBase;
        private System.Windows.Forms.ToolStripMenuItem ZkYanXing;
        private System.Windows.Forms.ToolStripMenuItem Ktx;
        private System.Windows.Forms.ToolStripMenuItem DataImport;
        private System.Windows.Forms.ToolStripMenuItem DataView;
        private System.Windows.Forms.ToolStripMenuItem ZbCalculate;
        private System.Windows.Forms.ToolStripMenuItem DataCreate;
        private System.Windows.Forms.ToolStripMenuItem CzCalculate;
    }
}

