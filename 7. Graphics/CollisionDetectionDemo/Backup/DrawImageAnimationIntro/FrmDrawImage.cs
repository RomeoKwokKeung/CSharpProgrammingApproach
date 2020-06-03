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
        SolidBrush blankBrush;

        private void FrmDrawImage_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            blankBrush = new SolidBrush(panel1.BackColor);
        }

        private void FrmDrawImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
            blankBrush.Dispose();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                imageY = 0;
                imageDir = 1;
                g.Clear(panel1.BackColor);
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int imageX = (int) ((panel1.Width-PicBallTransparent.Width)/2);
            
            //g.Clear(panel1.BackColor);
            g.FillRectangle(blankBrush, imageX, imageY, PicBallTransparent.Width, PicBallTransparent.Height);

            imageY += imageDir*panel1.Height / 100;

            g.DrawImage(PicBallTransparent.Image, imageX , imageY, PicBallTransparent.Width, PicBallTransparent.Height);

            //Checking for collision;
            if (( (imageX+PicBallTransparent.Width) > PicMan.Left) && (imageX < (PicMan.Left + PicMan.Width)) && ((imageY + PicBallTransparent.Height)> PicMan.Top) && (imageY < (PicMan.Top+ PicMan.Height)))
            {
                imageY = PicMan.Top - PicBallTransparent.Height;
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