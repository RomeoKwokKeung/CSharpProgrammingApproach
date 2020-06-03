using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;         //needed for SoundPlayer Class


namespace DrawImageAnimationIntro
{
    public partial class FrmDrawImage : Form
    {
        public FrmDrawImage()
        {
            InitializeComponent();
        }

        // Sound file strings
        SoundPlayer wall = new SoundPlayer();
        SoundPlayer missed = new SoundPlayer();
        SoundPlayer cheering = new SoundPlayer();

        Image[] images = new Image[8];
        int count = 1;
        
        Graphics g;
        int imageY;
        int imageDir;
        int manX, manY;
        SolidBrush blankBrush;

        int wallflag;

        private void FrmDrawImage_Load(object sender, EventArgs e)
        {
            // Load sound files
            missed.SoundLocation = Application.StartupPath + @"\missed.wav";
            wall.SoundLocation = Application.StartupPath + @"\wallhit.wav";
            cheering.SoundLocation = Application.StartupPath + @"\cheering.wav";

            missed.LoadAsync();
            wall.LoadAsync();
            cheering.Load();
            
            g = panel1.CreateGraphics();
            blankBrush = new SolidBrush(panel1.BackColor);

            for (int i = 1; i <= 7; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\tDribble" + i.ToString() + ".gif");
            }

            PicMan.Image = images[1]; // display first image

            // set PictureBox to be the same size as Image
            PicMan.Size = PicMan.Image.Size; 

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
                wallflag = 0;
                g.Clear(panel1.BackColor);
                g.DrawImage(PicMan.Image, manX, manY, PicMan.Width, PicMan.Height);
                this.Focus();
                axWindowsMediaPlayer1.URL = Application.StartupPath + @"\world.wav";
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
            g.FillRectangle(blankBrush, manX, manY, PicMan.Width, PicMan.Height);

            imageY += imageDir*panel1.Height / 100;

            g.DrawImage(PicBallTransparent.Image, imageX , imageY, PicBallTransparent.Width, PicBallTransparent.Height);
            g.DrawImage(PicMan.Image, manX, manY, PicMan.Width, PicMan.Height);

            //Checking for collision;
            if (( (imageX+PicBallTransparent.Width) > manX) && (imageX < (manX + PicMan.Width)) && ((imageY + PicBallTransparent.Height )> manY) && (imageY < (manY+ PicMan.Height)))
            {
                imageY = manY - PicBallTransparent.Height;
                imageDir = -1;
                cheering.Play();
            }            
            else if (imageY > panel1.Height)
            {
                imageY = -PicBallTransparent.Height;
                imageDir = 1;
                wallflag = 1;
                missed.Play();
            }
            else if (imageY > 0)
            {
                wallflag = 0;
            }
            else if (imageY < 0 && wallflag==0)
            {
                imageY = 0;
                imageDir = 1;
                wall.Play();
            } 
           

        }        

        private void FrmDrawImage_KeyDown(object sender, KeyEventArgs e)
        {
            g.FillRectangle(blankBrush, manX, manY, PicMan.Width, PicMan.Height);

            if (e.KeyCode == Keys.L)
            {
                manX += 5;
            }
            else if (e.KeyCode == Keys.J)
            {
                manX -= 5;
            }

            g.DrawImage(PicMan.Image, manX, manY, PicMan.Width, PicMan.Height);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PicMan.Image = images[count];
            count++;
            if (count > 7)
                count = 1;
        }
    }
}