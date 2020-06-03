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

            this.DoubleBuffered = true; // enable double buffering
            
        }

        //****************************************************************************//
        //                             VARIABLE DICTIONARY                            //
        //                             -------------------                            //
        // background - used for form background                                      //
        // bike - image for obstacle 1                                                //
        // truck - image for obstacle 2                                               //
        // bullet - image to shoot at obstacles                                       //
        // explode - image to show explosion                                          //
        // bus - image for obstactle 3                                                //
        // x - used as x co-ordinate for the car                                      //
        // y - used as the y co-ordinate for car                                      //
        // flag - used to enable and disable cars moving ability                      //
        // bulletX - used as x co-ordinate for the bullet                             //
        // bulletY - used as y co-ordinage for the bullet                             //
        // bulletDY - used to take away from the y co-orordinate                      //
        // bulletDX - used to take away from the x co-ordinate                        //
        // obstacle - used to choose a random obstacle                                //
        // lane - used to choose a random lane                                        //
        // busX - used as x co-ordinate for the bus                                   //
        // busY - used as y co-ordinate for the bus                                   //
        // bikeX - used as x co-ordinate for the bike                                 //
        // bikeY - used as y co-ordinate for the bike                                 //
        // truckX - used as x co-ordinate for the truck                               //
        // truckY - used as y co-ordinate for the truck                               //
        // score - keeps track of players score                                       //
        // lives - keeps track of players lives left                                  //
        // health - keeps track of players health left                                //
        // hit - used to check if a collision has been made                           //
        // starting - used so that the car can't move until game has been started     //
        // images - image array of cars for animated car                              //
        // car - image used to hold image of car                                      //
        // count - used to count for the animated car timer                           //
        // lane2 - used to store new y co-ordinate for obstacle                       //
        // countdown - takes away from the timeleft                                   //
        // r - used to have random images                                             //
        // explosion - explosion sound wav file for when a collision is detected      //
        // backgroundmusic - have a song playing in background                        //
        // laser - laser sound when the car shoots                                    //
        // scrape - used when the car brushes up against wall                         //
        // g - used to draw graphics                                                  //
        //****************************************************************************//


        Image background = Image.FromFile(Application.StartupPath + @"\background.jpg");
        Image bike = Image.FromFile(Application.StartupPath + @"\bike.png");
        Image truck = Image.FromFile(Application.StartupPath + @"\truck.png");
        Image bullet = Image.FromFile(Application.StartupPath + @"\missle.gif");
        Image explode = Image.FromFile(Application.StartupPath + @"\explosion.gif"); // load in images that will be needed
        Image bus = Image.FromFile(Application.StartupPath + @"\bus.png");

        int x,y;        //position of car at the bottom of the screen

        bool Flag;
        int bulletX, bulletY;
        int bulletDY, bulletDX;
        int obstacle, lane;

        int busX, busY, bikeX, bikeY, truckX, truckY;

        int score, lives, health;

        bool hit, starting;

        Image[] images = new Image[17];
        Image car;
        int count ;
        int lane2;
        int countdown;

        Random r = new Random(); // used for random numbers

        // Sound file strings
        SoundPlayer explosion = new SoundPlayer();
        SoundPlayer backgroundmusic = new SoundPlayer();
        SoundPlayer laser = new SoundPlayer();
        SoundPlayer scrape = new SoundPlayer();
        

        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //draws the graphics

            DrawStuff(g);            

        }

        private void DrawStuff(Graphics g)
        {

            Font font = new Font("Arial",12,FontStyle.Bold);
            SolidBrush redBrush = new SolidBrush(Color.Black); // sets the style and name of the brush that will be needed

            Font GameOverfont = new Font("Arial", 25, FontStyle.Bold);
            SolidBrush blueBrush = new SolidBrush(Color.Red); // another brush with a different style
            
           g.DrawImage(background, 0, 0); // draws the background image
          
            g.DrawImage(car, x, y); // redraws the car
            g.DrawImage(bus, busX, busY); //redraws the bus
            g.DrawImage(bike, bikeX, bikeY); //redraws the bike
            g.DrawImage(truck, truckX, truckY); //redraws the truck
            g.DrawImage(bullet, bulletX, bulletY); //redraws the missle

            if (hit) //checks to see if there was a hit
            {
                explosion.Play(); //play explosion sound

                Initialize();
            }


            if (y <= 245) // checks to see if car is hitting wall
            {
                health -= 1; // takes one off of health
                Flag = false; //makes it so you can't drive further into wall
            }
            else
            {
                Flag = true; //reset the flag back to true to be able to move the car again
            }

            if (health <= 0) // if health gets down to zero or lower
            {
                lives -= 1; // take off a life
                health = 100; //reset the health back to 100
            }

            if (countdown <= 0 || lives < 0) //if the countdown timer or lives get to 0 game over
            {
                g.DrawString("GAME OVER !!!", GameOverfont, blueBrush, ClientSize.Width/2 - 100, ClientSize.Height/2);   // displays game over
                g.DrawString("Press the Start Button to Play Again", font, redBrush, ClientSize.Width / 2 -100, ClientSize.Height / 2 + 67);
                StopGame(); //calls stop game
            }

            
        }
               

        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            this.Hide(); //hides the form

            Form f = new FrmMenu();

            f.Show(); // shows the menu form on startup

            hit = false; //set hit to false
            Flag = false; //set flag to false so car can't shoot
            starting = false; //set starting to false so car can't move until game is started
            health = 100; // set the health to 100

            score = 0; // set the score at 0
            countdown = 60; //set the time in the game to 60
                        
            bulletX = ClientSize.Width + 100;   //position bullet offscreen until needed
            bulletY = ClientSize.Height + 100;

            busX = 950; // position bus off screen until needed
            busY = 315;
            bikeX = 950; //position bike off screen until needed
            bikeY = 450;
            truckX = 950; //position truck off screen until needed
            truckY = 570;
            
            for (int i = 1; i <= 8; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\car" + i.ToString() + ".png"); //load in all the car images so it makes it animated
            }

            car = images[1]; //set the first image into car 

            x = 0; //set cars x to 0
            y = ClientSize.Height - car.Height - 20; //sets cars y

            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav"; // loading in all sound files needed
            backgroundmusic.SoundLocation = Application.StartupPath + @"\theme.mp3";
            laser.SoundLocation = Application.StartupPath + @"\flyin02.wav";
            scrape.SoundLocation = Application.StartupPath + @"\scrape.wav";
            
            //syncs sounds
            explosion.LoadAsync();
            backgroundmusic.LoadAsync();
            laser.LoadAsync();
            scrape.LoadAsync();

            //gives form focus
            this.Focus(); 
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            starting = true; // enable starting to let the car move and shoot
            NewGame();       // call new game
        }

        private void Initialize()
        {
            
            hit = false; //set hit as false
            Flag = false; // set flag as false so car can't shoot
            starting = false; //set starting as false so car can't move
             
            count = 1; // set animated car counter to 1

            bulletX = ClientSize.Width + 100;   //position bullet offscreen until needed
            bulletY = ClientSize.Height + 100;  
            
            //don't move bullet until shift is pressed
            bulletDY = 0;

            
        }

        private void NewGame()
        {
            score = 0; //reset the score to 0
            lives = 3; //reset lives to 3
            health = 100; // reset the health
            countdown = 60; //reset the time
            Flag = true; //enable the car so it can shoot
            starting = true; //enable key press so the car can movie

            timer1.Enabled = true; //enables timer 1 (collisions)
            timer2.Enabled = true; //enables timer2 (cycles through animated car
            timer3.Enabled = true; //start countdown timer
            timobstacle.Enabled = true; //start random cars timer

            //backgroundmusic.Play();   background stops playing when shooting bullet
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\theme.mp3";
            
            Initialize();
        }

        private void StopGame()
        {
            timer1.Enabled = false; //stop timer1
            timer2.Enabled = false; //stop timer2
            timer3.Enabled = false; //stop timer3
            timobstacle.Enabled = false; //stop timer4
            TimTruck.Enabled = false; //stop bus timer
            TimBus.Enabled = false; //stop bus timer
            TimBike.Enabled = false; // stop bike timer
            

            Flag = false; //disable flag so car can't shooot
            starting = false; //disable starting so car can't move
            hit = false; //set hit to false

            axWindowsMediaPlayer1.close(); //close media player

            Form z = new FrmHighScores(); 
            z.Show();
            this.Hide();


        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            LblScore.Text = score.ToString(); //sets the score into label
            LblTimeLeft.Text = countdown.ToString(); //sets the timeleft into label
            LblHealth.Text = health.ToString(); //sets health left into label
            LblLives.Text = lives.ToString(); //sets lives into labels
            starting = true; //set starting to true so car can movie

            car= images[count]; // cycles through all 8 car images
            count++;
            if (count > 8)
                count = 1;

            Invalidate();   //refreshes screen otherwise image wont change

        }

        private void FrmAnimation_KeyDown(object sender, KeyEventArgs e)
        {
            if (starting == true) // check to see if starting is true
            {
                if (e.KeyCode == Keys.W && Flag == true) 
                {
                    y -= 10; //move car up 

                }
                else if (e.KeyCode == Keys.S)
                {
                    y += 10; //move car down
                }
                else if (e.KeyCode == Keys.ShiftKey)
                {
                    bulletX = x + 200;
                    bulletY = y + 25;
                    bulletDX = +50; //make shot move 
                    laser.Play(); // play shooting sound
                }
            }

            Invalidate(); //refreshes screen otherwise image wont change
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bulletY += bulletDY; //how the bullet moves across screen when shot
            bulletX += bulletDX;

            //see if car hit the bus
            if ((x + car.Width > busX && y + car.Height > busY && y < busY + bus.Height) && (hit == false)) 
            {
                score -= 50; // take away 50 from score
                hit = true; // let hit know there has been a collision
                health -= 50; //take away 50 from health
                TimBus.Enabled = false; //disbale the bus timer
                busX = 950; //reset image to starting
            }

            // see if car hit the bike
            if ((x + car.Width > bikeX && y + car.Height > bikeY && y < bikeY + bike.Height) && (hit == false))
            {
                score -= 50; // take away 50 from score
                hit = true; //let hit know there has been a collision
                health -= 50; //take away 50 from health
                TimBike.Enabled = false; //disable timer
                bikeX = 950; //reset image to starting
            }

            //see if truck hit car
            if ((x + car.Width > truckX && y + car.Height > truckY && y < truckY + truck.Height) && (hit == false))
            {
                score -= 50; // take away 50 from score
                hit = true; //let hit know there has been a collision
                health -= 50; //take away 50 from health
                TimTruck.Enabled = false; //disable timer
                truckX = 950; //reset image to starting
            }

            //see if bullet hit truck
            if ((bulletX + bullet.Width > truckX) && (bulletX < truckX + truck.Width) && (bulletY + bullet.Height > truckY) && (bulletY < truckY + truck.Height) && (hit == false))
            {
                score += 100; // take away 100 from score
                hit = true; //let hit know there has been a collision
                TimTruck.Enabled = false; //disable timer
                truckX = 950; //reset image to starting
            }

            //see if bullet hit bike
            if ((bulletX + bullet.Width > bikeX) && (bulletX < bikeX + bike.Width) && (bulletY + bullet.Height > bikeY) && (bulletY < bikeY + bike.Height) && (hit == false))
            {
                score += 100; // take away 100 from score
                hit = true; //let hit know there has been a collision
                TimBike.Enabled = false; //disable timer
                bikeX = 950; //reset image to starting
            }

            //see if bullet hit bus
            if ((bulletX + bullet.Width > busX) && (bulletX < busX + bus.Width) && (bulletY + bullet.Height > busY) && (bulletY < busY + bus.Height) && (hit == false))
            {
                score += 100; // take away 100 from score
                hit = true; //let hit know there has been a collision
                TimBus.Enabled = false; //disable timer
                busX = 950; //reset image to starting
            }


            Invalidate();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            countdown--; //take one away from countdown
            score += 2; //add 2 to the score
            Invalidate();

        }

        private void timobstacle_Tick(object sender, EventArgs e)
        {
            obstacle = r.Next(1, 4); //choose random number for obstacle from 1 - 3
            lane = r.Next(1, 4); //choose randome number for lane from 1 - 3

            if (lane == 1)
            {
                lane2 = 315;  // if lane 1 is choosen set obstacle at that y
            }
            else if (lane == 2)
            {
                lane2 = 450; // if lane 2 is choosen set obstacle at that y
            }
            else
            {
                lane2 = 570; // if lane 3 is choosen set obstacle at that y 
            }

            if (obstacle == 1) // if obstactle 1 is choosen
            {
                if (TimBus.Enabled == true) //enable bus timer
                {
                    obstacle += 1; // add one to obstacle so can't get more than one image at once
                }
                else
                {
                    busX = 950; //starting position
                    busY = lane2; //set image in random lane
                    TimBus.Enabled = true; //enable bus timer
                }
            }
            else if (obstacle == 2)
            {
                if (TimBike.Enabled == true)
                {
                    obstacle += 1; // add one to obstacle so can't get more than one image at once
                }
                else
                {
                    bikeX = 950;  //starting position
                    bikeY = lane2; //set image in random lane
                    TimBike.Enabled = true; //enable bike timer
                }
            }
            else if (obstacle == 3)
            {
                if (TimTruck.Enabled == true)
                {
                    obstacle -= 1; // subtract one to obstacle so can't get more than one image at once
                }
                else
                {
                    truckX = 950; //starting position
                    truckY = lane2; //set image in random lane
                    TimTruck.Enabled = true; //enable truck timer
                }
            }


        }

        private void TimTruck_Tick(object sender, EventArgs e)
        {
            truckX -= 55; //take 55 away from trucks x

            if ((truckX + truck.Width) < 0) //check to see if image is offscreen
            {
                TimTruck.Enabled = false; //disable timer
                truckX = 950; //reset image
                truckY = 570;
            }
        }

        private void TimBike_Tick(object sender, EventArgs e)
        {
            bikeX -= 55; //take 55 away from bikes x

            if ((bikeX + bike.Width) < 0) //check to see if image is offscreen
            {
                TimBike.Enabled = false; //disable timer
                bikeX = 950; //reset image
                bikeY = 450;
            }
        }

        private void TimBus_Tick(object sender, EventArgs e)
        {
            busX -= 55; //take 55 away from bus's x

            if ((busX + bus.Width) < 0) //check to see if image is offscreen
            {
                TimBus.Enabled = false; //disable timer
                busX = 950; //reset image
                busY = 315;
            }
        }

        
    }
}