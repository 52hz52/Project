namespace 车牌识别
{
    partial class Form_SVM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入训练文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始训练 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存训练库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入测试文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvSrc = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvTest = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsShowFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsShowFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.Car_svm = new System.Windows.Forms.ToolStripMenuItem();
            this.SavaCarSVM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入训练文件ToolStripMenuItem,
            this.开始训练,
            this.Car_svm,
            this.SavaCarSVM,
            this.保存训练库ToolStripMenuItem,
            this.导入测试文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入训练文件ToolStripMenuItem
            // 
            this.导入训练文件ToolStripMenuItem.Name = "导入训练文件ToolStripMenuItem";
            this.导入训练文件ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.导入训练文件ToolStripMenuItem.Text = "导入训练文件";
            this.导入训练文件ToolStripMenuItem.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // 开始训练
            // 
            this.开始训练.Name = "开始训练";
            this.开始训练.Size = new System.Drawing.Size(68, 21);
            this.开始训练.Text = "开始训练";
            this.开始训练.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // 保存训练库ToolStripMenuItem
            // 
            this.保存训练库ToolStripMenuItem.Name = "保存训练库ToolStripMenuItem";
            this.保存训练库ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.保存训练库ToolStripMenuItem.Text = "导出训练库";
            this.保存训练库ToolStripMenuItem.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // 导入测试文件ToolStripMenuItem
            // 
            this.导入测试文件ToolStripMenuItem.Name = "导入测试文件ToolStripMenuItem";
            this.导入测试文件ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.导入测试文件ToolStripMenuItem.Text = "导入测试文件";
            this.导入测试文件ToolStripMenuItem.Click += new System.EventHandler(this.btnTestFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvSrc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(257, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "训练";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvSrc
            // 
            this.tvSrc.BackColor = System.Drawing.Color.White;
            this.tvSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSrc.Location = new System.Drawing.Point(2, 2);
            this.tvSrc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvSrc.Name = "tvSrc";
            this.tvSrc.Size = new System.Drawing.Size(253, 373);
            this.tvSrc.TabIndex = 0;
            this.tvSrc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSrc_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tvTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(257, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "测试";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvTest
            // 
            this.tvTest.BackColor = System.Drawing.Color.White;
            this.tvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTest.HideSelection = false;
            this.tvTest.Location = new System.Drawing.Point(2, 2);
            this.tvTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvTest.Name = "tvTest";
            this.tvTest.Size = new System.Drawing.Size(253, 373);
            this.tvTest.TabIndex = 1;
            this.tvTest.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTest_AfterSelect);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsShowFilePath,
            this.tsShowFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(265, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "路径:";
            // 
            // tsShowFilePath
            // 
            this.tsShowFilePath.Name = "tsShowFilePath";
            this.tsShowFilePath.Size = new System.Drawing.Size(0, 17);
            // 
            // tsShowFile
            // 
            this.tsShowFile.Name = "tsShowFile";
            this.tsShowFile.Size = new System.Drawing.Size(20, 17);
            this.tsShowFile.Text = "   ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picImage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtinfo);
            this.splitContainer2.Size = new System.Drawing.Size(531, 425);
            this.splitContainer2.SplitterDistance = 272;
            this.splitContainer2.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(531, 272);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // txtinfo
            // 
            this.txtinfo.BackColor = System.Drawing.Color.White;
            this.txtinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtinfo.Location = new System.Drawing.Point(0, 0);
            this.txtinfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtinfo.Size = new System.Drawing.Size(531, 149);
            this.txtinfo.TabIndex = 1;
            // 
            // Car_svm
            // 
            this.Car_svm.Name = "Car_svm";
            this.Car_svm.Size = new System.Drawing.Size(92, 21);
            this.Car_svm.Text = "开始车牌训练";
            this.Car_svm.Click += new System.EventHandler(this.Car_svm_Click);
            // 
            // SavaCarSVM
            // 
            this.SavaCarSVM.Name = "SavaCarSVM";
            this.SavaCarSVM.Size = new System.Drawing.Size(104, 21);
            this.SavaCarSVM.Text = "导出车牌训练库";
            this.SavaCarSVM.Click += new System.EventHandler(this.SavaCarSVM_Click);
            // 
            // Form_SVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_SVM";
            this.Text = "训练数据";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入训练文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始训练;
        private System.Windows.Forms.ToolStripMenuItem 保存训练库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入测试文件ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsShowFilePath;
        private System.Windows.Forms.ToolStripStatusLabel tsShowFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView tvSrc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView tvTest;
        private System.Windows.Forms.ToolStripMenuItem Car_svm;
        private System.Windows.Forms.ToolStripMenuItem SavaCarSVM;
    }
}