using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //Added for double buffering
using System.Text;
using System.Windows.Forms;
using System.Media;         //needed for SoundPlayer Class


namespace Animation1
{
    public partial class FrmAnimation : Form
    {
        public FrmAnimation()
        {
            InitializeComponent();

            //Enabling double-buffering to avoid flicker
            this.DoubleBuffered = true;            
        }

        //Images used in game 
        Image background = Image.FromFile(Application.StartupPath + @"\whack.gif");
        Image explode = Image.FromFile(Application.StartupPath + @"\explosion.gif");
        Image flame = Image.FromFile(Application.StartupPath + @"\flame.gif");

        // Sound objects
        SoundPlayer explosion = new SoundPlayer();
        SoundPlayer laser = new SoundPlayer();

        Image baby;
        int x,y;

        //these images will be loaded in FrmAnimation_Load
        Image[] images = new Image[15];
        int count;

        Image babytarget;
        int xtarget, ytarget;

        //position of flame and rate of movement
        int xflame, yflame, dxflame;
        
        int score = 0;
        int countdown = 60;        

        bool hit;

        //used to randomly position target baby
        Random r = new Random();

        //used to keep track of how long target baby is on screen
        long LastTick, CurrentTick, FrameTime;

        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);            

        }

        private void DrawStuff(Graphics g)
        {
            Font font = new Font("Arial",9,FontStyle.Bold);
            Font GameOverfont = new Font("Arial", 40, FontStyle.Bold);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //current time in milliseconds
            CurrentTick = Environment.TickCount;

            //if times up move target baby to a new random location
            if(CurrentTick - LastTick > FrameTime)
            {
                Initialize();

                //Redraw screen contents (including flame)here after moving target
                //this reduces flicker
                g.DrawImage(background, 0, 0);
                g.DrawString("Score " + score.ToString(), font, redBrush, 90, 10);
                g.DrawString("Time Left " + countdown.ToString(), font, redBrush, 90, 25);
                g.DrawImage(baby, x, y);
                g.DrawImage(babytarget, xtarget, ytarget);
                g.DrawImage(flame, xflame, yflame);

            }
            else
            {            
                g.DrawImage(background, 0, 0);
                g.DrawString("Score " + score.ToString() , font, redBrush, 90, 10);
                g.DrawString("Time Left " + countdown.ToString(), font, redBrush,90,25);
                g.DrawImage(baby, x, y);
                g.DrawImage(babytarget, xtarget, ytarget);
                g.DrawImage(flame, xflame, yflame);

                if (hit)
                {
                    g.DrawImage(explode, xtarget, ytarget);
                    explosion.Play();                                      

                    Initialize();
                }

                if (countdown <= 0)
                {
                    g.DrawString("GAME OVER !!!", GameOverfont, redBrush, ClientSize.Width / 2 - 200, ClientSize.Height / 2);
                    g.DrawString("Press the Start Button to Play Again", font, redBrush, ClientSize.Width / 2 - 100, ClientSize.Height / 2 + 60);
                    StopGame();
                }
            }
            
        }
               

        private void FrmAnimation_Load(object sender, EventArgs e)
        {
                        
            //starting position of animated baby
            x = this.Width/3;
            y = this.Height / 3;

            //target baby offscreen initially
            xtarget = -100;
            ytarget = -100;

            //flame offscreen initially with zero rate of change
            xflame=-100;
            yflame=-100;
            dxflame=0;

            for (int i = 1; i <= 14; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\baby" + i.ToString() + ".gif");
            }

            //initial baby images on screen
            baby = images[1];
            babytarget = images[14];

            //load explosion and laser sound (for flame)
            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            explosion.LoadAsync();
            laser.SoundLocation = Application.StartupPath + @"\laser.wav";
            laser.LoadAsync();

            //random time to keep target baby on screen
            FrameTime = r.Next(3000, 8000);
            //initial time used in conjunction with CurrentTick to determine elapsed time
            LastTick = Environment.TickCount;

            this.Focus();            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            NewGame();

            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;
            timer3.Enabled = !timer3.Enabled;
            
        }

        private void StopGame()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            baby= images[count];
            count++;
            if (count > 14)
                count = 1;

            Invalidate();   //refreshes screen otherwise image wont change

        }

        private void FrmAnimation_KeyDown(object sender, KeyEventArgs e)
        {
            //Make sure to turn Num Lock on
            
            if (e.KeyCode == Keys.NumPad6)
            {
                x += 5;
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                x -= 5;
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                y -= 5;
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                y += 5;
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                xflame = x + 35;    //offset to start flame shooting
                yflame = y + 10;
                dxflame = 15;       //rate of movement of flame changed FROM 0 to 15
                laser.Play();   
            }

            Invalidate();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            countdown--;
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Update position of flame with rate of change
            //most of the time dxflame will be zero and xflame=-100
            //so the flame will be offscreen
            //when flame button is pressed -> xflame becomes current x position of baby
            //and dxflame becomes 15
            xflame += dxflame;                       

            //if bullet reaches right side without hitting target
            //move it off screen
            if (xflame > ClientSize.Width)
            {
                dxflame = 0;
                xflame = -100;
                yflame = -100;
            }
            
            //Check for hit

            //note last check for flag==false
            //we want to make sure that we have been to DrawStuff 
            //where we display explosion and then reset the target ,flame and hit flag
            //otherwise we may register the same hit more than once
            if ((x + baby.Width > xtarget) && (x < xtarget + babytarget.Width) && (y + baby.Height > ytarget) && (y < ytarget + babytarget.Height) && (hit == false))
            {
                score += 1;
                hit = true;
            }
            else if ((xflame + flame.Width > xtarget) && (xflame < xtarget + babytarget.Width) && (yflame + flame.Height > ytarget) && (yflame < ytarget + babytarget.Height) && (hit == false))
            {
                score += 1;
                hit = true;
            }

            Invalidate();
        }

        private void Initialize()
        {

            hit = false;

            count = 1;

            //position flame offscreen until needed
            xflame = -100;
            yflame = -100;
            
            //don't move flame until correct key/button is pressed
            dxflame = 0;
                   
            //randomly position next baby target 
            xtarget = r.Next(1, ClientSize.Width);
            ytarget = r.Next(1, ClientSize.Height);

            baby = images[1];
            babytarget = images[r.Next(1,15)];  //new random baby target image

            //new random time that target baby stays on screen
            FrameTime = r.Next(3000, 8000);
            LastTick = Environment.TickCount;

            Invalidate();

        }

       
        private void NewGame()
        {
            score = 0;
            countdown = 60;
            
            Initialize();
        }

        private void FrmAnimation_MouseMove(object sender, MouseEventArgs e)
        {
            //pass mouse position to position of baby
            x = e.X;        
            y = e.Y;

            Invalidate();
        }

        private void FrmAnimation_MouseDown(object sender, MouseEventArgs e)
        {
            //initiate flame movement by pressing down on left mouse button
            if (e.Button == MouseButtons.Left)
            {                
                xflame = x + 35;
                yflame = y + 10;
                dxflame = 15;
                laser.Play();

                Invalidate();               
            }
        }

        
    }
}