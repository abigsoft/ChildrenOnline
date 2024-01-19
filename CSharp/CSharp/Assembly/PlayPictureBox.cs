using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace CSharp.Assembly
{
    public partial class PlayPictureBox : PictureBox
    {
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0;
        private System.Windows.Forms.Timer animationTimer;
        public int Interval { get; set; } = 1000; // 默认间隔为 1 秒
        public bool Loop { get; set; } = true; // 默认循环播放
        public PlayPictureBox()
        {
            //InitializeComponent();
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Tick += AnimationTimer_Tick;
        }

        public List<Image> Images
        {
            get => images;
            set
            {
                images = value;
                if (images != null && images.Count > 0)
                {
                    this.Image = images[0]; // 默认显示第一张图片
                }
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (images != null && images.Count > 0)
            {
                currentImageIndex++;
                if (currentImageIndex >= images.Count)
                {
                    if (Loop)
                    {
                        currentImageIndex = 0;
                    }
                    else
                    {
                        animationTimer.Stop();
                        return;
                    }
                }
                this.Image = images[currentImageIndex];
            }
        }

        public void Play()
        {
            if (images == null || images.Count == 0)
                return;

            animationTimer.Interval = Interval;
            currentImageIndex = -1; // Reset to -1 because it will be incremented in AnimationTimer_Tick
            animationTimer.Start();
        }

        public void Stop()
        {
            animationTimer.Stop();
        }

    }
}
