using CSharp.Assembly;

namespace CSharp.FrmUI
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            contextMenuStrip1 = new ContextMenuStrip(components);
            社区ToolStripMenuItem = new ToolStripMenuItem();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PlayPictureBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            互动ToolStripMenuItem = new ToolStripMenuItem();
            自动ToolStripMenuItem = new ToolStripMenuItem();
            休息ToolStripMenuItem = new ToolStripMenuItem();
            学习ToolStripMenuItem = new ToolStripMenuItem();
            工作ToolStripMenuItem = new ToolStripMenuItem();
            插件ToolStripMenuItem = new ToolStripMenuItem();
            世界ToolStripMenuItem = new ToolStripMenuItem();
            频道ToolStripMenuItem = new ToolStripMenuItem();
            社区ToolStripMenuItem1 = new ToolStripMenuItem();
            系统ToolStripMenuItem = new ToolStripMenuItem();
            设置ToolStripMenuItem1 = new ToolStripMenuItem();
            开发ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            退出ToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 社区ToolStripMenuItem, 设置ToolStripMenuItem, toolStripSeparator1, 退出ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 76);
            // 
            // 社区ToolStripMenuItem
            // 
            社区ToolStripMenuItem.Name = "社区ToolStripMenuItem";
            社区ToolStripMenuItem.Size = new Size(100, 22);
            社区ToolStripMenuItem.Text = "社区";
            // 
            // 设置ToolStripMenuItem
            // 
            设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            设置ToolStripMenuItem.Size = new Size(100, 22);
            设置ToolStripMenuItem.Text = "设置";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(97, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(100, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "仙宠卖艺";
            notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ContextMenuStrip = contextMenuStrip2;
            pictureBox1.Image = Properties.Resources.shime1;
            pictureBox1.Images = (List<Image>)resources.GetObject("pictureBox1.Images");
            pictureBox1.Interval = 1000;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Loop = true;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 255);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { 互动ToolStripMenuItem, 插件ToolStripMenuItem, 世界ToolStripMenuItem, 系统ToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(181, 114);
            // 
            // 互动ToolStripMenuItem
            // 
            互动ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 自动ToolStripMenuItem, 休息ToolStripMenuItem, 学习ToolStripMenuItem, 工作ToolStripMenuItem });
            互动ToolStripMenuItem.Name = "互动ToolStripMenuItem";
            互动ToolStripMenuItem.Size = new Size(180, 22);
            互动ToolStripMenuItem.Text = "互动";
            // 
            // 自动ToolStripMenuItem
            // 
            自动ToolStripMenuItem.Checked = true;
            自动ToolStripMenuItem.CheckState = CheckState.Checked;
            自动ToolStripMenuItem.Name = "自动ToolStripMenuItem";
            自动ToolStripMenuItem.Size = new Size(100, 22);
            自动ToolStripMenuItem.Text = "自动";
            // 
            // 休息ToolStripMenuItem
            // 
            休息ToolStripMenuItem.Name = "休息ToolStripMenuItem";
            休息ToolStripMenuItem.Size = new Size(100, 22);
            休息ToolStripMenuItem.Text = "休息";
            // 
            // 学习ToolStripMenuItem
            // 
            学习ToolStripMenuItem.Name = "学习ToolStripMenuItem";
            学习ToolStripMenuItem.Size = new Size(100, 22);
            学习ToolStripMenuItem.Text = "学习";
            // 
            // 工作ToolStripMenuItem
            // 
            工作ToolStripMenuItem.Name = "工作ToolStripMenuItem";
            工作ToolStripMenuItem.Size = new Size(100, 22);
            工作ToolStripMenuItem.Text = "工作";
            // 
            // 插件ToolStripMenuItem
            // 
            插件ToolStripMenuItem.Name = "插件ToolStripMenuItem";
            插件ToolStripMenuItem.Size = new Size(180, 22);
            插件ToolStripMenuItem.Text = "插件";
            // 
            // 世界ToolStripMenuItem
            // 
            世界ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 频道ToolStripMenuItem, 社区ToolStripMenuItem1 });
            世界ToolStripMenuItem.Name = "世界ToolStripMenuItem";
            世界ToolStripMenuItem.Size = new Size(180, 22);
            世界ToolStripMenuItem.Text = "世界";
            // 
            // 频道ToolStripMenuItem
            // 
            频道ToolStripMenuItem.Name = "频道ToolStripMenuItem";
            频道ToolStripMenuItem.Size = new Size(180, 22);
            频道ToolStripMenuItem.Text = "频道";
            频道ToolStripMenuItem.Click += 频道ToolStripMenuItem_Click;
            // 
            // 社区ToolStripMenuItem1
            // 
            社区ToolStripMenuItem1.Name = "社区ToolStripMenuItem1";
            社区ToolStripMenuItem1.Size = new Size(180, 22);
            社区ToolStripMenuItem1.Text = "社区";
            // 
            // 系统ToolStripMenuItem
            // 
            系统ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 设置ToolStripMenuItem1, 开发ToolStripMenuItem, toolStripSeparator2, 退出ToolStripMenuItem1 });
            系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            系统ToolStripMenuItem.Size = new Size(180, 22);
            系统ToolStripMenuItem.Text = "系统";
            // 
            // 设置ToolStripMenuItem1
            // 
            设置ToolStripMenuItem1.Name = "设置ToolStripMenuItem1";
            设置ToolStripMenuItem1.Size = new Size(100, 22);
            设置ToolStripMenuItem1.Text = "设置";
            // 
            // 开发ToolStripMenuItem
            // 
            开发ToolStripMenuItem.Name = "开发ToolStripMenuItem";
            开发ToolStripMenuItem.Size = new Size(100, 22);
            开发ToolStripMenuItem.Text = "开发";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(97, 6);
            // 
            // 退出ToolStripMenuItem1
            // 
            退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            退出ToolStripMenuItem1.Size = new Size(100, 22);
            退出ToolStripMenuItem1.Text = "退出";
            退出ToolStripMenuItem1.Click += 退出ToolStripMenuItem1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(256, 256);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "仙宠卖艺";
            TopMost = true;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 社区ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Assembly.PlayPictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem 互动ToolStripMenuItem;
        private ToolStripMenuItem 插件ToolStripMenuItem;
        private ToolStripMenuItem 世界ToolStripMenuItem;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem1;
        private ToolStripMenuItem 开发ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 退出ToolStripMenuItem1;
        private ToolStripMenuItem 自动ToolStripMenuItem;
        private ToolStripMenuItem 休息ToolStripMenuItem;
        private ToolStripMenuItem 学习ToolStripMenuItem;
        private ToolStripMenuItem 工作ToolStripMenuItem;
        private ToolStripMenuItem 社区ToolStripMenuItem1;
        private ToolStripMenuItem 频道ToolStripMenuItem;
    }
}