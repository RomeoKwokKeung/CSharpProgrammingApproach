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
        int manX, manY;
        SolidBrush blankBrush;

        private void FrmDrawImage_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            blankBrush = new SolidBrush(panel1.BackColor);
            this.Focus();
            
            
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
                manX = (int)((panel1.Width - PicMan.Width) / 2);
                manY = panel1.Height - PicMan.Height;
                imageY = 0;
                imageDir = 1;
                g.Clear(panel1.BackColor);
                g.DrawImage(PicMan.Image, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);
                this.Focus();
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
            g.FillRectangle(blankBrush, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);

            imageY += imageDir*panel1.Height / 100;

            g.DrawImage(PicBallTransparent.Image, imageX , imageY, PicBallTransparent.Width, PicBallTransparent.Height);
            g.DrawImage(PicMan.Image, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);

            //Checking for collision;
            if (( (imageX+PicBallTransparent.Width) > manX) && (imageX < (manX + PicMan.Width)) && ((imageY + PicBallTransparent.Height )> manY) && (imageY < (manY+ PicMan.Height)))
            {
                imageY = manY - PicBallTransparent.Height;
                imageDir = -1;
                Console.Beep();
            }
             else if (imageY > panel1.Height)
            {
                imageY = -PicBallTransparent.Height;
                imageDir = 1;
            }
            else if (imageY < 0)
            {
                imageY = 0;
                imageDir = 1;
                Console.Beep();
            }            
        }

        

        private void FrmDrawImage_KeyDown(object sender, KeyEventArgs e)
        {
            g.FillRectangle(blankBrush, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);

            if (e.KeyCode == Keys.L)
            {
                manX += 5;
            }
            else if (e.KeyCode == Keys.J)
            {
                manX -= 5;
            }

            g.DrawImage(PicMan.Image, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);
        }
    }
}