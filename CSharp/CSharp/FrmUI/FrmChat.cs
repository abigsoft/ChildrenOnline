using CSharp.Helper;
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
    public partial class FrmChat : Form
    {
        private string token = "";
        public FrmChat(string token = "")
        {
            InitializeComponent();
            this.token = token;
            this.default_width = this.Width;
        }

        private int default_width = 0;
        private bool isCollapsed = false;
        private int collapsedWidth = 20;
        private string collapsedType = "";

        private void FrmChat_Load(object sender, EventArgs e)
        {

        }

        private void FrmChat_MouseLeave(object sender, EventArgs e)
        {
            // 检查鼠标是否真的离开了窗体，而不是进入了某个子控件
            if (isCollapsed || this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                return;
            }
            // 窗体在屏幕左边或右边的边界内
            WinformHelper.CalculateScreenWidth(out int minX, out int maxX);

            //向左折叠
            if (this.Location.X <= minX + this.collapsedWidth)
            {
                this.Left = 0;
                this.Width = 10;
                this.panel1.Visible = true;
                this.panel2.Visible = false;
                this.isCollapsed = true;
                this.collapsedType = "left";
            }
            else
            {
                if (this.Location.X >= maxX - this.collapsedWidth - this.Width)
                {
                    this.Location = new Point(maxX - 10, this.Location.Y);
                    this.Width = 10;
                    this.panel1.Visible = true;
                    this.panel2.Visible = false;
                    this.isCollapsed = true;
                    this.collapsedType = "right";
                }
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                return;
            }
            WinformHelper.CalculateScreenWidth(out int minX, out int maxX);
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            switch (this.collapsedType)
            {
                case "left":
                    this.Width = this.default_width;
                    this.Location = new Point(minX, this.Location.Y);
                    break;
                case "right":
                    this.Width = this.default_width;
                    this.Location = new Point(maxX - this.default_width, this.Location.Y);
                    break;
                default:
                    this.Width = this.default_width;
                    break;
            }
            this.isCollapsed = false;
        }

        Point oPointClicked; // 用于窗体移动
        bool is_mouse_move = false;
        private void FrmChat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oPointClicked = new Point(e.X, e.Y);
                this.is_mouse_move = true;
            }
        }

        private void FrmChat_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && is_mouse_move)
            {
                //以当前鼠标位置为基础，找出目标位置
                Point oMoveToPoint = PointToScreen(new Point(e.X, e.Y));
                oMoveToPoint.Offset(oPointClicked.X * -1, (oPointClicked.Y + SystemInformation.CaptionHeight + SystemInformation.BorderSize.Height) * -1 + 24);
                Location = oMoveToPoint;
            }
        }

        private void FrmChat_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                is_mouse_move = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
