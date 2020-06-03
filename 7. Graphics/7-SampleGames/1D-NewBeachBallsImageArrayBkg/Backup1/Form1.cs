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

        //image array of falling objects 
        Image[] signs = new Image[5];

        //These are the corresponding locations and speeds of the falling objects
        //So those signs falling from the sky need an x and y position and a speed
        int[] ballX = new int[5];
        int[] ballY = new int[5];        
        int[] ballSpeed = new int[5];

        //size of objects falling (both its width and height)
        int ballSize;

        //background of screen
        Image background;

        //this variable stores the dribbler at any moment in time
        Image man;        
        //image array of dribbler
        Image[] images = new Image[8];
        //position of dribbler
        int manX;

        //used to cycle through dribbler images
        int count = 1;
            
        //used to see if game has started yet
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

            // Have the balls spread across the panel ... READ ALL MY LOGIC CAREFULLY TO FULLY UNDERSTAND

            // Now my first idea was to use the actual size of one of the signs but they were too small
            // and they basically just took up the left side of the screen. 
            // You can uncomment the line below and comment the second/third ballsize line to see how stupid it looked
            
            //ballSize = signs[1].Width;

            //So what I did is basically re-size the falling objects so they looks better on my screen
            //You might not need to do this because your images are big enough.
            //Also remember , in my program the falling object must be wider than the dribbler for my if statements to work
            
            //What I did with this crazy formula was basically take the entire width of the panel and roughly space out my 4
            //objects. You can see by the divide by 4 part where I try to even things out 
            //ballSize = (int)(pnlBeachBalls.Width / 4);
            
            //When I did that the signs were a little too big and spaced out so I took a little bit off until they looked right
            //Thats the neat thing about graphics ... there is always some trial and error. Below is what I finally came up with.
            
            ballSize = (int) ((pnlBeachBalls.Width - 6 * 20) / 4);

            //this is where the first object is going to drop from ie ... 10 pixels over from the left side.
            int x=10;
                        
            //now work out where the rest of the balls will be
            for (int i = 1; i <=4; i++)
            {
                ballX[i] = x;
                x = x + ballSize + 20; //next sign will be over at least the size of the sign + 20  
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
            // Erase dribbler at old location unless it causes to much flicker... as you can see it did flicker too much so 
            // I commented it out

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
                // remember to want your man moving right along the bottom
                // so thats where -->  pnlBeachBalls.Height-man.Height <--- comes in
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
                flag = true;                            //this is to start your dribbler dribbling 
                myGraphics.DrawImage(background, 0, 0);
                txtOver.Visible = false;
                btnStart.Text = "Stop";
                btnExit.Enabled = false;
                txtScore.Text = "0";
               
                // set each ball off top of panel and give it a dropping speed
                // some neat lines here
                // first we are positioning vertically where the signs are going to start dropping.
                // we have already figured out the x positions
                // so ballY[i]=-ballSize ...... positions them vertically. But note the negative.
                // Where is negative ? Well thats right above the top of the panel (above zero... goes to negatives)
                for (int i = 1; i <=4; i++)
                {
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(1, 7); //this sets the dropping speed of each sign between 1 and 6 pixels
                }                                       //you can change this to whatever you want to make your game harder
                
                // Set man near center
                manX = (int)(pnlBeachBalls.Width / 2);
                
                myGraphics.DrawImage(man, manX, pnlBeachBalls.Height - man.Height,man.Width,man.Height);
                
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
            // Remember ! means make it the OPPOSITE of whatever the property was ... so if it was false make it true
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
            //notice that the command below is missing two more numbers after the 0,0
            //usually those numbers are for the size (width and height) you want your background or whatever to be
            //if you leave them out the entire real size of the background gets slapped on the screen.
            myGraphics.DrawImage(background, 0, 0);
            
            for (int i = 1; i <=4; i++)                 //this loop goes to 4 because I have 4 signs dropping
            {
                               
                // move falling obejct [i]
                ballY[i] = ballY[i] + ballSpeed[i];
                
                // check if falling object [i] has been hit 

                // I don't wake up and worry about the object UNTIL
                // the BOTTOM of a sign is near the TOP of the dribblers head
                if ((ballY[i] + ballSize) > (pnlBeachBalls.Height - man.Height))
                {
                    //Now I check if the sign is further left than the dribbler 
                    
                    if (ballX[i]-20 < manX)     //-20 +20 added to make sure falling object bigger than dribbler 
                    {
                        //This checks if the sign is also further right than the dribbler
                        //so basically the sign covers the entire dribbler

                        if ((ballX[i] + ballSize +20) > (manX + man.Width))
                        {
                            // all conditions are true ... so obect [i] has been hit
                            // Increase score - move back to top

                            Console.Beep();     //you better replace this stupid beep with a real sound effect

                            //you better replace this simple scoring with a bunch of if statements
                            //where you get different points for signs that fall faster and less points for 
                            //signs that fall slower (want a better mark ... put this scoring in a method)
                            txtScore.Text = Convert.ToString(Convert.ToInt32(txtScore.Text) + 1);

                            //now that you have destroyed your object make it disappear ... sort of
                            //move the object off screen ... into negative territory and give it a new random speed
                            ballY[i] = -ballSize;
                            ballSpeed[i] = myRandom.Next(1,7);
                        }
                    }
                }

                // what if the dribbler didn't hit the sign... because the ballY[i] hasn't been made into a negative ... then
                // check for moving off bottom
                if ((ballY[i] + ballSize) > pnlBeachBalls.Height)
                {
                    // object [i] reaches bottom without being hit
                    // Move back to top with new speed
                    ballY[i] = -ballSize;
                    ballSpeed[i] = myRandom.Next(4) + 3;
                }
               
                // redraw falling object [i] and dribbler at new location
                myGraphics.DrawImage(man, manX, pnlBeachBalls.Height - man.Height,man.Width,man.Height);
                myGraphics.DrawImage(signs[i], ballX[i], ballY[i], ballSize, ballSize);
            }            
        }

        private void timDribbler_Tick(object sender, EventArgs e)
        {
            //This is your standard method for looping through all the images of your dribbler
            man = images[count];
            count++;
            if (count > 7)
                count = 1;
        }
    }
}