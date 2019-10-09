namespace 车牌识别
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.textColorChange = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lblText = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picMatWithFlag = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.picColorM = new System.Windows.Forms.PictureBox();
            this.picSrc = new System.Windows.Forms.PictureBox();
            this.picRect = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMatWithFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRect)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.textColorChange,
            this.toolStripButton1,
            this.toolStripButton2,
            this.lblText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1246, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 25);
            this.toolStripLabel1.Text = "点击拍摄";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 25);
            this.toolStripLabel3.Text = "颜色选择:";
            // 
            // textColorChange
            // 
            this.textColorChange.Items.AddRange(new object[] {
            "蓝色",
            "黄色",
            "绿色"});
            this.textColorChange.Name = "textColorChange";
            this.textColorChange.Size = new System.Drawing.Size(121, 28);
            this.textColorChange.Text = "蓝色";
            this.textColorChange.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 25);
            this.toolStripButton1.Text = "关闭摄像头";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 25);
            this.toolStripButton2.Text = "识别结果:";
            // 
            // lblText
            // 
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 28);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picMatWithFlag);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 564);
            this.splitContainer1.SplitterDistance = 722;
            this.splitContainer1.TabIndex = 2;
            // 
            // picMatWithFlag
            // 
            this.picMatWithFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMatWithFlag.Location = new System.Drawing.Point(0, 0);
            this.picMatWithFlag.Name = "picMatWithFlag";
            this.picMatWithFlag.Size = new System.Drawing.Size(722, 564);
            this.picMatWithFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatWithFlag.TabIndex = 0;
            this.picMatWithFlag.TabStop = false;
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.picRect);
            this.splitContainer2.Size = new System.Drawing.Size(520, 564);
            this.splitContainer2.SplitterDistance = 324;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.picColorM);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.picSrc);
            this.splitContainer3.Size = new System.Drawing.Size(520, 324);
            this.splitContainer3.SplitterDistance = 216;
            this.splitContainer3.TabIndex = 0;
            // 
            // picColorM
            // 
            this.picColorM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picColorM.Location = new System.Drawing.Point(0, 0);
            this.picColorM.Name = "picColorM";
            this.picColorM.Size = new System.Drawing.Size(216, 324);
            this.picColorM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picColorM.TabIndex = 1;
            this.picColorM.TabStop = false;
            // 
            // picSrc
            // 
            this.picSrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSrc.Location = new System.Drawing.Point(0, 0);
            this.picSrc.Name = "picSrc";
            this.picSrc.Size = new System.Drawing.Size(300, 324);
            this.picSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSrc.TabIndex = 5;
            this.picSrc.TabStop = false;
            // 
            // picRect
            // 
            this.picRect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRect.Location = new System.Drawing.Point(0, 0);
            this.picRect.Name = "picRect";
            this.picRect.Size = new System.Drawing.Size(520, 236);
            this.picRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRect.TabIndex = 2;
            this.picRect.TabStop = false;
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormVideo";
            this.Text = "FormVideo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMatWithFlag)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColorM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox textColorChange;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picMatWithFlag;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox lblText;
        private System.Windows.Forms.PictureBox picRect;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox picColorM;
        private System.Windows.Forms.PictureBox picSrc;
    }
}