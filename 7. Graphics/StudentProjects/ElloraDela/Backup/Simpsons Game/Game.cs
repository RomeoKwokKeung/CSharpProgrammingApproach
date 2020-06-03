using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Simpsons_Game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            
        }

        Image background = Image.FromFile(Application.StartupPath + @"\bartsimpsonbackground.gif");
        Image explode = Image.FromFile(Application.StartupPath + @"\explosion.gif");
        
        SoundPlayer soundexplosion = new SoundPlayer();
        
        int mouseX, mouseY;
        bool clicked = false;

        Image barttarget, barttarget2, barttarget3, barttarget4;
        int x, y, x2, y2, x3, y3, x4, y4;

        Image[] images = new Image[29];
        int count;
        
        int score = 0;
        int countdown = 60;

        bool hit;

        Random r = new Random();

        long LastTick, CurrentTick, FrameTime;


        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawStuff(g);
        }

        private void DrawStuff(Graphics g)
        {
            g.DrawImage(background, 0, 0);
            Pen pen = new Pen(Color.Pink);
            g.DrawLine(pen, mouseX, 0, mouseX, ClientSize.Height);
            g.DrawLine(pen, 0, mouseY, ClientSize.Width, mouseY);

            if (clicked == true)
            {
                g.DrawImage(explode, mouseX - explode.Width / 2, mouseY - explode.Height / 2);
                soundexplosion.Play();
            }



            Font font = new Font("Arial", 9, FontStyle.Bold);
            Font GameOverfont = new Font("Arial", 40, FontStyle.Bold);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            CurrentTick = Environment.TickCount;

            if (CurrentTick - LastTick > FrameTime)
            {
                Initialize();

                g.DrawImage(background, 0, 0);
                g.DrawImage(barttarget, x, y);
                g.DrawImage(barttarget2, x2, y2);
                g.DrawImage(barttarget3, x3, y3);
                g.DrawImage(barttarget4, x4, y4);
                g.DrawLine(pen, mouseX, 0, mouseX, ClientSize.Height);
                g.DrawLine(pen, 0, mouseY, ClientSize.Width, mouseY);
                g.DrawString("Score " + score.ToString(), font, redBrush, 90, 10);
                g.DrawString("Time Left " + countdown.ToString(), font, redBrush, 90, 25);                
            }

            else
            {
                g.DrawImage(background, 0, 0);
                g.DrawImage(barttarget, x, y);
                g.DrawImage(barttarget2, x2, y2);
                g.DrawImage(barttarget3, x3, y3);
                g.DrawImage(barttarget4, x4, y4);
                g.DrawLine(pen, mouseX, 0, mouseX, ClientSize.Height);
                g.DrawLine(pen, 0, mouseY, ClientSize.Width, mouseY);
                if (clicked == true)
                {
                    g.DrawImage(explode, mouseX - explode.Width / 2, mouseY - explode.Height / 2);
                    soundexplosion.Play();
                }
                g.DrawString("Score " + score.ToString(), font, redBrush, 90, 10);
                g.DrawString("Time Left " + countdown.ToString(), font, redBrush, 90, 25);
                

                if (hit)
                {
                    g.DrawImage(explode, x, y);
                    soundexplosion.Play();

                    g.DrawLine(pen, mouseX, 0, mouseX, ClientSize.Height);
                    g.DrawLine(pen, 0, mouseY, ClientSize.Width, mouseY);

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

        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clicked = true;
                timer1.Enabled = true;
                timer4.Enabled = true;
                Invalidate();
            }
            
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            Invalidate();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            soundexplosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            soundexplosion.LoadAsync();       


            x = this.Width / 3;
            y = this.Height / 3;

            x2 = this.Width / 3;
            y2 = this.Height / 3;

            x3 = this.Width / 3;
            y3 = this.Height / 3;

            x4 = this.Width / 3;
            y4 = this.Height / 3;

            x = -100;
            y = -100;

            x2 = -100;
            y2= -100;

            x3 = -100;
            y3 = -100;

            x4 = -100;
            y4 = -100;

            for (int i = 1; i <= 28; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\bart" + i.ToString() + ".gif");
            }

            barttarget = images[28];
            barttarget2 = images[28];
            barttarget3 = images[28];
            barttarget4 = images[28];

            FrameTime = r.Next(2000, 8000);
            LastTick = Environment.TickCount;

            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clicked = false;
            timer1.Enabled = false;
            Invalidate();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            NewGame();

            timer2.Enabled = true;
            timer3.Enabled = !timer3.Enabled;
            
            
        }

        private void StopGame()
        {
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;   
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            barttarget = images[count];
            count++;
            if (count > 28)
                count = 1;

            barttarget2 = images[count];
            count++;
            if (count > 28)
                count = 1;

            barttarget3 = images[count];
            count++;
            if (count > 28)
                count = 1;

            barttarget4 = images[count];
            count++;
            if (count > 28)
                count = 1;

            Invalidate();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            countdown--;
            Invalidate();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if ((x < mouseX) && (x + barttarget.Width > mouseX) && (y < mouseY) && (y + barttarget.Height > mouseY) && (hit ==false))
            {
                score += 1;
                hit = true;
            }

            else if ((x2 < mouseX) && (x2 + barttarget2.Width > mouseX) && (y2 < mouseY) && (y2 + barttarget2.Height > mouseY) && (hit == false))
            {
                score += 1;
                hit = true;
            }

            else if ((x3 < mouseX) && (x3 + barttarget3.Width > mouseX) && (y3 < mouseY) && (y3 + barttarget3.Height > mouseY) && (hit == false))
            {
                score += 1;
                hit = true;
            }

            else if ((x4 < mouseX) && (x4 + barttarget4.Width > mouseX) && (y4 < mouseY) && (y4 + barttarget4.Height > mouseY) && (hit == false))
            {
                score += 1;
                hit = true;
            }
            timer4.Enabled = false;

            
            Invalidate();
        }

        private void Initialize()
        {
            hit = false;

            count = 1;

            x = r.Next(1, ClientSize.Width);
            y = r.Next(1, ClientSize.Height);

            x2 = r.Next(1, ClientSize.Width);
            y2 = r.Next(1, ClientSize.Height);

            x3 = r.Next(1, ClientSize.Width);
            y3 = r.Next(1, ClientSize.Height);

            x4 = r.Next(1, ClientSize.Width);
            y4 = r.Next(1, ClientSize.Height);

            FrameTime = r.Next(3000, 8000);
            LastTick = Environment.TickCount;
            barttarget = images[r.Next(1, 29)]; 

            Invalidate();
        }

        private void NewGame()
        {
            score = 0;
            countdown = 60;

            Initialize();
        }

        

        

    }
}