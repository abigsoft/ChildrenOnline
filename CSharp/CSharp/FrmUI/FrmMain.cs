using CSharp.Entity;
using CSharp.Helper;
using CSharp.Manager;
using CSharp.Service;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

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
            WebSocketManager.Instance.OnMessageReceived += Instance_OnMessageReceived;

        }

        private void Instance_OnMessageReceived(string message)
        {
            // 当WebSocket接收到消息时执行的代码，可能需要Invoke以更新UI
            if (InvokeRequired)
            {
                Invoke(new Action<string>(Instance_OnMessageReceived), message);
            }
            else
            {
                // 更新UI或者其他逻辑
                JToken json = JsonHelper.ExtractAll(message);
                switch (JTokenHelper.ToStr(json["type"]))
                {
                    case "system":
                        
                        break;
                }
                MessageBox.Show("Received message: " + message);
            }
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            this.InitSocket();
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

        private async void InitSocket()
        {
            await WebSocketManager.Instance.ConnectAsync(ConfigModel.socket_url + "/?token=" + this.token);
        }

        SportService sp = new SportService();
        private string sport_status = "common";

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool is_mouse_move = false;
        Point oPointClicked; // 用于窗体移动
        private Point lastPosition; // 用来存储上一次的位置

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && is_mouse_move)
            {
                //以当前鼠标位置为基础，找出目标位置
                Point oMoveToPoint = PointToScreen(new Point(e.X, e.Y));
                oMoveToPoint.Offset(oPointClicked.X * -1, (oPointClicked.Y + SystemInformation.CaptionHeight + SystemInformation.BorderSize.Height) * -1 + 24);
                Location = oMoveToPoint;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                is_mouse_move = false;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.is_mouse_move = true;
                oPointClicked = new Point(e.X, e.Y);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int[] array = new int[] { };
            //监测鼠标拖拽
            if (is_mouse_move)
            {
                if (this.Location.X < lastPosition.X) // 向左移动
                {
                    pictureBox1.Images = sp.getBmp(new int[] { 8, 10 });
                    pictureBox1.Interval = 1000;
                    pictureBox1.Loop = false;
                    pictureBox1.Play();
                }
                else if (this.Location.X > lastPosition.X) // 向左移动
                {
                    pictureBox1.Images = sp.getBmp(new int[] { 7, 9 });
                    pictureBox1.Interval = 1000;
                    pictureBox1.Loop = false;
                    pictureBox1.Play();
                }
                else
                {
                    pictureBox1.Images = sp.getBmp(new int[] { 5, 6 });
                    pictureBox1.Interval = 1000;
                    pictureBox1.Loop = false;
                    pictureBox1.Play();
                }
                // 更新上一次位置信息
                lastPosition = this.Location;
            }
            //没拖拽的时候判断状态是否绑定
            else if (sport_status == "common")
            {
                pictureBox1.Images = sp.getBmp(new int[] { 1 });
                pictureBox1.Interval = 1000;
                pictureBox1.Loop = false;
                pictureBox1.Play();
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WebSocketManager.Instance.OnMessageReceived -= Instance_OnMessageReceived;
        }
    }
}
