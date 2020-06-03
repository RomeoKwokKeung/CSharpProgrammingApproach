#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace BeachBalls
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ballSize;
        int[] ballX = new int[5];
        int[] ballY = new int[5];
        int[] ballSpeed = new int[5];
        int arrowSize;
        int arrowX;

        Graphics myGraphics;
        Brush blankBrush;
        Random myRandom = new Random();

        //image array of falling objects declared
        Image[] signs = new Image[5];

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //image array of falling objects loaded 
            signs[0] = pictureBox1.Image;
            signs[1] = pictureBox2.Image;
            signs[2] = pictureBox3.Image;
            signs[3] = pictureBox4.Image;
            signs[4] = pictureBox5.Image;

            int x;
            // Have the balls spread across the panel with 20 pixels borders
            ballSize = (int) ((pnlBeachBalls.Width - 6 * 20) / 5);
            x = 10;
            for (int i = 0; i < 5; i++)
            {
                ballX[i] = x;
                x = x + ballSize + 20;
            }           

            // Make arrow one-half the ball size
            arrowSize = (int) (ballSize / 2);
            myGraphics = pnlBeachBalls.CreateGraphics();
            blankBrush = new SolidBrush(pnlBeachBalls.BackColor);
            // Give form focus
            this.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();
            blankBrush.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Erase arrow at old location
            myGraphics.FillRectangle(blankBrush, arrowX, pnlBeachBalls.Height - arrowSize, arrowSize, arrowSize);
            // Check for F key (left) and J key (right) and compute arrow position
            if (e.KeyCode == Keys.F)
            {
                arrowX = arrowX - 5;
            }
            else if (e.KeyCode == Keys.J)
            {
                arrowX = arrowX + 5;
            }
            // Position arrow
            myGraphics.DrawImage(picArrow.Image, arrowX, pnlBeachBalls.Height - arrowSize, arrowSize, arrowSize);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                // New Game
                myGraphics.Clear(pnlBeachBalls.BackColor);
                txtOver.Visible = false;
                btnStart.Text = "Stop";
                btnExit.Enabled = false;
                txtScore.Text = "0";
                // set each ball off top of panel and give new speed
                for (int i = 0; i < 5; i++)
                {
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(4) + 3;
                }
                // Set arrow near center
                arrowX = (int)(pnlBeachBalls.Width / 2);
                myGraphics.DrawImage(picArrow.Image, arrowX, pnlBeachBalls.Height - arrowSize, arrowSize, arrowSize);
                // Give form focus so it can accept KeyDown events
                this.Focus();
            }
            else
            {
                // Game stopped
                txtOver.Visible = true;
                btnStart.Text = "Start";
                btnExit.Enabled = true;
            }
            // Toggle timers
            timBalls.Enabled = !(timBalls.Enabled);
            timGame.Enabled = !(timGame.Enabled);
        }

        private void timGame_Tick(object sender, EventArgs e)
        {
            // 60 seconds have elapsed - stop game
            timBalls.Enabled = false;
            timGame.Enabled = false;
            txtOver.Visible = true;
            btnStart.Text = "Start";
            btnExit.Enabled = true;
        }

        private void timBalls_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                // erase falling object [i]
                myGraphics.FillRectangle(blankBrush, ballX[i], ballY[i], ballSize, ballSize);
                
                // move falling obejct [i]
                ballY[i] = ballY[i] + ballSpeed[i];
                
                // check if falling object [i] has popped 
                if ((ballY[i] + ballSize) > (pnlBeachBalls.Height - arrowSize))
                {
                    if (ballX[i] < arrowX)
                    {
                        if ((ballX[i] + ballSize) > (arrowX + arrowSize))
                        {
                            // obect [i] has popped
                            // Increase score - move back to top
                            Console.Beep();
                            txtScore.Text = Convert.ToString(Convert.ToInt32(txtScore.Text) + 1);
                            ballY[i] = -ballSize;
                            ballSpeed[i] = myRandom.Next(4) + 3;
                        }
                    }
                }
                // check for moving off bottom
                if ((ballY[i] + ballSize) > pnlBeachBalls.Height)
                {
                    // object [i] reaches bottom without popping
                    // Move back to top with new speed
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(4) + 3;
                }
                // redraw falling object [i] at new location
                myGraphics.DrawImage(signs[i], ballX[i], ballY[i], ballSize, ballSize);
            }
        }
    }
}