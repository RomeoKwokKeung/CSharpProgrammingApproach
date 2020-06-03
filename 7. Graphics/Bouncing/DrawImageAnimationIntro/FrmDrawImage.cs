using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawImageAnimationIntro
{
    public partial class FrmDrawImage : Form
    {
        public FrmDrawImage()
        {
            InitializeComponent();
        }

        Graphics g;
        int imageY;
        int imageDir;

        private void FrmDrawImage_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void FrmDrawImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            imageY = 0;
            imageDir = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int imageX = 10;
            
            g.Clear(panel1.BackColor);

            imageY += imageDir*panel1.Height / 40;

            g.DrawImage(PicBallTransparent.Image, imageX , imageY, PicBallTransparent.Width, PicBallTransparent.Height);

            if (imageY + PicBallTransparent.Height > panel1.Height)
            {
                imageY = panel1.Height - PicBallTransparent.Height;
                imageDir = -1;
                Console.Beep();
            }
            else if (imageY < 0)
            {
                imageY = 0;
                imageDir = 1;
                Console.Beep();
            }
                       
        }
    }
}