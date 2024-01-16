namespace CSharp
{
    partial class FrmLogin
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            comboBox1 = new ComboBox();
            label7 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            linkLabel2 = new LinkLabel();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(440, 299);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(432, 269);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "登录";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(198, 220);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 17);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Steam登录";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.steam;
            pictureBox1.Location = new Point(167, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(262, 164);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 3;
            button2.Text = "前往注册";
            button2.UseVisualStyleBackColor = true;
            button2.Click += doClose;
            // 
            // button1
            // 
            button1.Location = new Point(99, 164);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 2;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 107);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "密码：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 69);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(432, 269);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "注册";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "从 0 开始", "聪明智慧", "心地善良", "勇敢果断" });
            comboBox1.Location = new Point(117, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 25);
            comboBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 149);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 19;
            label7.Text = "开局性格：";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(350, 115);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(38, 21);
            radioButton2.TabIndex = 17;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(306, 115);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 21);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 116);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 16;
            label6.Text = "性别：";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(117, 113);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "1-7个字";
            textBox5.Size = new Size(122, 23);
            textBox5.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 116);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 14;
            label5.Text = "角色姓名：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(271, 23);
            textBox4.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(250, 203);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 19;
            button3.Text = "返回登录";
            button3.UseVisualStyleBackColor = true;
            button3.Click += doClose;
            // 
            // button4
            // 
            button4.Location = new Point(99, 203);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 18;
            button4.Text = "提交注册";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 84);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 9;
            label3.Text = "登录密码：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 53);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 8;
            label4.Text = "登录账号：";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(linkLabel2);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(432, 269);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "说明";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(322, 246);
            label11.Name = "label11";
            label11.Size = new Size(104, 17);
            label11.TabIndex = 4;
            label11.Text = "永久征集故事脚本";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 79);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 3;
            label10.Text = "没啥好说的。";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 51);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 2;
            label9.Text = "说明：";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(95, 13);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(258, 17);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://github.com/abigsoft/ChildrenOnline";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 13);
            label8.Name = "label8";
            label8.Size = new Size(81, 17);
            label8.TabIndex = 0;
            label8.Text = "github开源：";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 303);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登录注册";
            Load += FrmLogin_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private TabPage tabPage3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private LinkLabel linkLabel2;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}