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

        Graphics myGraphics;

        Random myRandom = new Random();
        
        int[] ballX = new int[5];
        int[] ballY = new int[5];
        
        int[] ballSpeed = new int[5];

        //size of object fallings
        int ballSize;
        
        //position of dribbler
        int manX;

        //used to cycle through dribbler images
        int count = 1;
        
        Image background;
        Image man;

        //image array of falling objects 
        Image[] signs = new Image[5];
        
        //image array of dribbler
        Image[] images = new Image[8];

        bool flag = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            myGraphics = pnlBeachBalls.CreateGraphics();

            background = Image.FromFile(Application.StartupPath + @"\mars.jpg");            
            
            //image array of falling objects loaded 
            for (int i = 1; i <= 4; i++)
            {
                signs[i] = Image.FromFile(Application.StartupPath + @"\ntrffc0" + i.ToString() + ".gif");
            }

            //load in animated man
            for (int i = 1; i <= 7; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\tDribble" + i.ToString() + ".gif");
            }

            man = images[1];        

            // Have the balls spread across the panel with 20 pixels borders
            ballSize = (int) ((pnlBeachBalls.Width - 6 * 20) / 4);

            int x=10;
                        
            for (int i = 1; i <=4; i++)
            {
                ballX[i] = x;
                x = x + ballSize + 20;
            }            
                        
            // Give form focus
            this.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Erase arrow at old location unless it causes to much flicker
            //myGraphics.DrawImage(background, 0, 0);

            //don't allow man to move unless game is official started or restarted
            //remove to observe results
            if (flag == true)
            {
                // Check for F key (left) and J key (right) and compute arrow position
                if (e.KeyCode == Keys.J)
                {
                    manX = manX - 5;
                }
                else if (e.KeyCode == Keys.L)
                {
                    manX = manX + 5;
                }

                // Position dribbler
                myGraphics.DrawImage(man, manX, pnlBeachBalls.Height - man.Height, man.Width, man.Height);
            }
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
                flag = true;
                myGraphics.DrawImage(background, 0, 0);
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
                
                // Set man near center
                manX = (int)(pnlBeachBalls.Width / 2);
                
                myGraphics.DrawImage(man, manX, pnlBeachBalls.Height - man.Width,man.Width,man.Height);
                
                // Give form focus so it can accept KeyDown events
                this.Focus();
            }
            else
            {
                // Game stopped
                flag = false;
                txtOver.Visible = true;
                btnStart.Text = "Start";
                btnExit.Enabled = true;
                
            }
            
            // Toggle timers
            timBalls.Enabled = !(timBalls.Enabled);
            timGame.Enabled = !(timGame.Enabled);
            timDribbler.Enabled = !(timDribbler.Enabled);

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
            //redraw background thus erasing falling objects
            myGraphics.DrawImage(background, 0, 0);
            
            for (int i = 1; i <=4; i++)
            {
                               
                // move falling obejct [i]
                ballY[i] = ballY[i] + ballSpeed[i];
                
                // check if falling object [i] has been hit 
                if ((ballY[i] + ballSize) > (pnlBeachBalls.Height - man.Height))
                {
                    if (ballX[i]-20 < manX)     //-20/+20 added to make sure falling
                    {                           //ojbect bigger than dribbler 
                        if ((ballX[i] + ballSize +20) > (manX + man.Width))
                        {
                            // obect [i] has been hit
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
                    // object [i] reaches bottom without being hit
                    // Move back to top with new speed
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(4) + 3;
                }
               
                // redraw falling object [i] and dribbler at new location
                myGraphics.DrawImage(man, manX, pnlBeachBalls.Height - man.Width,man.Width,man.Height);
                myGraphics.DrawImage(signs[i], ballX[i], ballY[i], ballSize, ballSize);
            }            
        }

        private void timDribbler_Tick(object sender, EventArgs e)
        {
            man = images[count];
            count++;
            if (count > 7)
                count = 1;
        }
    }
}