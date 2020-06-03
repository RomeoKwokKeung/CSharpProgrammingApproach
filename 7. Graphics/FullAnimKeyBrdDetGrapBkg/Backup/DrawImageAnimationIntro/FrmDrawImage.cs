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

        
        Image[] images = new Image[8];

        Image background;

        //we dont use any picture boxes on the form at all
        //everything is an image object that we will load in
        Image man;
        Image ball;

        int count = 1;
        
        Graphics g;
        
        int imageY;
        int imageDir;
        int manX, manY;
        
        //cant use because we are using a multi colored graphic background
        //SolidBrush blankBrush;

        private void FrmDrawImage_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            
            //blankBrush = new SolidBrush(panel1.BackColor);

            //load background and ball
            background = Image.FromFile(Application.StartupPath + @"\mars.jpg");
            ball = Image.FromFile(Application.StartupPath + @"\trball.gif");

            //load in animated man
            for (int i = 1; i <= 7; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\tDribble" + i.ToString() + ".gif");
            }
            
            //PicMan.Image = images[1]; // display first image
            man = images[1];

            // set PictureBox to be the same size as Image
            //PicMan.Size = PicMan.Image.Size; 

            this.Focus();            
            
        }

        private void FrmDrawImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
            //blankBrush.Dispose();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                manX = (int)((panel1.Width - man.Width) / 2);
                manY = panel1.Height - man.Height;
                imageY = 0;
                imageDir = 1;

                //g.Clear(panel1.BackColor);

                //instead of wiping the screen with the backcolor we now
                //redraw the background graphic over the current state of the
                //animaton
                g.DrawImage(background, 0, 0);
                
                //g.DrawImage(PicMan.Image, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);
                
                //draw the initial state of the man
                g.DrawImage(man, manX, panel1.Height - man.Height);
                
                this.Focus();
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int imageX = (int) ((panel1.Width-ball.Width)/2);
            
            //g.Clear(panel1.BackColor);

            //g.FillRectangle(blankBrush, imageX, imageY, PicBallTransparent.Width, PicBallTransparent.Height);
            //g.FillRectangle(blankBrush, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);

            //instead of wiping the screen with the backcolor 
            //or using the FillRectangle which wont work we now 
            //redraw the background graphic over the current state of the
            //animaton
            g.DrawImage(background, 0, 0);

            imageY += imageDir*panel1.Height / 100;

            //g.DrawImage(PicBallTransparent.Image, imageX , imageY, PicBallTransparent.Width, PicBallTransparent.Height);
            //g.DrawImage(PicMan.Image, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);

            //redraw the ball and the man            
            g.DrawImage(ball, imageX , imageY);
            g.DrawImage(man, manX, panel1.Height - man.Height);


            //Checking for collision;
            if (( (imageX+ball.Width) > manX) && (imageX < (manX + man.Width)) && ((imageY + ball.Height )> manY) && (imageY < (manY+ man.Height)))
            {
                imageY = manY - ball.Height;
                imageDir = -1;
                Console.Beep();
            }
             else if (imageY > panel1.Height)
            {
                imageY = -ball.Height;
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
                        
            //old method and new method
         
            //using the old method you must have the lines below otherwise there are
            //artifacts (the man doesn't get completely erased and redrawn)
            
            //g.FillRectangle(blankBrush, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);            

            //Now if your using the new method of completely going over top of the 
            //entire panel with either the original BackColor (the very first method)
            //or this new technique with the DrawImage then you may not need the line
            //below
            //If it causes too much flicker the initial and ending lines may be removed            
            
            //g.DrawImage(background, 0, 0);
            
            if (e.KeyCode == Keys.L)
            {
                manX += 5;
            }
            else if (e.KeyCode == Keys.J)
            {
                manX -= 5;
            }

            //Redraw man (old and new method)

            //g.DrawImage(PicMan.Image, manX, panel1.Height - PicMan.Height, PicMan.Width, PicMan.Height);
            //g.DrawImage(man, manX, panel1.Height - man.Height);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            man = images[count];
            count++;
            if (count > 7)
                count = 1;
        }
                
    }
}