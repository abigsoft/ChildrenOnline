namespace MODMaker
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewComboBoxColumn();
            Column4 = new DataGridViewComboBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewImageColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage5.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(767, 418);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(759, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "桌宠制作";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(662, 25);
            button4.Name = "button4";
            button4.Size = new Size(75, 25);
            button4.TabIndex = 8;
            button4.Text = "新建";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(28, 363);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 7;
            label3.Text = "当前未选择模型";
            // 
            // button3
            // 
            button3.Location = new Point(581, 25);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 6;
            button3.Text = "刷新";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 24);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 5;
            button2.Text = "保存";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(201, 67);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(540, 293);
            tabControl2.SizeMode = TabSizeMode.Fixed;
            tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(532, 263);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "状态设计";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column11, Column4, Column2, Column3 });
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(531, 263);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "名称";
            Column1.Name = "Column1";
            // 
            // Column11
            // 
            Column11.HeaderText = "次数";
            Column11.Items.AddRange(new object[] { "循环", "一次", "两次", "三次" });
            Column11.Name = "Column11";
            Column11.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "位置";
            Column4.Items.AddRange(new object[] { "--无--", "屏幕左上角", "屏幕左下角", "屏幕右上角", "屏幕右下角", "屏幕上边", "屏幕下边", "屏幕左边", "屏幕右边", "窗口上边", "窗口下边", "窗口左边", "窗口右边", "窗口左上角", "窗口左下角", "窗口右上角", "窗口右下角" });
            Column4.Name = "Column4";
            // 
            // Column2
            // 
            Column2.HeaderText = "心情";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "体力";
            Column3.Name = "Column3";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView2);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(532, 263);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "动作设计";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView2.Location = new Point(1, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(531, 262);
            dataGridView2.TabIndex = 1;
            dataGridView2.RowPostPaint += dataGridView2_RowPostPaint;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "状态";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            Column6.HeaderText = "图片";
            Column6.Name = "Column6";
            Column6.Width = 60;
            // 
            // Column7
            // 
            Column7.HeaderText = "偏移X";
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "偏移Y";
            Column8.Name = "Column8";
            Column8.Resizable = DataGridViewTriState.True;
            Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column8.Width = 80;
            // 
            // Column9
            // 
            Column9.HeaderText = "时间";
            Column9.Name = "Column9";
            Column9.Resizable = DataGridViewTriState.True;
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column9.Width = 80;
            // 
            // Column10
            // 
            Column10.HeaderText = "排序";
            Column10.Name = "Column10";
            Column10.Width = 60;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(label6);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(label4);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(532, 263);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "数据说明";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Location = new Point(37, 206);
            label9.Name = "label9";
            label9.Size = new Size(467, 24);
            label9.TabIndex = 5;
            label9.Text = "偏移量：以状态位置为坐标原点，横向为X轴，纵向为Y轴，可填负数";
            // 
            // label8
            // 
            label8.Location = new Point(37, 175);
            label8.Name = "label8";
            label8.Size = new Size(467, 24);
            label8.TabIndex = 4;
            label8.Text = "排序值：排序值越小显示越靠前";
            // 
            // label7
            // 
            label7.Location = new Point(37, 129);
            label7.Name = "label7";
            label7.Size = new Size(467, 46);
            label7.TabIndex = 3;
            label7.Text = "状态数据：如体力、心情，填写范围区间，如10-20即代表大于等于10且小于20，前为空，如填写-10则代表小于10，后为空，如10-则代表大于等于10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 102);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 2;
            label6.Text = "填写说明";
            // 
            // label5
            // 
            label5.Location = new Point(37, 52);
            label5.Name = "label5";
            label5.Size = new Size(467, 67);
            label5.TabIndex = 1;
            label5.Text = "先写状态，状态写好后，选择一行需要编辑的动作，左下角会显示当前选择的状态，然后切换“动作设计”选项卡，进行编辑当前状态的动作，排序值越小，动作越靠前。";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 25);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 0;
            label4.Text = "操作流程";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(28, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 293);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "缩略信息";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 206);
            textBox1.MaxLength = 20;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "这里填写备注信息";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(146, 65);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 184);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "备注";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = Properties.Resources.没有图片;
            pictureBox1.Image = Properties.Resources.没有图片;
            pictureBox1.InitialImage = Properties.Resources.没有图片;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(419, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 2;
            button1.Text = "加载";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 25);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "本地模型：";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(759, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "使用说明";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(284, 163);
            label10.Name = "label10";
            label10.Size = new Size(180, 46);
            label10.TabIndex = 0;
            label10.Text = "暂         无";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 426);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOD制作工具";
            Load += FrmMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView1;
        private TabPage tabPage5;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column11;
        private DataGridViewComboBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}