#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

#endregion

namespace Pong
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Sound file strings
        SoundPlayer paddleHit = new SoundPlayer();
        SoundPlayer wall = new SoundPlayer();
        SoundPlayer missed = new SoundPlayer();
        SoundPlayer cheering = new SoundPlayer();
        Random myRandom = new Random();
        // Ball information
        Rectangle ballRect;
        int ballSize = 25;
        Image ballImage;
        Brush blankBrush;
        int xStart, yStart;
        int xSpeed, ySpeed;
        int speedUnit;
        int xDir, yDir;
        // Paddle information
        Rectangle paddleRect1, paddleRect2, previous;
        int paddleW = 5;
        int paddleH = 50;
        int yStartPaddle1, yStartPaddle2;
        int xPaddle1, xPaddle2;
        int paddleIncrement;
        // Field information
        Graphics field;
        // Game play info
        int score1, score2;
        bool paused;
        // Number of points to win
        const int win = 10;
        // 'Number of bounces before speed increases
        const int bounce = 10;
        int numBounce;


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // dispose of objects
            field.Dispose();
            ballImage.Dispose();
            blankBrush.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            field.FillRectangle(blankBrush, paddleRect1);
            field.FillRectangle(blankBrush, paddleRect2);
            // move paddles
            switch (e.KeyCode)
            {
                // Player 1 motion
                case Keys.A:
                    if ((paddleRect1.Top - paddleIncrement) > 0)
                    {
                        paddleRect1.Y -= paddleIncrement;
                    }
                    break;
                case Keys.Z:
                    if ((paddleRect1.Bottom + paddleIncrement) < pnlField.ClientSize.Height)
                    {
                        paddleRect1.Y +=paddleIncrement;
                    }
                    break;
                // Player 2 Motion
                case Keys.K:
                    if ((paddleRect2.Top - paddleIncrement) > 0)
                    {
                        paddleRect2.Y -= paddleIncrement;
                    }
                    break;
                case Keys.M:
                    if ((paddleRect2.Bottom + paddleIncrement) < pnlField.ClientSize.Height)
                    {
                        paddleRect2.Y += paddleIncrement;
                    }
                    break;
            }
            field.FillRectangle(Brushes.Red, paddleRect1);
            field.FillRectangle(Brushes.Red, paddleRect2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load sound files
            paddleHit.SoundLocation = Application.StartupPath + "\\paddle.wav";
            missed.SoundLocation = Application.StartupPath + "\\missed.wav";
            wall.SoundLocation = Application.StartupPath + "\\wallhit.wav";
            cheering.SoundLocation = Application.StartupPath + "\\cheering.wav";
            paddleHit.LoadAsync();
            missed.LoadAsync();
            wall.LoadAsync();
            cheering.Load();
            // Establish graphics regions
            field = pnlField.CreateGraphics();      
            ballImage = Image.FromFile(Application.StartupPath + "\\ball.wmf");
            // Initialize ball and paddle locations
            xStart =  (int) (0.5 * (pnlField.ClientSize.Width - ballSize));
            yStart = (int) (0.5 * (pnlField.ClientSize.Height - ballSize));
            ballRect = new Rectangle(xStart, yStart, ballSize, ballSize);
            xPaddle1 = 5;
            xPaddle2 = pnlField.ClientSize.Width - paddleW - 5;
            yStartPaddle1 = (int) (0.5 * (pnlField.ClientSize.Height - paddleH));
            yStartPaddle2 = yStartPaddle1;
            paddleRect1 = new Rectangle(xPaddle1, yStartPaddle1, paddleW, paddleH);
            paddleRect2 = new Rectangle(xPaddle2, yStartPaddle2, paddleW, paddleH);
            blankBrush = new SolidBrush(pnlField.BackColor);
            // Get ready to play
            paused = false;
            btnNew.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // New game code
            // Reset scores
            txtScore1.Text = "0";
            txtScore2.Text = "0";
            score1 = 0;
            score2 = 0;
            // Reset ball (you might adjust xspeed and the timer interval if things
            // move too fast or too slow
            speedUnit = 1;
            xSpeed = 4 * speedUnit;
            ySpeed = xSpeed;
            ResetBall();
            // Reset paddles
            field.Clear(pnlField.BackColor);
            paddleIncrement = 5;
            numBounce = 0;
            ResetPaddles();
            btnNew.Enabled = false;
            btnPause.Text = "&Pause";
            paused = false;
            btnPause.Enabled = true;
            btnExit.Enabled = false;
            timGame.Enabled = true;
            this.Focus();
         }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!paused)
            {
                timGame.Enabled = false;
                btnNew.Enabled = true;
                btnExit.Enabled = true;
                paused = true;
                btnPause.Text = "&Restart";
            }
            else
            {
                timGame.Enabled = true;
                btnNew.Enabled = false;
                btnExit.Enabled = false;
                paused = false;
                btnPause.Text = "&Pause";
            }
            this.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // end game
            this.Close();
        }

        private void timGame_Tick(object sender, EventArgs e)
        {
            // Main routine
            int xInc, yInc;
            Rectangle collision1, collision2;
            Rectangle collision = new Rectangle(0, 0, 0, 0);
            // if paused, do nothing
            if (paused)
            {
                return;
            }
            // determine ball motion increments
            xInc = xDir * xSpeed;
            yInc = yDir * ySpeed;
            // Ball hits top wall
            if ((ballRect.Top + yInc) < 0)
            {
                yDir = -yDir;
                yInc = yDir * ySpeed;
                wall.Play();
            }
            // Ball hits bottom wall
            if ((ballRect.Bottom + yInc) > pnlField.ClientSize.Height)
            {
                yDir = -yDir;
                yInc = yDir * ySpeed;
                wall.Play();
            }
            // Ball goes past right wall - Player 1 scores
            if (ballRect.Left > pnlField.ClientSize.Width)
            {
                UpdateScore(1);
            }
            // Ball goes past left wall - Player 2 scores
            if (ballRect.Right < 0)
            {
                UpdateScore(2);
            }
            // Check if either paddle and ball collided
            collision1 = Rectangle.Intersect(ballRect, paddleRect1);
            collision2 = Rectangle.Intersect(ballRect, paddleRect2);
            // Move ball
            field.FillRectangle(blankBrush, ballRect);
            ballRect.X += xInc;
            ballRect.Y += yInc;
            field.DrawImage(ballImage, ballRect);
            // If paddle hit, redraw paddle
            if (!(collision1.IsEmpty))
            {
                field.FillRectangle(Brushes.Red, paddleRect1);
                collision = collision1;
            }
            else if (!(collision2.IsEmpty))
            {
                field.FillRectangle(Brushes.Red, paddleRect2);
                collision = collision2;
            }
            // If we hit a paddle, change ball direction
            if (!(collision.IsEmpty) && previous.IsEmpty)
            {
                numBounce++;
                if (numBounce == bounce)
                {
                    numBounce = 0;
                    xSpeed += speedUnit;
                    ySpeed += speedUnit;
                }
                xDir = -xDir;
                paddleHit.Play();
            }
            previous = collision;
        }
  
        private void ResetPaddles()
        {
            // Reposition paddles
            paddleRect1.Y = yStartPaddle1;
            paddleRect2.Y = yStartPaddle2;
            field.FillRectangle(Brushes.Red, paddleRect1);
            field.FillRectangle(Brushes.Red, paddleRect2);
        }

        private void UpdateScore(int player)
        {
            int winner;
            SizeF sSize;
            winner = 0;
            // Update scores and see if game over
            timGame.Enabled = false;
            missed.Play();
            switch (player)
            {
                case 1:
                    score1++;
                    txtScore1.Text = Convert.ToString(score1);
                    txtScore1.Refresh();
                    if (score1 == win)
                    {
                        winner = 1;
                    }
                    break;
                case 2:
                    score2++;
                    txtScore2.Text = Convert.ToString(score2);
                    txtScore2.Refresh();
                    if (score2 == win)
                    {
                        winner = 2;
                    }
                    break;
            }
            if (winner == 0)
            {
                ResetBall();
                timGame.Enabled = true;
            }
            else
            {
                btnPause.Enabled = false;
                cheering.Play();
                sSize = new SizeF();
                sSize = field.MeasureString("Game Over", this.Font);
                field.DrawString("Game Over", this.Font, Brushes.Red, (int) (0.5 * (pnlField.ClientSize.Width - sSize.Width)), (int) (0.5 * (pnlField.ClientSize.Height - sSize.Height)));
                btnNew.Enabled = true;
                btnExit.Enabled = true;
                btnNew.Focus();
            }
        }

        private void ResetBall()
        {
            // Set random directions (1 or -1)
            xDir = 2 * myRandom.Next(2) - 1;
            yDir = 2 * myRandom.Next(2) - 1;
            ballRect.X = xStart;
            ballRect.Y = yStart;
        }


    }

      
}