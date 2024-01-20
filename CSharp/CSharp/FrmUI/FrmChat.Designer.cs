namespace CSharp.FrmUI
{
    partial class FrmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            panel1 = new Panel();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            contextMenuStrip3 = new ContextMenuStrip(components);
            刷新频道ToolStripMenuItem = new ToolStripMenuItem();
            world = new TabPage();
            dataGridView1 = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            自动滚动ToolStripMenuItem = new ToolStripMenuItem();
            快速复制ToolStripMenuItem = new ToolStripMenuItem();
            快速艾特ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            撤回消息ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            发送图片ToolStripMenuItem = new ToolStripMenuItem();
            发送表情ToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            button1 = new Button();
            频道订阅ToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            world.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 332);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.MouseEnter += panel1_MouseEnter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tabControl1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 332);
            panel2.TabIndex = 1;
            panel2.MouseDown += FrmChat_MouseDown;
            panel2.MouseLeave += FrmChat_MouseLeave;
            panel2.MouseMove += FrmChat_MouseMove;
            panel2.MouseUp += FrmChat_MouseUp;
            // 
            // tabControl1
            // 
            tabControl1.ContextMenuStrip = contextMenuStrip3;
            tabControl1.Controls.Add(world);
            tabControl1.Location = new Point(8, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(607, 252);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 5;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { 刷新频道ToolStripMenuItem, 频道订阅ToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(181, 70);
            // 
            // 刷新频道ToolStripMenuItem
            // 
            刷新频道ToolStripMenuItem.Name = "刷新频道ToolStripMenuItem";
            刷新频道ToolStripMenuItem.Size = new Size(180, 22);
            刷新频道ToolStripMenuItem.Text = "刷新频道";
            刷新频道ToolStripMenuItem.Click += 刷新频道ToolStripMenuItem_Click;
            // 
            // world
            // 
            world.Controls.Add(dataGridView1);
            world.Location = new Point(4, 26);
            world.Name = "world";
            world.Padding = new Padding(3);
            world.Size = new Size(599, 222);
            world.TabIndex = 0;
            world.Text = "公共";
            world.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            dataGridView1.Location = new Point(0, 1);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(598, 220);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { 自动滚动ToolStripMenuItem, 快速复制ToolStripMenuItem, 快速艾特ToolStripMenuItem, toolStripSeparator1, 撤回消息ToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(125, 98);
            // 
            // 自动滚动ToolStripMenuItem
            // 
            自动滚动ToolStripMenuItem.Checked = true;
            自动滚动ToolStripMenuItem.CheckState = CheckState.Checked;
            自动滚动ToolStripMenuItem.Name = "自动滚动ToolStripMenuItem";
            自动滚动ToolStripMenuItem.Size = new Size(124, 22);
            自动滚动ToolStripMenuItem.Text = "自动滚动";
            // 
            // 快速复制ToolStripMenuItem
            // 
            快速复制ToolStripMenuItem.Name = "快速复制ToolStripMenuItem";
            快速复制ToolStripMenuItem.Size = new Size(124, 22);
            快速复制ToolStripMenuItem.Text = "快速复制";
            // 
            // 快速艾特ToolStripMenuItem
            // 
            快速艾特ToolStripMenuItem.Name = "快速艾特ToolStripMenuItem";
            快速艾特ToolStripMenuItem.Size = new Size(124, 22);
            快速艾特ToolStripMenuItem.Text = "快速艾特";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(121, 6);
            // 
            // 撤回消息ToolStripMenuItem
            // 
            撤回消息ToolStripMenuItem.Name = "撤回消息ToolStripMenuItem";
            撤回消息ToolStripMenuItem.Size = new Size(124, 22);
            撤回消息ToolStripMenuItem.Text = "撤回消息";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ContextMenuStrip = contextMenuStrip3;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 4;
            label1.Text = "世界频道";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("文道粗楷体", 10.4999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(11, 296);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "在这里输入发送的消息";
            textBox1.Size = new Size(524, 26);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button3
            // 
            button3.ContextMenuStrip = contextMenuStrip1;
            button3.Location = new Point(541, 295);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 1;
            button3.Text = "发送";
            button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 发送图片ToolStripMenuItem, 发送表情ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(125, 48);
            // 
            // 发送图片ToolStripMenuItem
            // 
            发送图片ToolStripMenuItem.Name = "发送图片ToolStripMenuItem";
            发送图片ToolStripMenuItem.Size = new Size(124, 22);
            发送图片ToolStripMenuItem.Text = "发送图片";
            // 
            // 发送表情ToolStripMenuItem
            // 
            发送表情ToolStripMenuItem.Name = "发送表情ToolStripMenuItem";
            发送表情ToolStripMenuItem.Size = new Size(124, 22);
            发送表情ToolStripMenuItem.Text = "发送表情";
            // 
            // button2
            // 
            button2.Font = new Font("微软雅黑", 5.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(570, 11);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.Text = "—";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("微软雅黑", 5.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(596, 11);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // 频道订阅ToolStripMenuItem
            // 
            频道订阅ToolStripMenuItem.Name = "频道订阅ToolStripMenuItem";
            频道订阅ToolStripMenuItem.Size = new Size(180, 22);
            频道订阅ToolStripMenuItem.Text = "频道订阅";
            // 
            // FrmChat
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 332);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmChat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "世界聊天";
            Load += FrmChat_Load;
            MouseDown += FrmChat_MouseDown;
            MouseLeave += FrmChat_MouseLeave;
            MouseMove += FrmChat_MouseMove;
            MouseUp += FrmChat_MouseUp;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            world.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 发送图片ToolStripMenuItem;
        private ToolStripMenuItem 发送表情ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem 自动滚动ToolStripMenuItem;
        private ToolStripMenuItem 快速复制ToolStripMenuItem;
        private ToolStripMenuItem 快速艾特ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 撤回消息ToolStripMenuItem;
        private Label label1;
        private TabControl tabControl1;
        private TabPage world;
        private ContextMenuStrip contextMenuStrip3;
        private DataGridView dataGridView1;
        private ToolStripMenuItem 刷新频道ToolStripMenuItem;
        private ToolStripMenuItem 频道订阅ToolStripMenuItem;
    }
}