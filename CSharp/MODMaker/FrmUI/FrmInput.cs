using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODMaker.FrmUI
{
    public partial class FrmInput : Form
    {
        public FrmInput()
        {
            InitializeComponent();
        }

        public void setTitle(string title = "输入")
        {
            this.Text = title;
        }

        private void FrmInput_Load(object sender, EventArgs e)
        {

        }

        public void setLabel(string label = "请输入")
        {
            this.label1.Text = label;
        }

        public void setPlaceholder(string text = "请输入")
        {
            this.textBox1.PlaceholderText = text;
        }

        public bool status = false;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.status = true;
            this.Close();
        }

        public string getInput()
        {
            return this.textBox1.Text;
        }
    }
}
