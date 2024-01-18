using CSharp.Helper;
using CSharp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp.FrmUI
{
    public partial class FrmMain : Form
    {
        private string token = "";
        public FrmMain(string token = "")
        {
            InitializeComponent();
            this.token = token;
            //CheckForIllegalCrossThreadCalls = false;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //加载位置，技术不够只能限制在主显示器
            pictureBox1.Width = pictureBox1.Height = 256;
            this.Size = new Size(pictureBox1.Width, pictureBox1.Height);
            int location_x = IniHelper.Instance.ReadInteger("Setting", "location_x", 0);
            if (location_x <= 0 || location_x >= Screen.GetWorkingArea(this).Width)
            {
                location_x = Screen.GetWorkingArea(this).Width - this.Width - 120;
            }
            int location_y = IniHelper.Instance.ReadInteger("Setting", "location_y", 0);
            if (location_y <= 0 || location_y >= Screen.GetWorkingArea(this).Height)
            {
                location_y = Screen.GetWorkingArea(this).Height - this.Height - 20;
            }
            this.Location = new Point(location_x, location_y);
            this.BackColor = Color.White;//设置窗体的背景颜色为白色。
            this.pictureBox1.BackColor = Color.Gray;//设置PictureBox的背景颜色为灰色
            this.TransparencyKey = Color.Gray; //如果窗体中有灰色的颜色，那么灰色将变成透明色。
        }

        SportService sp = new SportService();
        private Bitmap[] back_map = new Bitmap[] { };
        private int back_time = 100;

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
