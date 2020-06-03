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
            
            //The draw process is modified so that instead of the paint handler
            //being passed a Graphic for the screen, it is passed a Graphic for an
            //in memory bitmap. 
            //When you draw to this Graphic object, you are drawing on an invisible image
            ///At the end of the draw cycle, this bitmap is copied to the main window
            //automatically and the actual pixels you see are all changed in a fraction
            //of a second instead of one at a time as the draw cycle progresses.

            this.DoubleBuffered = true;
            
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
        }

        Image background = Image.FromFile(Application.StartupPath + @"\mars.jpg");
        Image bullet = Image.FromFile(Application.StartupPath + @"\bullet.gif");
        Image explode = Image.FromFile(Application.StartupPath + @"\explosion.gif");
        Image tbird = Image.FromFile(Application.StartupPath + @"\tbird.gif");

        int x,y;        //position of ship at the bottom of the screen

        int targetX ,targetY;
        int targetDX, targetDY;

        int bulletX, bulletY;
        int bulletDY;
                
        int score;

        bool hit;

        Image[] images = new Image[17];
        Image ship;
        int count ;

        int countdown;

        Random r = new Random();

        // Sound file strings
        SoundPlayer explosion = new SoundPlayer();
        SoundPlayer backgroundmusic = new SoundPlayer();
        SoundPlayer laser = new SoundPlayer();
        

        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);            

        }

        private void DrawStuff(Graphics g)
        {
            Font font = new Font("Arial",9,FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Font GameOverfont = new Font("Arial", 40, FontStyle.Bold);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            
            g.DrawImage(background, 0, 0);
            
            g.DrawString("Turn Num Lock On Then move left and right with the 4 and 6 keys", font, yellowBrush, 200, 3);
            g.DrawString("Shoot with the 8 key", font, yellowBrush, ClientSize.Width/2, 20);
            g.DrawString("Current Score -> " + score.ToString(), font, yellowBrush, 5, 5);
            g.DrawString("Time Left -> " + countdown.ToString(), font, yellowBrush, 5, 20);
            
            g.DrawImage(ship, x, y);
            g.DrawImage(tbird, targetX, targetY);
            g.DrawImage(bullet, bulletX, bulletY);

            if (hit)
            {
                g.DrawImage(explode, targetX, targetY);
                explosion.Play();

                Initialize();
            }

            if (countdown <= 0)
            {
                g.DrawString("GAME OVER !!!", GameOverfont, blueBrush, ClientSize.Width/2- 200, ClientSize.Height/2);
                g.DrawString("Press the Start Button to Play Again", font, yellowBrush, ClientSize.Width / 2 -100, ClientSize.Height / 2 + 60);
                StopGame();
            }
            
        }
               

        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            
            //Even though we set these 6 values in Initialize()
            //they need to be set here too!
            //Once the program starts,the form paint is excecuted BEFORE
            //the user has a chance to press the START button
            
            hit = false;
            score = 0;
            countdown = 60;

            targetX = 120;
            targetY = 5;  //position until start button pressed
                        
            bulletX = ClientSize.Width + 100;   //position bullet offscreen until needed
            bulletY = ClientSize.Height + 100;
                        
            
            for (int i = 1; i <= 16; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\ship" + i.ToString() + ".gif");
            }

            ship = images[1];

            x = ClientSize.Width / 3;
            y = ClientSize.Height - ship.Height;

            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            backgroundmusic.SoundLocation = Application.StartupPath + @"\opening.wav";
            laser.SoundLocation = Application.StartupPath + @"\laser.wav";
            
            explosion.LoadAsync();
            backgroundmusic.LoadAsync();
            laser.LoadAsync();

            this.Focus(); 
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
           NewGame();
           timer1.Enabled = true;
           timer2.Enabled = true;
           timer3.Enabled = true; 
                       
        }

        private void Initialize()
        {
            
            hit = false;

            count = 1;

            targetX = 120;
            targetY = 5;  //position target offscreen until start button pressed

            targetDX = 20;
            targetDY = 10;

            //Add these lines below and comment out the lines above for a more
            //random and challenging game

            //targetDX = r.Next(31) + 20;
            //targetDY = r.Next(21) + 10;

            bulletX = ClientSize.Width + 100;   //position bullet offscreen until needed
            bulletY = ClientSize.Height + 100;  
            
            //don't move bullet until up arrow is pressed
            bulletDY = 0;

            
        }

        private void NewGame()
        {
            score = 0;
            countdown = 60;

            //backgroundmusic.Play();   background stops playing when shooting bullet
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\opening.wav";
            
            Initialize();
        }

        private void StopGame()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

            axWindowsMediaPlayer1.close();
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            ship= images[count];
            count++;
            if (count > 16)
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
                bulletX = x+35; 
                bulletY = y-10;
                bulletDY = -20;
                laser.Play();
            }

            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bulletY += bulletDY;            
            
            targetX += targetDX;
            targetY += targetDY;

            //if bullet reaches top without hitting target
            //move it off screen
            if (bulletY <= 0)
            {
                bulletDY = 0;
                bulletX = ClientSize.Width + 100;
                bulletY = ClientSize.Height + 100;
            }

            if (targetX > ClientSize.Width - tbird.Width)
                targetDX = -targetDX;

            if (targetX < 0)
                targetDX = -targetDX;

            if (targetY < 0)
                targetDY = -targetDY;

            if (targetY > ClientSize.Height - tbird.Height)
                targetDY = -targetDY;

            //Check for hit
            
            //note last check for flag==false
            //we want to make sure that we have been to DrawStuff 
            //where we display explosion and then reset the target ,bullet and hit flag
            //otherwise we may register the same hit more than once

            if ((bulletX + bullet.Width > targetX) && (bulletX < targetX + tbird.Width) && (bulletY + bullet.Height > targetY) && (bulletY < targetY + tbird.Height) && (hit == false))
            {
                score += 100;
                hit = true;
            }

            Invalidate();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            countdown--;
            Invalidate();

        }

        
    }
}