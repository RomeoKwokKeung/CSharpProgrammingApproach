using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Dyztopia
{
    public partial class FrmLevel2 : Form
    {
        public FrmLevel2()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        
        }

        //Image array used for falling objects
        Image[] enemy = new Image[11];

        //Image array used for the bullet
        Image missile = Image.FromFile(Application.StartupPath + @"\MISSILE.gif");

        //Image array used for the explosion gif
        Image explosive = Image.FromFile(Application.StartupPath + @"\Explosion.gif");

        //Image array used for background
        Image background = Image.FromFile(Application.StartupPath + @"\background2.jpg");

        //Plane Image
        Image planeleft = Image.FromFile(Application.StartupPath + @"\planeleft.gif");
        Image planecentre = Image.FromFile(Application.StartupPath + @"\planecentre.gif");
        Image planeright = Image.FromFile(Application.StartupPath + @"\planeright.gif");


        int x, y;        //position of ship at the bottom of the screen

        //array used for target positions of falling objects
        int[] tx = new int[11];
        int[] ty = new int[11];

        //array used for target speeds
        int[] tdx = new int[11];
        int[] tdy = new int[11];


        //variables used for the missile image, and missile speeds
        int mx, my;
        int mdy;

        int count;

        //Image array used for the enemy's bullet
        Image[] bullet = new Image[11];


        // used for enemy bullet's X and Y value along with its speed
        int[] enemyfirex =new int[11];
        int[] enemyfirey =new int[11];
        int enemyfiredy;

        // used for the total score
        int score;
        // variable used for assigning hitpoints value
        int hitpoints = 100;
        // used for setting parameters
        int standard = 5;

        //When true, starts game
        bool start = true;
        //Bool used to check if the falling objects have hit
        bool[] hit = new bool[11];
        //Bool used to check if enemy attack takes place
        bool enemycontact = false;

        bool[] collision = new bool[11];

        //counter used for countdown in game
        int countdown;

        //Random graphics class
        Random r = new Random();

        // Sound file classes
        SoundPlayer explosion = new SoundPlayer();
        SoundPlayer backgroundmusic = new SoundPlayer();
        SoundPlayer gun = new SoundPlayer();
        SoundPlayer hitt = new SoundPlayer();

        

        //Method for drawing images
        private void DrawStuff(Graphics gr)
        {

            // Creates a brush
            Font font = new Font("Arial", 9, FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.Silver);

            //Creates a brush for writing game over messages
            Font GameOverfont = new Font("Arial", 40, FontStyle.Bold);
            SolidBrush blueBrush = new SolidBrush(Color.Lime);

            //Draws background onto form and stretches it to fit form height/ width
            gr.DrawImage(background, 0, 0, this.Width, this.Height);


            gr.DrawString("Please see help menu for instructions", font, yellowBrush, 200, 25);

            //Displays current score and time left in current game
            gr.DrawString("Current Score -> " + score.ToString(), font, yellowBrush, 5, 40);
            gr.DrawString("Time Left -> " + countdown.ToString(), font, yellowBrush, 5, 30);

            //Draws ship onto form
            gr.DrawImage(planecentre, x, y);

            //Loop for objects that are falling in the game
            for (int i = 1; i <= 10; i++)
            {

                gr.DrawImage(enemy[i], tx[i], ty[i]);

                //Draws bullets onto form for user or enemies to shoot
                gr.DrawImage(missile, mx, my);
                gr.DrawImage(bullet[i], enemyfirex[i], enemyfirey[i]);

                //Checks if enemies are hit by user bullets
                if (hit[i])
                {
                    //Draw explosion image and play explosion sound
                    gr.DrawImage(explosive, tx[i], ty[i]);
                    explosion.Play();


                    Initialize(i);

                }
                //if the countdown for the game runs out
                if (countdown <= 0)
                {
                    //Draws messages for user to read
                    gr.DrawString("Win!", GameOverfont, blueBrush, ClientSize.Width / 2 - 200, ClientSize.Height / 2);
                    gr.DrawString("Press the Start Button to Play Again or --> to move on to next level", font, yellowBrush, ClientSize.Width / 2 - 200, ClientSize.Height / 2 + 60);
                    //Calls up method which stops the game and sets everything back to 0

                    StopGame();


                    //Disables background music when countdown times out
                    axWindowsMediaPlayer1.URL = null;

                }
                if (hitpoints <= 0)
                {
                    hitpoints = 0;
                    StopGame();
                    BtnStart.Text = "Start";
                    menuStrip.Enabled = true;
                    gr.DrawString("You have died. Nice Try. Play Again?", font, blueBrush, ClientSize.Width / 2 - 200, ClientSize.Height / 2 + 60);
                }

            }

        }

        private void FrmLevel2_Load(object sender, EventArgs e)
        {
            //Turns bool for hit to false until activated when an object is hit
            for (int i = 1; i <= 10; i++)
            {
                hit[i] = false;
                collision[i] = false;
            }
            //Sets countdown to 60 and score to 0 whenever the game begins
                score = 0;
            countdown = 60;

            //Positions targets in corner until the start button is pressed
            for (int i = 1; i <= 10; i++)
            {
                tx[i] = r.Next(5,500);
                ty[i] = 5;  
            }

            mx = ClientSize.Width + 100;   //position bullet offscreen until needed
            my = ClientSize.Height + 100;



            //Array used for falling ships
            for (int i = 1; i <= 10; i++)
            {
                enemy[i] = Image.FromFile(Application.StartupPath + @"\enemy.gif");
            }

            for (int i = 1; i <= 10; i++)
            {
                bullet[i] = Image.FromFile(Application.StartupPath + @"\bullet.gif");
            }



           

            //Positions x and y value of the plane when starting the game
            x = ClientSize.Width / 2;
            y = ClientSize.Height - planecentre.Height;

            
            //Locates locations of each different sound in debug folder

            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            backgroundmusic.SoundLocation = Application.StartupPath + @"\Contact.mp3";
            gun.SoundLocation = Application.StartupPath + @"\gun.wav";
            hitt.SoundLocation = Application.StartupPath + @"\hit.wav";

            //Loads sounds
            explosion.LoadAsync();
            hitt.LoadAsync();
            gun.LoadAsync();


            
            //Focuses form
            this.Focus();

            //Starts the game
       
            }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (BtnStart.Text == "Start")
            {
                //Calls up a method to start the game
                NewGame();
                
                hitpoints = 100;
                //Enables timer for the game
                
                timGame.Enabled = true;              
                timImage.Enabled = true;
                timShot.Enabled = true;
                //changes start button text to stop while the game is playing
                BtnStart.Text = "Stop";
                
                //Makes media player invisible while playing the game and disables menu as well
                axWindowsMediaPlayer1.Visible = false;
                menuStrip.Enabled = false;
                axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Contact.mp3";
                
            }
            else
     
            {
                //Stops game and resets (calls up method)
                StopGame();
                BtnStart.Text = "Start";
                menuStrip.Enabled = true;
                
            }
        }

        private void Initialize(int n)
        {
            
            //Disables hits and collision until it checks for them later
            for (int i = 1; i <= 10; i++)
            {
                hit[i] = false;
                collision[i] = false;
                count = 1;

                //Game has started
                if (start)
                {
                    //Randomly positions targets at a new position after each death
                    tx[i] = r.Next(1, 700) - 200;
                    ty[i] = 5;  //position target offscreen until start button pressed

           //Randomly choooses a speed for the falling objects
                    tdx[i] = r.Next(9) + 5;
                    tdy[i] = r.Next(9) + 5;

                    mx = ClientSize.Width + 100;   //position bullet offscreen until needed
                    my = ClientSize.Height + 100;

                    //don't move bullet until W or left mouse are pressed
                    mdy = 0;                  
                }
                    // Used to reset the objects after they have been killed and the game has already begun
                else
                {
                    //Randomly positions targets at a new position after they are killed
                    tx[n] = r.Next(1, 700) - 200;
                    ty[n] = 5;  
                    //Random speed of targets
                    tdx[n] = r.Next(9) + 5;
                    tdy[n] = r.Next(9) + 5;

                    mx = ClientSize.Width + 100;   //position bullet offscreen until needed
                    my = ClientSize.Height + 100;

                    //don't move bullet until W or left mouse are pressed
                    mdy = 0;

                }
                
            }
        }
        
        private void NewGame()
        {
            //Sets counters
            score = 0;
            countdown = 60;
            //Resets health to 100 after game over
            hitpoints = 100;
           //Plays background music
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\contact.mp3";
            //Disables next level until the current level has been beaten
            Btnadvance.Enabled = false;

            //Calls up initialize for the array standard (containing 5 falling objects)
            Initialize(standard);
            //Disables start
            start = false;
        }

        private void StopGame()
        {
            //Disables all timers
            timGame.Enabled = false;
            timImage.Enabled = false;           
            timShot.Enabled = false;
            
            //closes media player and disables background music
            
            axWindowsMediaPlayer1.close();
            //Re-Enables advance button
            Btnadvance.Enabled = true;

        }


            

        private void FrmLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && x <= 795)
            {
                x += 20;

            }
            //Moves plane left
            else if (e.KeyCode == Keys.A && x >= 5)
            {
                x -= 20;
            }
            //Shoots missile
            else if (e.KeyCode == Keys.W && my >= 500)
            {
                mx = x + 10;
                my = y - 10;
                mdy = -5;
                gun.Play();
            }
            Invalidate();
        }

        private void timShot_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Bullet speed
                my += mdy;
                //Sets X and Y values to travel at a designated speed
                tx[i] += tdx[i];
                ty[i] += tdy[i];

                //if bullet reaches top without hitting target
                //move it off screen
                if (my <= 0)
                {
                    mdy = 0;
                    mx = ClientSize.Width + 100;
                    my = ClientSize.Height + 100;
                }
                //Makes target move in a different direction if it hits the wall of the form
                if (tx[i] > ClientSize.Width - enemy[i].Width)
                    tdx[i] = -tdx[i];
                //Makes target move different direction once it hits the top of the form
                if (tx[i] < 0)
                    tdx[i] = -tdx[i];

                if (ty[i] < 0)
                    tdy[i] = -tdy[i];
                //Makes target move in a different direction once it hits the bottom of the form
                if (ty[i] > ClientSize.Height - enemy[i].Height)
                    tdy[i] = -tdy[i];

                //Check for hit
                if ((mx + bullet[i].Width > tx[i]) && (mx < tx[i] + enemy[i].Width) && (my + bullet[i].Height > ty[i]) && (my < ty[i] + enemy[i].Height) && (hit[i] == false))
                {
                    //Add to score if hit
                    score += 100;
                    //Set bool to true
                    hit[i] = true;
                }
                //Refresh
                Invalidate();
            }

            for (int i = 1; i <= 10; i++)
            {
                // check if falling object [i] has hit user with a bullet
                if ((enemyfirex[i] <= x + planecentre.Width) && (enemyfirex[i] >= x) && (enemyfirey[i] + bullet[i].Height >= y) && (enemyfirey[i] <= ClientSize.Height))
                {
                    //Take hitpoints away when plane has been hit by bullet

                    hitpoints -= 25;
                    hitt.Play();
                    enemyfirey[i] = 100;
                    if (hitpoints <= 0)
                    {
                        hitpoints = 0;
                        enemyfirex[i] = 100;
                        StopGame();
                        BtnStart.Text = "Start";
                        menuStrip.Enabled = true;
                    }

                }
                //Checks for collision by means of falling object hitting plane
                //Checks for collision by means of falling object hitting plane
                else if ((tx[i] <= x + planecentre.Width) && (tx[i] >= x) && (ty[i] + enemy[i].Height >= y) && (collision[i] == false))
                {
                    //Makes sure that each object only hits the plane once upon colliding
                    collision[i] = true;
                    hitpoints -= 25;
                    hitt.Play();
                    //Checks if hitpoints have hit 0
                    if (hitpoints <= 0)
                    {
                        hitpoints = 0;
                        enemyfirex[i] = 100;
                        StopGame();
                        BtnStart.Text = "Start";
                        menuStrip.Enabled = true;
                    }

                }


            }

            Invalidate();   //refreshes screen otherwise image wont change
        }

        private void timGame_Tick(object sender, EventArgs e)
        {
            countdown--;

            //Sets progress bar value to hitpoints variable
            progressBar1.Value = hitpoints;

            //Refresh
            Invalidate();

        }

        private void Btnadvance_Click(object sender, EventArgs e)
        {
            Frmlevel3 x = new Frmlevel3();
            x.ShowDialog();
        }

        private void timImage_Tick_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Sets bool to true (enemies are now attacking)
                enemycontact = true;
                enemyfirex[i] = tx[i] + 10;
                enemyfirey[i] = ty[i] + 10;
            }
            enemyfiredy = 20;
            
        }

        private void FrmLevel2_Paint(object sender, PaintEventArgs e)
        {
            //Graphics class
            Graphics gr = e.Graphics;
            //Variable used to be stored in method to draw images

                DrawStuff(gr);


            
        }

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlevel3 x = new Frmlevel3();
            x.ShowDialog();
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLevel2 x = new FrmLevel2();
            x.ShowDialog();

        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDyztopia x = new FrmDyztopia();
            x.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In order to play, the A and D keys are used to move left and right.  Press start to begin the game."
+ " You gain points by shooting down the enemies while staying alive." + " You move on if you manage to" + " survive the full minute.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (enemycontact)
            {

            for (int l = 1; l <= 10; l++)
            {
                //Makes sure the Y value of the bullet travels at designated speed
                enemyfirey[l] += enemyfiredy;

            }
            }
        }
        
        }
   }

    

