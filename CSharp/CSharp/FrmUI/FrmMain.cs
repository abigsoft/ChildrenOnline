using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.FrmUI
{
    public partial class FrmMain : Form
    {
        private string token = "";
        public FrmMain(string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
