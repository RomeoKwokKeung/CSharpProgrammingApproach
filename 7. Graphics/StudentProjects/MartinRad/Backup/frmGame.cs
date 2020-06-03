#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Media;//needed for SoundPlayer Class
using System.Drawing.Drawing2D; //Added for double buffering

#endregion

namespace BeachBalls
{
    partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;

        }

        

        ///////////////////////////////////////////////////////////////
        //VARIABLE DICTIONARY                                        //
        //                                                           //
        //ballX - The x co oridinate of the falling objects          //
        //ballY - The y co oridinate of the falling objects          //
        //ballSpeed - the value for the speed of the falling objects //
        //ballSize - the size of the falling objects                 //
        //manX - the x co ordinate of the man                        //
        //count - counter used to cycle through the images           //
        //Image background - stores the background image             //
        //Image man - stores the man image                           //
        //guns - image array of falling objects                      //
        //images - image array of the man                            //
        //flag - stores true/false if the game is on or off          //
        ///////////////////////////////////////////////////////////////





        // Sound files strings
        SoundPlayer note1 = new SoundPlayer();
        SoundPlayer note2 = new SoundPlayer();
        SoundPlayer note3 = new SoundPlayer();
        SoundPlayer note4 = new SoundPlayer();
        SoundPlayer note5 = new SoundPlayer();

        Graphics myGraphics;

        Random myRandom = new Random();
        
        int[] ballX = new int[6];
        int[] ballY = new int[6];
        
        int[] ballSpeed = new int[6];

        //size of object fallings
        int ballSize;
        
        //position of fret base
        int manX;
        

        //loads in images
        Image background;
        Image flame;
        Image man;
        Image fretbase;
        

        //image array of falling objects 
        Image[] frets = new Image[6];
        

        bool flag = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads sound files
            note1.SoundLocation = Application.StartupPath + @"\note1.wav";
            note2.SoundLocation = Application.StartupPath + @"\note2.wav";
            note3.SoundLocation = Application.StartupPath + @"\note3.wav";
            note4.SoundLocation = Application.StartupPath + @"\note4.wav";
            note5.SoundLocation = Application.StartupPath + @"\note5.wav";

            myGraphics = pnlGame.CreateGraphics();

            //loads in background
            background = Image.FromFile(Application.StartupPath + @"\background.jpg");

            //loads in fret base
            fretbase = Image.FromFile(Application.StartupPath + @"\base.gif");

            //loads in flame
            flame = Image.FromFile(Application.StartupPath + @"\fire.gif");

            //image array of falling objects loaded 
            for (int i = 1; i <= 5; i++)
            {
                frets[i] = Image.FromFile(Application.StartupPath + @"\fret" + i.ToString() + ".gif");
            }

            
            //load in animated fret base
            man = Image.FromFile(Application.StartupPath + @"\base.gif");
       

            // Have the balls spread across the panel with 20 pixels borders
            ballSize = (int) ((pnlGame.Width - 6 * 20) / 5);

            int x=10;
                        
            for (int i = 1; i <=5; i++)
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

            //don't allow fret base to appear unless game is official started or restarted
            //remove to observe results
            if (flag == true)
            {
                // Check for C,V,B,N,M keys and compute fret base position
                if (e.KeyCode == Keys.C)
                {
                    manX = 10;
                    
                }
                else if (e.KeyCode == Keys.V)
                {
                    manX = 100;
                    
                }
                else if (e.KeyCode == Keys.B)
                {
                    manX = 190;
                    
                }
                else if (e.KeyCode == Keys.N)
                {
                    manX = 280;
                    
                }
                else if (e.KeyCode == Keys.M)
                {
                    manX = 370;
                    
                }

                // Position fret base
                myGraphics.DrawImage(fretbase, manX, pnlGame.Height - man.Height -10, man.Width, man.Height);

                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes program
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                // New Game
                flag = true;
                myGraphics.DrawImage(background, 0, 0);
                btnStart.Text = "Stop";
                btnExit.Visible = false;
                lblScore.Text = "0";
                txtTime.Text = "60";

                picGameOver.Visible = false;
                picScoreFinal.Visible = false;
                lblFinalScore.Visible = false;
                lblTitle.Visible = false;
                pnlGame.Visible = true;
               
                // set each ball off top of panel and give new speed
                for (int i = 1; i <= 5; i++)
                {
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(21,26);
                }

                //positions fret base off screen
                manX = (int)(pnlGame.Width);

                myGraphics.DrawImage(man, manX, pnlGame.Height - man.Width, man.Width, man.Height);
                
                // Give form focus so it can accept KeyDown events
                this.Focus();
            }
            else
            {
                // Game stopped
                flag = false;
                btnStart.Text = "Start";
                btnExit.Visible = true;

                picGameOver.Visible = true;
                picScoreFinal.Visible = true;
                lblFinalScore.Visible = true;
                lblFinalScore.Text = lblScore.Text;
                lblTitle.Visible = true;
                pnlGame.Visible = false;
                
            }
            
            // Toggle timers
            timBalls.Enabled = !(timBalls.Enabled);
            timGame.Enabled = !(timGame.Enabled);
            timDribbler.Enabled = !(timDribbler.Enabled);
            timTime.Enabled = !(timTime.Enabled);

        }

        private void timGame_Tick(object sender, EventArgs e)
        {
            // 60 seconds have elapsed - stop game
            flag = false;
            timBalls.Enabled = false;
            timGame.Enabled = false;
            timTime.Enabled = false;
            btnStart.Text = "Start";
            btnExit.Enabled = true;

            picGameOver.Visible = true;
            picScoreFinal.Visible = true;
            lblFinalScore.Visible = true;
            lblFinalScore.Text = lblScore.Text;
            lblTitle.Visible = true;
            pnlGame.Visible = false;
        }

        private void timBalls_Tick(object sender, EventArgs e)
        {
            //redraw background thus erasing falling objects
            myGraphics.DrawImage(background, 0, 0);

            

            for (int i = 1; i <=5; i++)
            {
                               
                // move falling obejct [i]
                ballY[i] = ballY[i] + ballSpeed[i];
                
                // check if falling object [i] has been hit 
                if ((ballY[i] + ballSize) > (pnlGame.Height - man.Height))
                {
                    if (ballX[i]-20 < manX)     //-20/+20 added to make sure falling
                    {                           //ojbect bigger than fret base 
                        if ((ballX[i] + ballSize +20) > (manX + man.Width))
                        {
                            // object [i] has been hit
                            

                            myGraphics.DrawImage(flame, manX, pnlGame.Height - man.Width - 17, man.Width, man.Height);

                            

                            // Increase score - move back to top
                            //determines what score the user got depending on the ballspeeds, and play a different note for each
                            if (ballSpeed[i] == 25)
                            {
                                note5.Play();
                                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 50);
                            }
                            else if (ballSpeed[i] == 24)
                            {
                                note4.Play();
                                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 40);
                            }
                            else if (ballSpeed[i] == 23)
                            {
                                note3.Play();
                                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 30);
                            }
                            else if (ballSpeed[i] == 22)
                            {
                                note2.Play();
                                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 20);
                            }
                            else if (ballSpeed[i] == 21)
                            {
                                note1.Play();
                                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 10);
                            }
                            ballY[i] = -ballSize;
                            ballSpeed[i] = myRandom.Next(21,26);
                        }
                    }
                }
                // check for moving off bottom
                if ((ballY[i] + ballSize) > pnlGame.Height)
                {
                    // object [i] reaches bottom without being hit
                    // Move back to top with new speed
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(21,26);
                }

                

                // redraw falling object [i] and fretbase at new location
                myGraphics.DrawImage(man, manX, pnlGame.Height - man.Width - 17,man.Width,man.Height);
                myGraphics.DrawImage(frets[i], ballX[i], ballY[i], ballSize, ballSize);
            }

            //positions fret base off screen
            manX = (int)(pnlGame.Width);

            myGraphics.DrawImage(man, manX, pnlGame.Height - man.Width, man.Width, man.Height);

        }


        private void timTime_Tick(object sender, EventArgs e)
        {
            //subtracts 1 from the timer display every second
            txtTime.Text = Convert.ToString(Convert.ToInt32(txtTime.Text) -1);
        }

      



        
    }
}