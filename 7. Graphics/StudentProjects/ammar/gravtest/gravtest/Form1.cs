using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

//Ammar Abolebdah


//Here is the link to my flowchart: http://www.gliffy.com/publish/2729585/

namespace gravtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       
        /// Variable Dictionary:
        /// score1, score2: keeps track of how many times each player has won
        /// on: is the game on
        /// lives1, lives2:keeps track of how many lives each player has
        /// damage1, damage2: keeps track of how much damage each player has accumulated
        /// smash1,smash2: how far each player is going to fly
        /// char1,char2:Placeholders right now, will eventually be used to select your character
        /// dir, dir2: Variables determining the direction the characters are movinh/facing
        /// move, move2:are the characters moving
        /// Vmove, Vmove2: the caracters vertical velocity
        /// plat, plat2: are the characters on the groung\d
        /// jump,jump2:have the characters used their mid-air jumps
        /// acount, acount2:counters used with the attack timer
        /// attack,attack2: are the characters attacking
        /// a/d/j/ldown: is the key in question pressed
        /// g,r:graphics and randomizer
        /// P1,P2: the image of the character that is being drawn
        /// waddle,waddl2: like char, they serve no purpose untill more characters are added
        /// waddles/m/a/b,hid(b):Images based on what the character is doing
        /// boom: sound effect for falling off the edge
        /// htp:dialog result variable, name comes form How To Play.
        /// P1x, psudoP1x, P1y: real and fake x co-ordinates and the y co-ordinate for P1. Fake used for the left attacking image 
        /// P2x, psudoP2x, P2y: real and fake x co-ordinates and the y co-ordinate for P2. Fake used for the left attacking image
        /// hid, hid2:is the character hiding
        /// countw = 1, countw2 = 1: counter for the walking animations
        /// pl, player, playerf,damage,damagef, lives, livesf: fonts and brushes for for the information at the bottom of the game.
        
        
        
        int score1 = 0, score2 = 0;
        bool on= false;
        Random r = new Random();
        int lives1 = 3, lives2 = 3;
        double damage1 = 0,damage2=0;
        int smash1=0,smash2=0;
        string char1 = "waddle";
        string char2 = "waddle";
        int dir = 1;
        int dir2 = -1;
        bool move = false;
        bool move2 = false;
        int Vmove,Vmove2;
        bool plat, plat2;
        bool jump,jump2;
        int acount = 0,acount2=0;
        bool attack = false,attack2 = false;
        bool adown = false, ddown = false;
        bool jdown = false, ldown = false;
        Graphics g;
        Rectangle[] platform = new Rectangle[5];
        Image P1;
        Image P2;
        Image bkg;
        Image waddle;
        Image waddl2;
        Image[] waddles = new Image[3];
        Image[] waddlesb = new Image[3];
        Image[] waddlem = new Image[7];
        Image[] waddlemb = new Image[7];
        Image hide, hideb;
        Image waddlea;
        Image waddleab;
        Image[] waddl2s = new Image[3];
        Image[] waddl2sb = new Image[3];
        Image[] waddl2m = new Image[7];
        Image[] waddl2mb = new Image[7];
        Image hide2, hid2b;
        Image waddl2a;
        Image waddl2ab;

        SoundPlayer boom = new SoundPlayer(); 

        int P1x, psudoP1x, P1y;
        int P2x, psudoP2x, P2y;
        bool hid,hid2;
        int countw = 1,countw2 = 1;


        DialogResult htp;
        
            
         SolidBrush pl = new SolidBrush(Color.Transparent);
         SolidBrush player = new SolidBrush(Color.Yellow);
         Font playerf = new Font("Comic sans ms", 24);
         SolidBrush Damage = new SolidBrush(Color.White);
         Font Damagef = new Font("Comic sans ms", 12);
         SolidBrush lives = new SolidBrush(Color.Red);
         Font livesf = new Font("Comic sans ms", 10);
        

        private void Form1_Load(object sender, EventArgs e)
        {
           // Load in the backround music and set it to loop
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Sounds\Bkg.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            //set the location and load the "boom" sound effect
            boom.SoundLocation=Application.StartupPath + @"\Sounds\Boom.wav";
            boom.LoadAsync();
           
            // give focus to the form
            this.Focus();
            
            //method to load in the images
            ImageLoad();

            //method to set all the values up
            Reset();

            //part of reset turns the game on, but the game hasn't started yet 
            on = false;

            //asking if you want to know how to play
            htp = MessageBox.Show("Do you want to know how to play?", "Are you new?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if yes
            if (htp == DialogResult.Yes)
            {
                // give the instructions
                MessageBox.Show("Hello, and welcome to Super Smash Bros. ICS 3U1 edition");
                MessageBox.Show("This is a two player game so grab a friend and have fun!");
                MessageBox.Show("The object of this game is simple, knock your opponent out of the stage 3 times");
                MessageBox.Show("Player 1 uses WASD and C, and player 2 uses IJKL and . ."+ Environment.NewLine +"They are jump, left, duck, right and attack respectivly.");
                MessageBox.Show("The more damage you take, the further back you are pushed when you are hit");
                MessageBox.Show("Ducking reduces how far you are knocked back.");
                MessageBox.Show("The white number is damage recieved, the red number is the number of lives left.");
                MessageBox.Show("P pauses the game.");
                MessageBox.Show("Good luck and Have fun!");
            }
            on = true;

        }

        private void bfPnl1_Paint(object sender, PaintEventArgs e)
        {
            // use the panel graphics
            g = e.Graphics;

            //Draw everything
            Draw(g);
        }

        private void Gravity_Tick(object sender, EventArgs e)
        {
            //if the game is on
            if (on == true)
                //raise the downwards velocity by 4
                Vmove += 4;
        }

        private void Motion_Tick(object sender, EventArgs e)
        {
            //if the game is on 
            if (on == true)
            {
                //set the platform values to false
                plat = false;
                plat2 = false;

                //check if fallen off the edge
                if (P1y + P1.Height >= pnlgame.Height)
                {
                    //if so restet location values, pplay the boom and decrease the number of lives by one
                    P1x = (pnlgame.Width / 2) - 75;
                    P1y = -P1.Height;
                    Vmove = 0;
                    jump = true;
                    Gravity.Enabled = false;
                    lives1--;
                    damage1 = 0;
                    boom.Play();
                    smash1 = 0;
                }

                //check and repeat for player two
                if (P2y + P2.Height >= pnlgame.Height)
                {
                    P2x = (pnlgame.Width / 2) + 55;
                    P2y = -P2.Height;
                    Vmove2 = 0;
                    jump2 = false;
                    Gravity2.Enabled = false;
                    lives2--;
                    damage2 = 0;
                    boom.Play();
                    smash2 = 0;
                }

                //for all the platforms
                for (int i = 1; i <= 4; i++)
                {
                    //check if colided with the bottom of the platform
                    if (P1y <= platform[i].Y + platform[i].Height)
                    {
                        if (psudoP1x + P1.Width > platform[i].X && psudoP1x < platform[i].X + platform[i].Width)
                        {
                            if (P1y + P1.Height > platform[i].Y)
                            {
                                //if so, set vertical speed to zero and move down 
                                Vmove = 0;
                                P1y += 1;
                            }

                        }
                    }
                    // if colided with the top of the platform
                    if (P1y < platform[i].Y)
                    {
                        if (psudoP1x + P1.Width > platform[i].X && psudoP1x < platform[i].X + platform[i].Width - 5)
                        {
                            if (P1y + P1.Height > platform[i].Y)
                            {
                                //allign player with the platform and turn off gravity, and set vertical velocity to zero
                                P1y = platform[i].Y - P1.Height;
                                Vmove = 0;
                                jump = false;
                                Gravity.Enabled = false;

                            }
                            //set plat to true if alligned with the platform
                            if (P1y == platform[i].Y - P1.Height)
                                plat = true;
                        }
                    }



                }
                //if not on a platform
                if (!plat)
                {
                    // turn gravity on
                    Gravity.Enabled = true;
                }

                // move the vertical velocity variable
                P1y += Vmove;

                // if neither movement keys are pressed 
                if (adown == false && ddown == false)
                {
                    //stop moving
                    move = false;
                }

                //if not hiding and not attacking
                if (!hid & !attack)
                {
                    //if moving
                    if (move)
                        //move in the current direction 4 pixles
                        P1x += dir * 4;
                }
                
                
                
                //repeat for player 2
                for (int i = 1; i <= 4; i++)
                {
                    if (P2y <= platform[i].Y + platform[i].Height)
                    {
                        if (psudoP2x + P2.Width > platform[i].X && psudoP2x < platform[i].X + platform[i].Width)
                        {
                            if (P2y + P2.Height > platform[i].Y)
                            {
                                Vmove2 = 0;
                                P2y += 1;
                            }

                        }
                    }
                    if (P2y < platform[i].Y)
                    {
                        if (psudoP2x + P2.Width > platform[i].X && psudoP2x < platform[i].X + platform[i].Width - 5)
                        {
                            if (P2y + P2.Height > platform[i].Y)
                            {
                                P2y = platform[i].Y - P2.Height;
                                Vmove2 = 0;
                                jump2 = false;
                                Gravity2.Enabled = false;

                            }
                            if (P2y == platform[i].Y - P2.Height)
                                plat2 = true;
                        }
                    }



                }
                if (!plat2)
                {
                    Gravity2.Enabled = true;
                }

                P2y += Vmove2;

                if (jdown == false && ldown == false)
                {
                    move2 = false;
                }
                if (!hid2 & !attack2)
                {
                    if (move2)
                        P2x += dir2 * 4;
                }

                
            }
            //redraw the panel
            pnlgame.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if the game is on
            if (on == true)
            {
                //if not attacking
                if (!attack)
                {
                    //if W is pressed
                    if (e.KeyCode == Keys.W)
                    {
                        //if on a platform
                        if (plat)
                        {
                            //enable gravity and make vertical velocity 9 up
                            Gravity.Enabled = true;
                            Vmove = -9;
                        }

                            // else if mid-air jump is not used
                        else if (!jump)
                        {
                            //reset gravity, make V Velocity 9 up, and turn mid air jump to true
                            Gravity.Enabled = false;
                            Vmove = -9;
                            jump = true;
                            Gravity.Enabled = true;
                        }
                    }
                    //if d is pressed
                    if (e.KeyCode == Keys.D)
                    {
                        //direction becomes 1(right) movement and d pressed become true
                        dir = 1;
                        move = true;
                        ddown = true;
                    }
                    //if A is pressed
                    if (e.KeyCode == Keys.A)
                    {
                        //direction becomes -1(left) movement and a pressed become true
                        adown = true;
                        dir = -1;
                        move = true;

                    }

                    //if S is pressed
                    if (e.KeyCode == Keys.S)
                    {
                        //turn hide to true and align bottom of image
                        hid = true;
                        P1y += 15;
                    }

                    //if C is pressed
                    if (e.KeyCode == Keys.C)
                    {
                        // turn attack to true, attackcount to 0, and allign to fake and real x value
                        attack = true;
                        acount = 0;
                        psudoP1x = P1x;

                        // if facing left
                        if (dir == -1)
                            // lower fake x by 30, to allign the attack image with the feet of the standing image
                            psudoP1x -= 30;
                    }
                }
                
                //repeat for player two, using the keys outlined in the tutorial
                if (!attack2)
                {

                    if (e.KeyCode == Keys.I)
                    {
                        if (plat2)
                        {

                            Gravity2.Enabled = true;
                            Vmove2 = -9;
                        }

                        else if (!jump2)
                        {
                            Gravity2.Enabled = false;
                            Vmove2 = -9;
                            jump2 = true;
                            Gravity2.Enabled = true;
                        }
                    }
                    if (e.KeyCode == Keys.L)
                    {
                        dir2 = 1;
                        move2 = true;
                        ldown = true;
                    }
                    if (e.KeyCode == Keys.J)
                    {
                        jdown = true;
                        dir2 = -1;
                        move2 = true;

                    }
                    if (e.KeyCode == Keys.K)
                    {
                        hid2 = true;
                        P2y += 10;
                    }

                    if (e.KeyCode == Keys.OemPeriod)
                    {
                        attack2 = true;
                        acount2 = 0;
                        psudoP2x = P2x;

                        if (dir2 == -1)
                            psudoP2x -= 30;
                    }
                }


            
            }
            // if P is pressed
            if (e.KeyCode == Keys.P)
            {
                //if the game is not over (both players are still alive
                if (lives1 != 0 && lives2 != 0)
                    //flip the value of on
                    on = !on;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        
            //if a is let go
            if (e.KeyCode == Keys.A)
                //a pressed becomes false
                adown = false;

            // if d is let go
            if (e.KeyCode == Keys.D)
                //d pressed = false
                ddown = false;

            //if s is let go
            if (e.KeyCode == Keys.S)
                //stop hiding
                hid = false;

            // repeat for player 2 using keys givin in tutorial

            if (e.KeyCode == Keys.J)
                jdown = false;

            if (e.KeyCode == Keys.L)
                ldown = false;

            if (e.KeyCode == Keys.K)
                hid2 = false;
        }

        private void WaddleAnimation_Tick(object sender, EventArgs e)
        {
            // if the game is on
            if (on == true)
            {
                //raise the counter
                countw++;

                //if standing still...
                if (move == false && hid == false && jump == false)
                {
                    if (dir == 1)
                        waddle = waddles[1];

                    else if (dir == -1)
                        waddle = waddlesb[1];

                }

                // if moving... 
                if (move == true)
                {
                    //if the counter is over 42, set it back to one
                    if (countw > 42)
                        countw = 1;

                    // if the counter is evenly divisable by 7
                    if (countw % 7 == 0)
                    {
                        //check the direction, and load the correct image based on the counter
                        if (dir == 1)
                            waddle = waddlem[countw / 7];

                        else if (dir == -1)
                            waddle = waddlemb[countw / 7];
                    }
                }

                //if hiding...
                if (hid == true)
                {

                    //check the direction and load the correct image.
                    if (dir == 1)
                    {
                        waddle = hide;

                    }
                    else if (dir == -1)
                    {
                        waddle = hideb;

                    }
                }
                 //if not moving or hiding and in mid air
                if (!move & !plat & !hid)
                {
                    //check the direction and load the correct image based on direction

                    if (dir == 1)
                        waddle = waddles[2];

                    else if (dir == -1)
                        waddle = waddlesb[2];


                }

                //if mis-air jump is used
                if (jump)
                {
                    //check the direction and load the correct image

                    if (dir == 1)
                        waddle = waddles[2];

                    else if (dir == -1)
                        waddle = waddlesb[2];
                }

                //if attacking
                if (attack)
                {
                    //check the direction and load the correct image
                    if (dir == 1)
                        waddle = waddlea;

                    else if (dir == -1)
                        waddle = waddleab;


                }
                //repeat for player 2

                //raise the counter
                countw2++;

                //if standing still...
                if (move2 == false && hid2 == false && jump2 == false)
                {
                    if (dir2 == 1)
                        waddl2 = waddl2s[1];

                    else if (dir2 == -1)
                        waddl2 = waddl2sb[1];

                }

                // if moving... 
                if (move2 == true)
                {
                    //if the counter is over 42, set it back to one
                    if (countw2 > 42)
                        countw2 = 1;


                    if (countw2 % 7 == 0)
                    {
                        //check the direction, and load the correct image based on the counter
                        if (dir2 == 1)
                            waddl2 = waddl2m[countw2 / 7];

                        else if (dir2 == -1)
                            waddl2 = waddl2mb[countw2 / 7];
                    }
                }

                //if hiding...
                if (hid2 == true)
                {

                    //check the direction and load the correct image.
                    if (dir2 == 1)
                    {
                        waddl2 = hide2;

                    }
                    else if (dir2 == -1)
                    {
                        waddl2 = hid2b;

                    }
                }

                if (!move2 & !plat2 & !hid2)
                {
                    if (dir2 == 1)
                        waddl2 = waddl2s[2];

                    else if (dir2 == -1)
                        waddl2 = waddl2sb[2];


                }

                if (jump2)
                {
                    if (dir2 == 1)
                        waddl2 = waddl2s[2];

                    else if (dir2 == -1)
                        waddl2 = waddl2sb[2];
                }

                if (attack2)
                {
                    if (dir2 == 1)
                        waddl2 = waddl2a;

                    else if (dir2 == -1)
                        waddl2 = waddl2ab;


                }

                if (!attack)
                    psudoP1x = P1x;

                if (!attack2)
                    psudoP2x = P2x;


                if (char1 == "waddle")
                    P1 = waddle;

                if (char2 == "waddle")
                    P2 = waddl2;



            }
        }
        private void Draw(Graphics g)
        {
            //error prevention
            if (P1 != null & P2 != null)
            {
                //draw the backround
                g.DrawImage(bkg, 0, 0);

                //draw the players using the fake x values
                g.DrawImage(P1, psudoP1x, P1y);
                g.DrawImage(P2, psudoP2x, P2y);

                //draw the platforms
                for (int i = 1; i <= 4; i++)
                {
                    g.FillRectangle(pl, platform[i]);
                }

                //draw the information about the game at the bottom
                g.DrawString("P1", playerf, player, 200, pnlgame.Height - 100);
                g.DrawString("P2", playerf, player, pnlgame.Width - 230, pnlgame.Height - 100);
                g.DrawString((damage1 * 100).ToString() + "%", Damagef, Damage, 205, pnlgame.Height - 65);
                g.DrawString((damage2 * 100).ToString() + "%", Damagef, Damage, pnlgame.Width-220, pnlgame.Height - 65);
                g.DrawString(lives1.ToString(), livesf, lives, 230, pnlgame.Height - 50);
                g.DrawString(lives2.ToString(), livesf, lives, pnlgame.Width-195, pnlgame.Height - 50);

                //if the game is not on, and both players are still alive, Write Paused in the middle of the screen
                if (!on & lives2 != 0 & lives1 != 0)
                    g.DrawString("Paused", playerf, lives, pnlgame.Width / 2 - 50, pnlgame.Height / 2);
            }
        }

        private void Wattack_Tick(object sender, EventArgs e)
        {

            //if the game is on
            if (on == true)
            {
                //if attacking
                if (attack)
                    //raise attacking counter(acount)
                    acount++;

                //when acount = 3
                if (acount == 3)
                {
                    // check for colisions
                    if (P1y + P1.Height > P2y & P1y < P2y + P2.Height)
                    {
                        if (dir == 1)
                        {
                            if (P1x + P1.Width > P2x && P1x < P2x + P2.Width + 5)
                            {
                                // increase the damage by a random amount
                                damage2 += r.Next(8, 13) / 100.0;
                                //and raise the how far hit value
                                smash2 = (int)(25 * damage2);

                                if (hid2)
                                    smash2 /= 2;

                            }

                        }
                            //repeat for opposite direction
                        else if (dir == -1)
                        {

                            if (psudoP1x < P2x + P2.Width && psudoP1x + P1.Width > P2x)
                            {
                                damage2 += r.Next(8, 13) / 100.0;
                                smash2 = (int)(-25 * damage2);

                                if (hid2)
                                    smash2 /= 2;

                            }
                        }
                    }
                }
                //when attackcount reaches 25
                if (acount == 25)
                    //attacking becomes false
                    attack = false;



                //repeat for P2

                if (attack2)
                    acount2++;

                if (acount2 == 3)
                {
                    if (P2y + P2.Height > P1y & P2y < P1y + P1.Height)
                    {
                        if (dir2 == 1)
                        {
                            if (P2x + P2.Width > P1x && P2x < P1x + P1.Width + 5)
                            {
                                damage1 += r.Next(8, 13) / 100.0;
                                smash1 = (int)(25 * damage1);

                                if (hid)
                                    smash1 /= 2;

                            }

                        }
                        else if (dir2 == -1)
                        {

                            if (psudoP2x < P1x + P1.Width && psudoP2x + P2.Width > P1x)
                            {
                                damage1 += r.Next(8, 13) / 100.0;
                                smash1 = (int)(-25 * damage1);

                                if (hid)
                                    smash1 /= 2;
                            }
                        }
                    }
                }
                if (acount2 == 25)
                    attack2 = false;

            }
        }
        private void ImageLoad()
        {
            //load in the backround image
            bkg = Image.FromFile(Application.StartupPath + @"\Images\bkg.jpg");

            //Load in waddle dee images

            //attack images
            waddlea = Image.FromFile(Application.StartupPath + @"\Images\Waddle\attack1.gif");
            waddleab = Image.FromFile(Application.StartupPath + @"\Images\Waddle\attack-1.gif");


            for (int i = 1; i <= 6; i++)
            {
                //loading in moving images
                waddlem[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle\walk1" + i.ToString() + ".gif");
                waddlemb[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle\walk-1" + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 2; i++)
            {
                //loading in standing/jumping images
                waddles[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle\stand1" + i.ToString() + ".gif");
                waddlesb[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle\stand-1" + i.ToString() + ".gif");
            }
            //loading in hiding images
            hide = Image.FromFile(Application.StartupPath + @"\Images\Waddle\hide1.gif");
            hideb = Image.FromFile(Application.StartupPath + @"\Images\Waddle\hide-1.gif");

          
            //Player 2 Images
            
            
            //attack images
            waddl2a = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\attack1.gif");
            waddl2ab = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\attack-1.gif");


            for (int i = 1; i <= 6; i++)
            {
                //loading in moving images
                waddl2m[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\walk1" + i.ToString() + ".gif");
                waddl2mb[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\walk-1" + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 2; i++)
            {
                //loading in standing/jumping images
                waddl2s[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\stand1" + i.ToString() + ".gif");
                waddl2sb[i] = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\stand-1" + i.ToString() + ".gif");
            }
            //loading in hiding images
            hide2 = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\hide1.gif");
            hid2b = Image.FromFile(Application.StartupPath + @"\Images\Waddle2\hide-1.gif");


           


        }

        private void Smash_Tick(object sender, EventArgs e)
        {
            //if the game is on
            if (on == true)
            {
                //the fake and real x values are increased by the smash distance
                P2x += smash2;
                psudoP2x += smash2;

                P1x += smash1;
                psudoP1x += smash1;

                //the smash distance for both players is brought closer to zero
                if (smash2 > 0)
                    smash2--;

                if (smash2 < 0)
                    smash2++;

                if (smash1 > 0)
                    smash1--;

                if (smash1 < 0)
                    smash1++;

                //if player one is dead
                if (lives1 == 0)
                {
                    //turn the game off
                    on = false;
                    //raise player two's score
                    score2++;
                    //congratulate player two
                    MessageBox.Show("Player Two Wins!", "Congrats Player 2!");
                    //display the scores and ask for a rematch
                    htp = MessageBox.Show("The score is currently: " + Environment.NewLine + score1.ToString() + "(P1) - " + score2.ToString() + "(P2)" + Environment.NewLine + "Rematch?", "Score", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //if they are rematching
                    if (htp == DialogResult.Yes)
                        //run reset again
                        Reset();
                    else
                        //if not, quit
                        Application.Exit();
                }
               
                //if player 2 is dead
                if (lives2 == 0)
                {
                    //do the same thing, just flip the players
                    on = false;
                    score1++;
                    MessageBox.Show("Player One Wins!", "Congrats Player 1!");
                    htp = MessageBox.Show("The score is currently: " + Environment.NewLine + score1.ToString() + "(P1) - " + score2.ToString() + "(P2)" + Environment.NewLine + "Rematch?", "Score", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (htp == DialogResult.Yes)
                        Reset();
                    else
                        Application.Exit();
                }

            }
            
        }

        private void Gravity2_Tick(object sender, EventArgs e)
        {
            //if the game is on
            if (on)
                //accelerate 4 downwards
                Vmove2 += 4;
        }

        private void Reset()
        {
            //set the x co-ordinates
            P1x = 100;
            P2x = pnlgame.Width - 100;

            //set the fake x co-ordinates
            psudoP1x = P1x;
            psudoP2x = P2x;

            //set vertical velocity to zero
            Vmove = 0;
            Vmove2 = 0;

            //set the y co-ordinates
            P1y = pnlgame.Height - 230;
            P2y = P1y;

            //create the platforms
            platform[1] = new Rectangle(20, pnlgame.Height - 190, pnlgame.Width - 45, 20);
            platform[2] = new Rectangle(88, pnlgame.Height - 280, 138, 11);
            platform[3] = new Rectangle(pnlgame.Width - 88 - 130, pnlgame.Height - 280, 138, 11);
            platform[4] = new Rectangle(pnlgame.Width / 2 - 63, pnlgame.Height - 370, 138, 11);

            //reset the lives, damage, smash distance, direction, movement,keys pressed, hiding, and counters
            lives1 = 3; lives2 = 3;
            damage1 = 0;damage2=0;
            smash1 = 0; smash2 = 0;
            dir = 1;
            dir2 = -1;
            move = false;
            move2 = false;
            jump=false; jump2= false;
            acount = 0; acount2 = 0;
            attack = false; attack2 = false;
            adown = false; ddown = false;
            jdown = false; ldown = false;
            hid = false; hid2 = false;
            countw = 1; countw2 = 1;
            //turn the game on
            on = true;

            //set the initial images
            if (char1 == "waddle")
                P1 = Image.FromFile(Application.StartupPath + @"\Images\Waddle\stand11.gif");

            if (char2 == "waddle")
                P2 = waddlesb[1];

        }
     

        

    }
    //Creating a doublebuffered panel class
    class BfPnl : Panel
    {
        public BfPnl()
        {
            this.DoubleBuffered = true;
        }
    }
}