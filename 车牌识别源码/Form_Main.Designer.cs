namespace 车牌识别
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenVideoForm = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXML = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSVMForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCarText = new System.Windows.Forms.ToolStripTextBox();
            this.点击识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PATH = new System.Windows.Forms.ToolStripStatusLabel();
            this.Path_TxT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tTimeInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListIMG = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.ColorMethodTAB = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Original = new System.Windows.Forms.TabPage();
            this.picSrc = new System.Windows.Forms.PictureBox();
            this.Gray = new System.Windows.Forms.TabPage();
            this.picCtv = new System.Windows.Forms.PictureBox();
            this.GaussianBlur = new System.Windows.Forms.TabPage();
            this.GSTXT = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.blurSize = new System.Windows.Forms.ToolStripComboBox();
            this.picBlur = new System.Windows.Forms.PictureBox();
            this.Edge = new System.Windows.Forms.TabPage();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.canny1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.canny2 = new System.Windows.Forms.ToolStripTextBox();
            this.picCanny = new System.Windows.Forms.PictureBox();
            this.Threshold = new System.Windows.Forms.TabPage();
            this.picTs = new System.Windows.Forms.PictureBox();
            this.HSV = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.picHSV = new System.Windows.Forms.PictureBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.picH = new System.Windows.Forms.PictureBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.picS = new System.Windows.Forms.PictureBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.picV = new System.Windows.Forms.PictureBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.picVEven = new System.Windows.Forms.PictureBox();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.picHSVEven = new System.Windows.Forms.PictureBox();
            this.tabpage6 = new System.Windows.Forms.TabPage();
            this.picSelectColor = new System.Windows.Forms.PictureBox();
            this.Dilate = new System.Windows.Forms.TabPage();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.txDaliteX = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.txDaliteY = new System.Windows.Forms.ToolStripTextBox();
            this.picColorDalite = new System.Windows.Forms.PictureBox();
            this.Contours = new System.Windows.Forms.TabPage();
            this.listRect = new System.Windows.Forms.ListBox();
            this.picFindC = new System.Windows.Forms.PictureBox();
            this.SegmentList = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panSegmentList = new System.Windows.Forms.Panel();
            this.panChars = new System.Windows.Forms.Panel();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMinWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMinHeight = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaxWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaxHeight = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWHScale = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelMethodTAB = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.picGrade = new System.Windows.Forms.PictureBox();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.picTh_sobel = new System.Windows.Forms.PictureBox();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.picmorphology_sobel = new System.Windows.Forms.PictureBox();
            this.tabPage23 = new System.Windows.Forms.TabPage();
            this.picCorrode = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panSegment_Sobel = new System.Windows.Forms.Panel();
            this.panChars_sobel = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMInWidth_sobel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMInHeight_sobel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaxWidth_sobel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaxHeight_sobel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWHScale_sobel = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnClick_sobel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.ColorMethodTAB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSrc)).BeginInit();
            this.Gray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCtv)).BeginInit();
            this.GaussianBlur.SuspendLayout();
            this.GSTXT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlur)).BeginInit();
            this.Edge.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanny)).BeginInit();
            this.Threshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTs)).BeginInit();
            this.HSV.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHSV)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picV)).BeginInit();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVEven)).BeginInit();
            this.tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHSVEven)).BeginInit();
            this.tabpage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectColor)).BeginInit();
            this.Dilate.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorDalite)).BeginInit();
            this.Contours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFindC)).BeginInit();
            this.SegmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.SobelMethodTAB.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrade)).BeginInit();
            this.tabPage21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTh_sobel)).BeginInit();
            this.tabPage22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmorphology_sobel)).BeginInit();
            this.tabPage23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCorrode)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.OpenVideoForm,
            this.OpenXML,
            this.OpenSVMForm,
            this.toolStripMenuItem19,
            this.lblCarText,
            this.点击识别ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(111, 27);
            this.OpenFile.Text = "打开图片识别";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // OpenVideoForm
            // 
            this.OpenVideoForm.Name = "OpenVideoForm";
            this.OpenVideoForm.Size = new System.Drawing.Size(111, 27);
            this.OpenVideoForm.Text = "打开视频识别";
            this.OpenVideoForm.Click += new System.EventHandler(this.OpenVideoForm_Click);
            // 
            // OpenXML
            // 
            this.OpenXML.Name = "OpenXML";
            this.OpenXML.Size = new System.Drawing.Size(96, 27);
            this.OpenXML.Text = "导入训练库";
            this.OpenXML.Click += new System.EventHandler(this.OpenXML_Click);
            // 
            // OpenSVMForm
            // 
            this.OpenSVMForm.Name = "OpenSVMForm";
            this.OpenSVMForm.Size = new System.Drawing.Size(115, 27);
            this.OpenSVMForm.Text = "开始SVM训练";
            this.OpenSVMForm.Click += new System.EventHandler(this.OpenSVMForm_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem19.Text = "识别结果";
            // 
            // lblCarText
            // 
            this.lblCarText.Name = "lblCarText";
            this.lblCarText.Size = new System.Drawing.Size(132, 27);
            // 
            // 点击识别ToolStripMenuItem
            // 
            this.点击识别ToolStripMenuItem.Name = "点击识别ToolStripMenuItem";
            this.点击识别ToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.点击识别ToolStripMenuItem.Text = "点击识别";
            this.点击识别ToolStripMenuItem.Click += new System.EventHandler(this.点击识别ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(227, 24);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PATH,
            this.Path_TxT,
            this.tTimeInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 836);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1924, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PATH
            // 
            this.PATH.Name = "PATH";
            this.PATH.Size = new System.Drawing.Size(88, 20);
            this.PATH.Text = "当前目录 ：";
            // 
            // Path_TxT
            // 
            this.Path_TxT.Name = "Path_TxT";
            this.Path_TxT.Size = new System.Drawing.Size(0, 20);
            // 
            // tTimeInfo
            // 
            this.tTimeInfo.Name = "tTimeInfo";
            this.tTimeInfo.Size = new System.Drawing.Size(39, 20);
            this.tTimeInfo.Text = "时间";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListIMG);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 805);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // ListIMG
            // 
            this.ListIMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListIMG.Location = new System.Drawing.Point(0, 0);
            this.ListIMG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListIMG.Name = "ListIMG";
            this.ListIMG.Size = new System.Drawing.Size(415, 805);
            this.ListIMG.TabIndex = 0;
            this.ListIMG.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListIMG_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TabControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1504, 805);
            this.panel2.TabIndex = 0;
            // 
            // TabControl2
            // 
            this.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl2.Controls.Add(this.ColorMethodTAB);
            this.TabControl2.Controls.Add(this.SobelMethodTAB);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl2.Multiline = true;
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1504, 805);
            this.TabControl2.TabIndex = 3;
            // 
            // ColorMethodTAB
            // 
            this.ColorMethodTAB.Controls.Add(this.tabControl1);
            this.ColorMethodTAB.Location = new System.Drawing.Point(26, 4);
            this.ColorMethodTAB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorMethodTAB.Name = "ColorMethodTAB";
            this.ColorMethodTAB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorMethodTAB.Size = new System.Drawing.Size(1474, 797);
            this.ColorMethodTAB.TabIndex = 0;
            this.ColorMethodTAB.Text = "颜色法";
            this.ColorMethodTAB.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Original);
            this.tabControl1.Controls.Add(this.Gray);
            this.tabControl1.Controls.Add(this.GaussianBlur);
            this.tabControl1.Controls.Add(this.Edge);
            this.tabControl1.Controls.Add(this.Threshold);
            this.tabControl1.Controls.Add(this.HSV);
            this.tabControl1.Controls.Add(this.tabpage6);
            this.tabControl1.Controls.Add(this.Dilate);
            this.tabControl1.Controls.Add(this.Contours);
            this.tabControl1.Controls.Add(this.SegmentList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1466, 789);
            this.tabControl1.TabIndex = 1;
            // 
            // Original
            // 
            this.Original.Controls.Add(this.picSrc);
            this.Original.Location = new System.Drawing.Point(4, 25);
            this.Original.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Original.Name = "Original";
            this.Original.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Original.Size = new System.Drawing.Size(1458, 760);
            this.Original.TabIndex = 0;
            this.Original.Text = "原图";
            this.Original.UseVisualStyleBackColor = true;
            // 
            // picSrc
            // 
            this.picSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSrc.Location = new System.Drawing.Point(4, 4);
            this.picSrc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSrc.Name = "picSrc";
            this.picSrc.Size = new System.Drawing.Size(1450, 752);
            this.picSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSrc.TabIndex = 1;
            this.picSrc.TabStop = false;
            // 
            // Gray
            // 
            this.Gray.Controls.Add(this.picCtv);
            this.Gray.Location = new System.Drawing.Point(4, 25);
            this.Gray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gray.Name = "Gray";
            this.Gray.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gray.Size = new System.Drawing.Size(1656, 753);
            this.Gray.TabIndex = 1;
            this.Gray.Text = "灰度图";
            this.Gray.UseVisualStyleBackColor = true;
            // 
            // picCtv
            // 
            this.picCtv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCtv.Location = new System.Drawing.Point(4, 4);
            this.picCtv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCtv.Name = "picCtv";
            this.picCtv.Size = new System.Drawing.Size(1648, 745);
            this.picCtv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCtv.TabIndex = 1;
            this.picCtv.TabStop = false;
            // 
            // GaussianBlur
            // 
            this.GaussianBlur.Controls.Add(this.GSTXT);
            this.GaussianBlur.Controls.Add(this.picBlur);
            this.GaussianBlur.Location = new System.Drawing.Point(4, 25);
            this.GaussianBlur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GaussianBlur.Name = "GaussianBlur";
            this.GaussianBlur.Size = new System.Drawing.Size(1656, 753);
            this.GaussianBlur.TabIndex = 2;
            this.GaussianBlur.Text = "高斯模糊图";
            this.GaussianBlur.UseVisualStyleBackColor = true;
            // 
            // GSTXT
            // 
            this.GSTXT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GSTXT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.blurSize});
            this.GSTXT.Location = new System.Drawing.Point(0, 0);
            this.GSTXT.Name = "GSTXT";
            this.GSTXT.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.GSTXT.Size = new System.Drawing.Size(1656, 32);
            this.GSTXT.TabIndex = 3;
            this.GSTXT.Text = "5";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(96, 28);
            this.toolStripMenuItem5.Text = "模糊指数：";
            // 
            // blurSize
            // 
            this.blurSize.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11"});
            this.blurSize.Name = "blurSize";
            this.blurSize.Size = new System.Drawing.Size(99, 28);
            this.blurSize.Text = "5";
            // 
            // picBlur
            // 
            this.picBlur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBlur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBlur.Location = new System.Drawing.Point(0, 0);
            this.picBlur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBlur.Name = "picBlur";
            this.picBlur.Size = new System.Drawing.Size(1656, 753);
            this.picBlur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBlur.TabIndex = 1;
            this.picBlur.TabStop = false;
            // 
            // Edge
            // 
            this.Edge.Controls.Add(this.menuStrip4);
            this.Edge.Controls.Add(this.picCanny);
            this.Edge.Location = new System.Drawing.Point(4, 25);
            this.Edge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edge.Name = "Edge";
            this.Edge.Size = new System.Drawing.Size(1656, 753);
            this.Edge.TabIndex = 3;
            this.Edge.Text = "边缘图";
            this.Edge.UseVisualStyleBackColor = true;
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.canny1,
            this.toolStripMenuItem7,
            this.canny2});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip4.Size = new System.Drawing.Size(1656, 31);
            this.menuStrip4.TabIndex = 4;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem6.Text = "阈值一：";
            // 
            // canny1
            // 
            this.canny1.Name = "canny1";
            this.canny1.Size = new System.Drawing.Size(45, 27);
            this.canny1.Text = "50";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem7.Text = "阈值二：";
            // 
            // canny2
            // 
            this.canny2.Name = "canny2";
            this.canny2.Size = new System.Drawing.Size(45, 27);
            this.canny2.Text = "250";
            // 
            // picCanny
            // 
            this.picCanny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanny.Location = new System.Drawing.Point(0, 0);
            this.picCanny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCanny.Name = "picCanny";
            this.picCanny.Size = new System.Drawing.Size(1656, 753);
            this.picCanny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCanny.TabIndex = 1;
            this.picCanny.TabStop = false;
            // 
            // Threshold
            // 
            this.Threshold.Controls.Add(this.picTs);
            this.Threshold.Location = new System.Drawing.Point(4, 25);
            this.Threshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(1656, 753);
            this.Threshold.TabIndex = 4;
            this.Threshold.Text = "二值化图";
            this.Threshold.UseVisualStyleBackColor = true;
            // 
            // picTs
            // 
            this.picTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTs.Location = new System.Drawing.Point(0, 0);
            this.picTs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTs.Name = "picTs";
            this.picTs.Size = new System.Drawing.Size(1656, 753);
            this.picTs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTs.TabIndex = 1;
            this.picTs.TabStop = false;
            // 
            // HSV
            // 
            this.HSV.Controls.Add(this.tabControl3);
            this.HSV.Location = new System.Drawing.Point(4, 25);
            this.HSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HSV.Name = "HSV";
            this.HSV.Size = new System.Drawing.Size(1656, 753);
            this.HSV.TabIndex = 5;
            this.HSV.Text = "HSV颜色均衡图";
            this.HSV.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Controls.Add(this.tabPage12);
            this.tabControl3.Controls.Add(this.tabPage13);
            this.tabControl3.Controls.Add(this.tabPage14);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1656, 753);
            this.tabControl3.TabIndex = 3;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.picHSV);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage9.Size = new System.Drawing.Size(1648, 724);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "HSV";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // picHSV
            // 
            this.picHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHSV.Location = new System.Drawing.Point(4, 4);
            this.picHSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHSV.Name = "picHSV";
            this.picHSV.Size = new System.Drawing.Size(1640, 716);
            this.picHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHSV.TabIndex = 2;
            this.picHSV.TabStop = false;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.picH);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage10.Size = new System.Drawing.Size(1645, 717);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "H";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // picH
            // 
            this.picH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picH.Location = new System.Drawing.Point(4, 4);
            this.picH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picH.Name = "picH";
            this.picH.Size = new System.Drawing.Size(1637, 709);
            this.picH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picH.TabIndex = 1;
            this.picH.TabStop = false;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.picS);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage11.Size = new System.Drawing.Size(1645, 717);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "S";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // picS
            // 
            this.picS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picS.Location = new System.Drawing.Point(4, 4);
            this.picS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(1637, 709);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picS.TabIndex = 1;
            this.picS.TabStop = false;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.picV);
            this.tabPage12.Location = new System.Drawing.Point(4, 25);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage12.Size = new System.Drawing.Size(1645, 717);
            this.tabPage12.TabIndex = 3;
            this.tabPage12.Text = "V";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // picV
            // 
            this.picV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picV.Location = new System.Drawing.Point(4, 4);
            this.picV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picV.Name = "picV";
            this.picV.Size = new System.Drawing.Size(1637, 709);
            this.picV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picV.TabIndex = 1;
            this.picV.TabStop = false;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.picVEven);
            this.tabPage13.Location = new System.Drawing.Point(4, 25);
            this.tabPage13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage13.Size = new System.Drawing.Size(1645, 717);
            this.tabPage13.TabIndex = 4;
            this.tabPage13.Text = "V均衡";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // picVEven
            // 
            this.picVEven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVEven.Location = new System.Drawing.Point(4, 4);
            this.picVEven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picVEven.Name = "picVEven";
            this.picVEven.Size = new System.Drawing.Size(1637, 709);
            this.picVEven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVEven.TabIndex = 1;
            this.picVEven.TabStop = false;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.picHSVEven);
            this.tabPage14.Location = new System.Drawing.Point(4, 25);
            this.tabPage14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage14.Size = new System.Drawing.Size(1645, 717);
            this.tabPage14.TabIndex = 5;
            this.tabPage14.Text = "HSV均衡";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // picHSVEven
            // 
            this.picHSVEven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHSVEven.Location = new System.Drawing.Point(4, 4);
            this.picHSVEven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHSVEven.Name = "picHSVEven";
            this.picHSVEven.Size = new System.Drawing.Size(1637, 709);
            this.picHSVEven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHSVEven.TabIndex = 2;
            this.picHSVEven.TabStop = false;
            // 
            // tabpage6
            // 
            this.tabpage6.Controls.Add(this.picSelectColor);
            this.tabpage6.Location = new System.Drawing.Point(4, 25);
            this.tabpage6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabpage6.Name = "tabpage6";
            this.tabpage6.Size = new System.Drawing.Size(1656, 753);
            this.tabpage6.TabIndex = 6;
            this.tabpage6.Text = "颜色筛选";
            this.tabpage6.UseVisualStyleBackColor = true;
            // 
            // picSelectColor
            // 
            this.picSelectColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSelectColor.Location = new System.Drawing.Point(0, 0);
            this.picSelectColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSelectColor.Name = "picSelectColor";
            this.picSelectColor.Size = new System.Drawing.Size(1656, 753);
            this.picSelectColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectColor.TabIndex = 3;
            this.picSelectColor.TabStop = false;
            // 
            // Dilate
            // 
            this.Dilate.Controls.Add(this.menuStrip5);
            this.Dilate.Controls.Add(this.picColorDalite);
            this.Dilate.Location = new System.Drawing.Point(4, 25);
            this.Dilate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dilate.Name = "Dilate";
            this.Dilate.Size = new System.Drawing.Size(1656, 753);
            this.Dilate.TabIndex = 7;
            this.Dilate.Text = "膨胀图";
            this.Dilate.UseVisualStyleBackColor = true;
            // 
            // menuStrip5
            // 
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.txDaliteX,
            this.toolStripMenuItem9,
            this.txDaliteY});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip5.Size = new System.Drawing.Size(1656, 31);
            this.menuStrip5.TabIndex = 8;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(61, 27);
            this.toolStripMenuItem8.Text = "X轴：";
            // 
            // txDaliteX
            // 
            this.txDaliteX.Name = "txDaliteX";
            this.txDaliteX.Size = new System.Drawing.Size(45, 27);
            this.txDaliteX.Text = "17";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(60, 27);
            this.toolStripMenuItem9.Text = "Y轴：";
            // 
            // txDaliteY
            // 
            this.txDaliteY.Name = "txDaliteY";
            this.txDaliteY.Size = new System.Drawing.Size(45, 27);
            this.txDaliteY.Text = "3";
            // 
            // picColorDalite
            // 
            this.picColorDalite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picColorDalite.Location = new System.Drawing.Point(0, 0);
            this.picColorDalite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picColorDalite.Name = "picColorDalite";
            this.picColorDalite.Size = new System.Drawing.Size(1656, 753);
            this.picColorDalite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picColorDalite.TabIndex = 7;
            this.picColorDalite.TabStop = false;
            // 
            // Contours
            // 
            this.Contours.Controls.Add(this.listRect);
            this.Contours.Controls.Add(this.picFindC);
            this.Contours.Location = new System.Drawing.Point(4, 25);
            this.Contours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Contours.Name = "Contours";
            this.Contours.Size = new System.Drawing.Size(1656, 753);
            this.Contours.TabIndex = 8;
            this.Contours.Text = "轮廓图";
            this.Contours.UseVisualStyleBackColor = true;
            // 
            // listRect
            // 
            this.listRect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRect.FormattingEnabled = true;
            this.listRect.ItemHeight = 15;
            this.listRect.Location = new System.Drawing.Point(816, 0);
            this.listRect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listRect.Name = "listRect";
            this.listRect.Size = new System.Drawing.Size(840, 753);
            this.listRect.TabIndex = 4;
            this.listRect.SelectedIndexChanged += new System.EventHandler(this.listRect_SelectedIndexChanged);
            // 
            // picFindC
            // 
            this.picFindC.Dock = System.Windows.Forms.DockStyle.Left;
            this.picFindC.Location = new System.Drawing.Point(0, 0);
            this.picFindC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFindC.Name = "picFindC";
            this.picFindC.Size = new System.Drawing.Size(816, 753);
            this.picFindC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFindC.TabIndex = 3;
            this.picFindC.TabStop = false;
            // 
            // SegmentList
            // 
            this.SegmentList.Controls.Add(this.splitContainer2);
            this.SegmentList.Controls.Add(this.menuStrip6);
            this.SegmentList.Location = new System.Drawing.Point(4, 25);
            this.SegmentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SegmentList.Name = "SegmentList";
            this.SegmentList.Size = new System.Drawing.Size(1656, 753);
            this.SegmentList.TabIndex = 9;
            this.SegmentList.Text = "图块";
            this.SegmentList.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 31);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panSegmentList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panChars);
            this.splitContainer2.Size = new System.Drawing.Size(1656, 722);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 2;
            // 
            // panSegmentList
            // 
            this.panSegmentList.AutoScroll = true;
            this.panSegmentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSegmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSegmentList.Location = new System.Drawing.Point(0, 0);
            this.panSegmentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 19);
            this.panSegmentList.Name = "panSegmentList";
            this.panSegmentList.Size = new System.Drawing.Size(1656, 418);
            this.panSegmentList.TabIndex = 7;
            // 
            // panChars
            // 
            this.panChars.AutoScroll = true;
            this.panChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChars.Location = new System.Drawing.Point(0, 0);
            this.panChars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panChars.Name = "panChars";
            this.panChars.Size = new System.Drawing.Size(1656, 299);
            this.panChars.TabIndex = 8;
            // 
            // menuStrip6
            // 
            this.menuStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.txtMinWidth,
            this.toolStripMenuItem15,
            this.txtMinHeight,
            this.toolStripMenuItem16,
            this.txtMaxWidth,
            this.toolStripMenuItem17,
            this.txtMaxHeight,
            this.toolStripMenuItem18,
            this.txtWHScale,
            this.toolStripMenuItem20});
            this.menuStrip6.Location = new System.Drawing.Point(0, 0);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip6.Size = new System.Drawing.Size(1656, 31);
            this.menuStrip6.TabIndex = 1;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem14.Text = "最小宽度";
            // 
            // txtMinWidth
            // 
            this.txtMinWidth.Name = "txtMinWidth";
            this.txtMinWidth.Size = new System.Drawing.Size(45, 27);
            this.txtMinWidth.Text = "20";
            this.txtMinWidth.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem15.Text = "最小高度";
            // 
            // txtMinHeight
            // 
            this.txtMinHeight.Name = "txtMinHeight";
            this.txtMinHeight.Size = new System.Drawing.Size(44, 27);
            this.txtMinHeight.Text = "20";
            this.txtMinHeight.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem16.Text = "最大宽度";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(45, 27);
            this.txtMaxWidth.Text = "370";
            this.txtMaxWidth.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem17.Text = "最大高度";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(45, 27);
            this.txtMaxHeight.Text = "150";
            this.txtMaxHeight.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(96, 27);
            this.toolStripMenuItem18.Text = "图块长宽比";
            // 
            // txtWHScale
            // 
            this.txtWHScale.Name = "txtWHScale";
            this.txtWHScale.Size = new System.Drawing.Size(45, 27);
            this.txtWHScale.Text = "5.5";
            this.txtWHScale.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(51, 27);
            this.toolStripMenuItem20.Text = "筛选";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.tbtnlFilter_Click);
            // 
            // SobelMethodTAB
            // 
            this.SobelMethodTAB.Controls.Add(this.tabControl5);
            this.SobelMethodTAB.Location = new System.Drawing.Point(26, 4);
            this.SobelMethodTAB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SobelMethodTAB.Name = "SobelMethodTAB";
            this.SobelMethodTAB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SobelMethodTAB.Size = new System.Drawing.Size(1677, 792);
            this.SobelMethodTAB.TabIndex = 1;
            this.SobelMethodTAB.Text = "Sobel算子";
            this.SobelMethodTAB.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage20);
            this.tabControl5.Controls.Add(this.tabPage21);
            this.tabControl5.Controls.Add(this.tabPage22);
            this.tabControl5.Controls.Add(this.tabPage23);
            this.tabControl5.Controls.Add(this.tabPage1);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(4, 4);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(1669, 784);
            this.tabControl5.TabIndex = 3;
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.picGrade);
            this.tabPage20.Location = new System.Drawing.Point(4, 25);
            this.tabPage20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage20.Size = new System.Drawing.Size(1661, 755);
            this.tabPage20.TabIndex = 0;
            this.tabPage20.Text = "梯度";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // picGrade
            // 
            this.picGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGrade.Location = new System.Drawing.Point(4, 4);
            this.picGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGrade.Name = "picGrade";
            this.picGrade.Size = new System.Drawing.Size(1653, 747);
            this.picGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrade.TabIndex = 3;
            this.picGrade.TabStop = false;
            // 
            // tabPage21
            // 
            this.tabPage21.Controls.Add(this.picTh_sobel);
            this.tabPage21.Location = new System.Drawing.Point(4, 25);
            this.tabPage21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage21.Size = new System.Drawing.Size(1656, 753);
            this.tabPage21.TabIndex = 1;
            this.tabPage21.Text = "二值化";
            this.tabPage21.UseVisualStyleBackColor = true;
            // 
            // picTh_sobel
            // 
            this.picTh_sobel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTh_sobel.Location = new System.Drawing.Point(4, 4);
            this.picTh_sobel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTh_sobel.Name = "picTh_sobel";
            this.picTh_sobel.Size = new System.Drawing.Size(1648, 745);
            this.picTh_sobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTh_sobel.TabIndex = 3;
            this.picTh_sobel.TabStop = false;
            // 
            // tabPage22
            // 
            this.tabPage22.Controls.Add(this.picmorphology_sobel);
            this.tabPage22.Location = new System.Drawing.Point(4, 25);
            this.tabPage22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage22.Size = new System.Drawing.Size(1656, 753);
            this.tabPage22.TabIndex = 2;
            this.tabPage22.Text = "闭操作";
            this.tabPage22.UseVisualStyleBackColor = true;
            // 
            // picmorphology_sobel
            // 
            this.picmorphology_sobel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picmorphology_sobel.Location = new System.Drawing.Point(4, 4);
            this.picmorphology_sobel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picmorphology_sobel.Name = "picmorphology_sobel";
            this.picmorphology_sobel.Size = new System.Drawing.Size(1648, 745);
            this.picmorphology_sobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmorphology_sobel.TabIndex = 3;
            this.picmorphology_sobel.TabStop = false;
            // 
            // tabPage23
            // 
            this.tabPage23.Controls.Add(this.picCorrode);
            this.tabPage23.Location = new System.Drawing.Point(4, 25);
            this.tabPage23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage23.Name = "tabPage23";
            this.tabPage23.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage23.Size = new System.Drawing.Size(1656, 753);
            this.tabPage23.TabIndex = 3;
            this.tabPage23.Text = "腐蚀";
            this.tabPage23.UseVisualStyleBackColor = true;
            // 
            // picCorrode
            // 
            this.picCorrode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCorrode.Location = new System.Drawing.Point(4, 4);
            this.picCorrode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCorrode.Name = "picCorrode";
            this.picCorrode.Size = new System.Drawing.Size(1648, 745);
            this.picCorrode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCorrode.TabIndex = 3;
            this.picCorrode.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Controls.Add(this.menuStrip3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1656, 753);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "分割";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 35);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panSegment_Sobel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panChars_sobel);
            this.splitContainer3.Size = new System.Drawing.Size(1648, 714);
            this.splitContainer3.SplitterDistance = 561;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 3;
            // 
            // panSegment_Sobel
            // 
            this.panSegment_Sobel.AutoScroll = true;
            this.panSegment_Sobel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSegment_Sobel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSegment_Sobel.Location = new System.Drawing.Point(0, 0);
            this.panSegment_Sobel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 19);
            this.panSegment_Sobel.Name = "panSegment_Sobel";
            this.panSegment_Sobel.Size = new System.Drawing.Size(1648, 561);
            this.panSegment_Sobel.TabIndex = 8;
            // 
            // panChars_sobel
            // 
            this.panChars_sobel.AutoScroll = true;
            this.panChars_sobel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panChars_sobel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChars_sobel.Location = new System.Drawing.Point(0, 0);
            this.panChars_sobel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panChars_sobel.Name = "panChars_sobel";
            this.panChars_sobel.Size = new System.Drawing.Size(1648, 148);
            this.panChars_sobel.TabIndex = 9;
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.txtMInWidth_sobel,
            this.toolStripMenuItem11,
            this.txtMInHeight_sobel,
            this.toolStripMenuItem12,
            this.txtMaxWidth_sobel,
            this.toolStripMenuItem13,
            this.txtMaxHeight_sobel,
            this.toolStripMenuItem21,
            this.txtWHScale_sobel,
            this.tbtnClick_sobel});
            this.menuStrip3.Location = new System.Drawing.Point(4, 4);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(1648, 31);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem10.Text = "最小宽度";
            // 
            // txtMInWidth_sobel
            // 
            this.txtMInWidth_sobel.Name = "txtMInWidth_sobel";
            this.txtMInWidth_sobel.Size = new System.Drawing.Size(45, 27);
            this.txtMInWidth_sobel.Text = "20";
            this.txtMInWidth_sobel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem11.Text = "最小高度";
            // 
            // txtMInHeight_sobel
            // 
            this.txtMInHeight_sobel.Name = "txtMInHeight_sobel";
            this.txtMInHeight_sobel.Size = new System.Drawing.Size(44, 27);
            this.txtMInHeight_sobel.Text = "20";
            this.txtMInHeight_sobel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem12.Text = "最大宽度";
            // 
            // txtMaxWidth_sobel
            // 
            this.txtMaxWidth_sobel.Name = "txtMaxWidth_sobel";
            this.txtMaxWidth_sobel.Size = new System.Drawing.Size(45, 27);
            this.txtMaxWidth_sobel.Text = "370";
            this.txtMaxWidth_sobel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(81, 27);
            this.toolStripMenuItem13.Text = "最大高度";
            // 
            // txtMaxHeight_sobel
            // 
            this.txtMaxHeight_sobel.Name = "txtMaxHeight_sobel";
            this.txtMaxHeight_sobel.Size = new System.Drawing.Size(45, 27);
            this.txtMaxHeight_sobel.Text = "150";
            this.txtMaxHeight_sobel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(96, 27);
            this.toolStripMenuItem21.Text = "图块长宽比";
            // 
            // txtWHScale_sobel
            // 
            this.txtWHScale_sobel.Name = "txtWHScale_sobel";
            this.txtWHScale_sobel.Size = new System.Drawing.Size(45, 27);
            this.txtWHScale_sobel.Text = "5.5";
            this.txtWHScale_sobel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbtnClick_sobel
            // 
            this.tbtnClick_sobel.Name = "tbtnClick_sobel";
            this.tbtnClick_sobel.Size = new System.Drawing.Size(51, 27);
            this.tbtnClick_sobel.Text = "筛选";
            this.tbtnClick_sobel.Click += new System.EventHandler(this.tbtnClick_sobel_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 861);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Main";
            this.Text = "车牌识别";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.ColorMethodTAB.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSrc)).EndInit();
            this.Gray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCtv)).EndInit();
            this.GaussianBlur.ResumeLayout(false);
            this.GaussianBlur.PerformLayout();
            this.GSTXT.ResumeLayout(false);
            this.GSTXT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlur)).EndInit();
            this.Edge.ResumeLayout(false);
            this.Edge.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanny)).EndInit();
            this.Threshold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTs)).EndInit();
            this.HSV.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHSV)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            this.tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picV)).EndInit();
            this.tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVEven)).EndInit();
            this.tabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHSVEven)).EndInit();
            this.tabpage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSelectColor)).EndInit();
            this.Dilate.ResumeLayout(false);
            this.Dilate.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorDalite)).EndInit();
            this.Contours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFindC)).EndInit();
            this.SegmentList.ResumeLayout(false);
            this.SegmentList.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.SobelMethodTAB.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGrade)).EndInit();
            this.tabPage21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTh_sobel)).EndInit();
            this.tabPage22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picmorphology_sobel)).EndInit();
            this.tabPage23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCorrode)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem OpenSVMForm;
        private System.Windows.Forms.ToolStripMenuItem OpenVideoForm;
        private System.Windows.Forms.ToolStripMenuItem OpenXML;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Path_TxT;
        private System.Windows.Forms.ToolStripStatusLabel PATH;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView ListIMG;
        private System.Windows.Forms.TabControl TabControl2;
        private System.Windows.Forms.TabPage ColorMethodTAB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Original;
        private System.Windows.Forms.TabPage Gray;
        private System.Windows.Forms.TabPage GaussianBlur;
        private System.Windows.Forms.TabPage Edge;
        private System.Windows.Forms.TabPage Threshold;
        private System.Windows.Forms.TabPage HSV;
        private System.Windows.Forms.TabPage tabpage6;
        private System.Windows.Forms.TabPage Dilate;
        private System.Windows.Forms.TabPage Contours;
        private System.Windows.Forms.TabPage SegmentList;
        private System.Windows.Forms.TabPage SobelMethodTAB;
        private System.Windows.Forms.PictureBox picSrc;
        private System.Windows.Forms.PictureBox picCtv;
        private System.Windows.Forms.PictureBox picCanny;
        private System.Windows.Forms.PictureBox picTs;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.PictureBox picHSV;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.PictureBox picH;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.PictureBox picV;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.PictureBox picVEven;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.PictureBox picHSVEven;
        private System.Windows.Forms.PictureBox picColorDalite;
        private System.Windows.Forms.PictureBox picBlur;
        private System.Windows.Forms.MenuStrip GSTXT;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripComboBox blurSize;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripTextBox canny1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripTextBox canny2;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripTextBox txDaliteX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripTextBox txDaliteY;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.PictureBox picTh_sobel;
        private System.Windows.Forms.TabPage tabPage22;
        private System.Windows.Forms.PictureBox picmorphology_sobel;
        private System.Windows.Forms.TabPage tabPage23;
        private System.Windows.Forms.PictureBox picCorrode;
        private System.Windows.Forms.PictureBox picFindC;
        private System.Windows.Forms.PictureBox picSelectColor;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripTextBox txtMinWidth;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripTextBox txtMinHeight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripTextBox txtMaxWidth;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripTextBox txtMaxHeight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripTextBox txtWHScale;
        private System.Windows.Forms.Panel panSegmentList;
        private System.Windows.Forms.Panel panChars;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripTextBox lblCarText;
        private System.Windows.Forms.ListBox listRect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.PictureBox picGrade;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panChars_sobel;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripTextBox txtMInWidth_sobel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripTextBox txtMInHeight_sobel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripTextBox txtMaxWidth_sobel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripTextBox txtMaxHeight_sobel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripTextBox txtWHScale_sobel;
        private System.Windows.Forms.ToolStripMenuItem tbtnClick_sobel;
        private System.Windows.Forms.ToolStripStatusLabel tTimeInfo;
        private System.Windows.Forms.ToolStripMenuItem 点击识别ToolStripMenuItem;
        private System.Windows.Forms.Panel panSegment_Sobel;
    }
}

