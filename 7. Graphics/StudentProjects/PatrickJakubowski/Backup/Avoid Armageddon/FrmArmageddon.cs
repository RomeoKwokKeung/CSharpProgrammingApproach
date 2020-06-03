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

/// _____________________________________________________________________________
/// _____________________________________________________________________________
///                                       ___
///  \    /  __  __     __   __       __  |  |    __ ___    __        __  __
///   \  /  |__| |_| | |__| |__| |   |__  |  | | |    |  | |  | |\ | |__| |_| \ /
///    \/   |  | | \ | |  | |__| |__ |__  |__| | |__  |  | |__| | \| |  | | \  |
/// _____________________________________________________________________________
/// _____________________________________________________________________________
/// 
/// -----------------------------Global Variables--------------------------------
/// 
/// GblDifficulty is used to obtain the difficulty set in the splash screen
/// GblMusic is used to obtain the sound preferences set in the splash screen
/// 
/// -----------------------------Startup Variables-------------------------------
/// 
/// LocalMusic is used to determine the sound preferences
/// LocalDifficulty is used to determine the difficulty set
/// 
/// -----------------------------General Variables-------------------------------
/// 
/// g is used to create graphics
/// r is used to randomize intergers
/// 
/// Health is used to determine the amount of HP left, and to determine which
/// picture to display health is used.  One way of ending the game
/// 
/// Wormx is used to determine where the worm is on the X axis
/// 
/// CountL is used to determine which picture to display for moving left
/// CountR is used to determine which picture to display for moving right
///
/// Counter is used to determine which picture to display for skipping
///
/// Game is used to determine whether the game has started or ended
/// 
/// MoveLeft is used to determine which picture to draw in the weapon timer
/// MoveRight is used to determine which picture to draw in the weapon timer
/// 
/// WeaponSlotStatus is used to determine whether a weapon has been created
/// WeaponSlotSpeed is used to determine what speed a weapon has in a
/// certain slot
/// WeaponSlotType is used to determine what weapon to draw for each slot
/// WeaponPosX is used to determine the X position of each slot
/// WeaponPosY is used to determine the Y position of each slot
/// WeaponAmount is used to control how many weapons are falling.  This
/// also can be used to change difficulties
/// 
/// BulletX is used to determine the X position of the bullet
/// BulletY is used to determine the Y position of the bullet
/// BulletSpeed is used to determine how fast the bullet moves
/// BulletStatus is used to determine whether the bullet is present.
/// 
/// Levelcount is used to determine the wave the user is on
/// Score is used to determine the score based on the time played
/// TickTime is a time variable that allows for a timer without using ticks
/// StartTime is a time variable that when compared to TickTime, allows for
/// the use of timers directly in code
/// Total Score is used to determine the total score, both time and damage
/// dodged
/// 
/// ----------------------------------Pictures-----------------------------------
/// 
/// FormBackground is the background of the playing field
/// 
/// Weapon is the pictures of the falling weapons
/// 
/// Bullet is the picture of the bullet
/// 
/// Lifebar is 25 pictures of the health bar at various increments
/// 
/// Grave is pictures of graves for when you die
/// 
/// WalkLeft is pictures of the worm moving left
/// WalkRight is pictures of the worm moving right
/// Skip is pictures of the worm skipping before the game begins
/// 
/// -----------------------------------Sounds------------------------------------
/// 
/// BackgroundMusic is the background music present in the game
/// Explosion is the explosion noise
/// Ow is the noise made when hit
/// Victory is the sound played when the game is won
/// 
/// ---------------------------General Specifications----------------------------
/// 
/// Filename: Avoid Armageddon
/// Programming: Patrick Jakubowski
/// Username: jakubowpa152
/// Filepath: H:\ICS 3U\Avoid Armageddon
/// 
///
namespace Avoid_Armageddon
{
    public partial class FrmArmageddon : Form
    {
        public FrmArmageddon()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        Graphics g;
        Random r = new Random();

        int Health = 25;
        int Wormx;
        int CountL = 1;
        int CountR = 1;
        int Counter = 1;

        bool Game = false;
        bool MoveLeft;
        bool MoveRight;

        bool[] WeaponSlotStatus = new bool[101];
        int[] WeaponSlotSpeed = new int[101];
        int[] WeaponSlotType = new int[101];
        int[] WeaponPosX = new int[101];
        int[] WeaponPosY = new int[101];
        int WeaponAmount;

        int BulletX;
        int BulletY;
        int BulletSpeed;
        bool BulletStatus = false;

        int Levelcount = 1;
        int Score;
        DateTime TickTime;
        DateTime StartTime;
        int TotalScore;

        SolidBrush Writing = new SolidBrush(Color.White);
        Font Numbers = new Font("Stencil", 16);
        Font Titles = new Font("Stencil", 12);        

        //Backgrounds
        Image FormBackground;

        //Weapons
        Image[] Weapon = new Image[13];
        Image Bullet;

        //Life Bar
        Image[] LifeBar = new Image[26];

        //Graves
        Image[] Grave = new Image[4];

        //Movement
        Image[] WalkLeft = new Image[16];
        Image[] WalkRight = new Image[16];
        Image[] Skip = new Image[10];

        //Sounds
        SoundPlayer BackgroundMusic = new SoundPlayer();
        SoundPlayer Explosion = new SoundPlayer();
        SoundPlayer Ow = new SoundPlayer();


        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting worm position to half.
            Wormx = (this.Width / 2) - 150;

            //Adjusting game difficulty
            WeaponAmount = (GlobalVar.GblDifficulty * 2*Levelcount) + 4;

            //Loading in pictures in the same order that declared. Done for simplicty.

            FormBackground = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Backgrounds\PanelBackground.JPG");

            for (int i = 1; i <= 12; i++)
                Weapon[i] = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Weapons\Weapon" + i.ToString() + ".gif");
            Bullet = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Weapons\Bullet.gif");

            for (int i = 1; i <= 25; i++)
                LifeBar[i] = Image.FromFile(Application.StartupPath + @"\Worms Pictures\LifeBar\LifeBar Frame " + i.ToString() + ".gif");

            for (int i = 1; i <= 3; i++)
                Grave[i] = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Graves\Grave" + i.ToString() + ".gif");

            for (int i = 1; i <= 15; i++)
            {
                WalkLeft[i] = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Movement\Walking\Left\WormWalkLeft Frame " + i.ToString() + ".gif");
                WalkRight[i] = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Movement\Walking\Right\WormWalkRight Frame " + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 9; i++)
                Skip[i] = Image.FromFile(Application.StartupPath + @"\Worms Pictures\Movement\Skip\WormSkip Frame " + i.ToString() + ".gif");

            //Sounds
            BackgroundMusic.SoundLocation = Application.StartupPath + @"\Battle.wav";
            Explosion.SoundLocation = Application.StartupPath + @"\Explosion2.wav";
            Ow.SoundLocation = Application.StartupPath + @"\Ow.wav";

            if (GlobalVar.GblMusic == 1 || GlobalVar.GblMusic == 0)
            {
                axWindowsMediaPlayer1.URL = BackgroundMusic.SoundLocation;
            }
            Explosion.LoadAsync();
            Ow.LoadAsync();

            this.Focus();
            TimFormStart.Enabled = true;
            g = this.CreateGraphics();

        }

        private void TimFormStart_Tick(object sender, EventArgs e)
        {
            //Disable enable
            TimFormStart.Enabled = false;
            //Setting g
            g = this.CreateGraphics();
            //Drawing background and life
            g.DrawImage(LifeBar[Health], this.Width - 125, ((this.Height / 2) - 60), 100, 100);
            g.DrawImage(FormBackground, 0, 0, this.Width - 150, this.Height);
            //Skipping enabled
            TimSkip.Enabled = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (BtnStart.Text == "Start")
            {
                g = this.CreateGraphics();

                TimSkip.Enabled = false;
                //Showing that the weapons are in use
                for (int i = 1; i <= 10; i++)
                    WeaponSlotStatus[i] = false;

                //Clearing previous score
                TotalScore = 0;
                Levelcount = 1;
                WeaponAmount = (GlobalVar.GblDifficulty * 2 * Levelcount) + 4;

                //Resetting health
                Health = 25;
                
                //Game has started
                //Obtain current time
                TickTime = DateTime.Now;
                StartTime = DateTime.Now;
                BtnStart.Text = "Stop";
                BulletStatus = false;

                //Spawn number of weapons equal to the pre-set amount
                //Max is 1000
                for (int i = 1; i <= WeaponAmount; i++)
                {
                    //Checking If weapon is already used.
                    if (WeaponSlotStatus[i] == false)
                    {
                        WeaponPosY[i] = -20;
                        Randomization(i);
                    }
                }
                Game = true;
            }
            else if (BtnStart.Text == "Stop")
            {
                Game = false;
                BackgroundMusic.Stop();
                for (int x = 1; x <= WeaponAmount; x++)
                    WeaponSlotStatus[x] = false;
                if (Health > 1)
                {
                    MessageBox.Show("You Win!  You won with a total score of " + TotalScore.ToString());
                }
                else
                    MessageBox.Show("You Lost!  You managed to get " + TotalScore.ToString() + " points before dying.");
                //Resetting values
                TotalScore = 0;
                BtnStart.Text = "Start";
            }
        }

        private void Randomization(int WeaponSlot)
        {
            //Choosing X position
            WeaponPosX[WeaponSlot] = r.Next(-10, this.Width - 200);

            //Choosing Weapon type
            int WeaponChoice = r.Next(1, 101);
            if (WeaponChoice <= 15)
                DrawWeapon(1, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 25)
                DrawWeapon(2, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 35)
                DrawWeapon(3, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 45)
                DrawWeapon(4, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 50)
                DrawWeapon(5, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 60)
                DrawWeapon(6, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 70)
                DrawWeapon(7, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 80)
                DrawWeapon(8, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 85)
                DrawWeapon(11, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 90)
                DrawWeapon(12, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 95)
                DrawWeapon(9, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);
            else if (WeaponChoice <= 100)
                DrawWeapon(10, WeaponSlot, WeaponPosX[WeaponSlot], WeaponPosY[WeaponSlot]);

        }
        private void DrawWeapon(int WeaponType, int WeaponNumber, int PosX, int PosY)
        {
            //Setting weapon speeds (all pre-defined.)
            if (WeaponType == 1)
                WeaponSlotSpeed[WeaponNumber] = 4;
            else if (WeaponType == 2)
                WeaponSlotSpeed[WeaponNumber] = 2;
            else if (WeaponType == 3)
                WeaponSlotSpeed[WeaponNumber] = 3;
            else if (WeaponType == 4)
                WeaponSlotSpeed[WeaponNumber] = 3;
            else if (WeaponType == 5)
                WeaponSlotSpeed[WeaponNumber] = 1;
            else if (WeaponType == 6)
                WeaponSlotSpeed[WeaponNumber] = 5;
            else if (WeaponType == 7)
                WeaponSlotSpeed[WeaponNumber] = 2;
            else if (WeaponType == 8)
                WeaponSlotSpeed[WeaponNumber] = 3;
            else if (WeaponType == 11)
                WeaponSlotSpeed[WeaponNumber] = 2;
            else if (WeaponType == 12)
                WeaponSlotSpeed[WeaponNumber] = 2;
            else if (WeaponType == 9)
                WeaponSlotSpeed[WeaponNumber] = 5;
            else if (WeaponType == 10)
                WeaponSlotSpeed[WeaponNumber] = 1;
            //Setting the weapon slot to that weapon
            WeaponSlotType[WeaponNumber] = WeaponType;
            //Drawing the weapon
            g.DrawImage(Weapon[WeaponType], PosX, PosY);
            //Weaponslot is in use
            WeaponSlotStatus[WeaponNumber] = true;

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Game == true)
            {
                if (e.KeyCode == Keys.A)
                {
                    //Showing movement left
                    MoveLeft = true;
                    MoveRight = false;
                    //Moving
                    if (Wormx > 0)
                    {
                        Wormx -= 3;
                    }
                    //Animating
                    CountL++;
                    if (CountL > 15)
                        CountL = 1;

                }
                else if (e.KeyCode == Keys.D)
                {
                    //Showing movement right
                    MoveRight = true;
                    MoveLeft = false;
                    //Moving
                    if (Wormx < (this.Width - 150) - WalkRight[CountR].Width)
                    {
                        Wormx += 3;
                    }
                    //Animating
                    CountR++;
                    if (CountR > 15)
                        CountR = 1;
                }
                if (e.KeyCode == Keys.W)
                {
                    if (BulletStatus == false)
                    {
                        BulletStatus = true;
                        BulletX = Wormx + (WalkLeft[CountL].Width/2);
                        BulletY = this.Height - 85;
                        BulletSpeed = 5 - GlobalVar.GblDifficulty;
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Close
            g.Dispose();
            this.Close();
        }

        private void TimSkip_Tick(object sender, EventArgs e)
        {
            //Skipping animation
            g.DrawImage(FormBackground, 0, 0, this.Width - 150, this.Height);
            g.DrawImage(Skip[Counter], Wormx, this.Height - 80);
            Counter++;
            if (Counter > 9)
                Counter = 1;
            if (Game == true)
                TimSkip.Enabled = false;
             
        }

        private void FrmArmageddon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (Game)
            {
                //Wave counter
                TickTime = DateTime.Now;
                if (StartTime.AddSeconds(1)<TickTime)
                {
                    StartTime = DateTime.Now;
                    TickTime = DateTime.Now;
                    Score++;
                    TotalScore++;
                    if (Score > 15)
                    {
                        Levelcount++;
                        WeaponAmount = (GlobalVar.GblDifficulty * 2 * Levelcount) + 4;
                        Score = 0;
                    }
                }

                for (int i = 1; i <= WeaponAmount; i++)
                {
                    //Checking If weapon is already used.
                    if (WeaponSlotStatus[i] == false)
                    {
                        WeaponPosY[i] = -20;
                        Randomization(i);
                    }
                }

                //Managing Health
                if (Health > 1)
                    g.DrawImage(LifeBar[Health], this.Width - 125, ((this.Height / 2) - 60), 100, 100);

                //Managing Bullet
                if (BulletStatus == true)
                {
                    if (BulletY >= -30)
                    {
                        for (int b = 1; b <= WeaponAmount; b++)
                        {
                            if (WeaponPosY[b] + Weapon[WeaponSlotType[b]].Height > BulletY && WeaponPosY[b] < BulletY + Bullet.Height
                                && WeaponPosX[b] + Weapon[WeaponSlotType[b]].Width > BulletX && WeaponPosX[b] < BulletX + Bullet.Width)
                            {
                                Explosion.Play();
                                //Add score
                                TotalScore += 10 - WeaponSlotSpeed[b];
                                //Randomize
                                WeaponPosY[b] = -20;
                                Randomization(b);
                            }
                        }
                        BulletY -= BulletSpeed;
                    }
                    else
                    {
                        BulletStatus = false;
                    }
                }

                for (int i = 1; i <= WeaponAmount; i++)
                {
                    if (WeaponPosY[i] < this.Height - 80)
                        //Move Weapon
                        WeaponPosY[i] += WeaponSlotSpeed[i];
                    else if (WeaponPosY[i] + Weapon[WeaponSlotType[i]].Height > this.Height - 80 && WeaponPosX[i] +
                        Weapon[WeaponSlotType[i]].Width > Wormx && WeaponPosX[i] < Wormx + WalkLeft[1].Width)
                    {
                        //Play sound
                        if (GlobalVar.GblMusic == 2 || GlobalVar.GblMusic == 0)
                        {
                            Explosion.Play();
                            Ow.Play();
                        }
                        //Reduce health
                        Health = Health - (6 - WeaponSlotSpeed[i]);
                        if (Health > 1)
                            g.DrawImage(LifeBar[Health], this.Width - 125, ((this.Height / 2) - 60), 100, 100);
                        else
                        {
                            //Draw grave and empty lifebar
                            g.DrawImage(FormBackground, 0, 0, this.Width - 150, this.Height - 60);
                            g.DrawImage(Grave[r.Next(1, 4)], Wormx, this.Height - 80);
                            g.DrawImage(LifeBar[1], this.Width - 125, ((this.Height / 2) - 60), 100, 100);
                            //GameOver
                            Game = false;
                            BackgroundMusic.Stop();
                            for (int x = 1; x <= WeaponAmount; x++)
                                WeaponSlotStatus[x] = false;
                            if (Health > 1)
                            {
                                MessageBox.Show("You Win!  You won with a total score of " + TotalScore.ToString());
                            }
                            else
                                MessageBox.Show("You Lost!  You managed to get " + TotalScore.ToString() + " points before dying.");
                            //Resetting values
                            TotalScore = 0;
                            BtnStart.Text = "Start";
                        }
                        //Randomize
                        WeaponPosY[i] = -20;
                        Randomization(i);


                    }
                    else
                    {
                        //Play explosion sound
                        if (GlobalVar.GblMusic == 2 || GlobalVar.GblMusic == 0)
                        {
                            Explosion.Play();
                        }
                        //Add score
                        TotalScore += 10 - WeaponSlotSpeed[i];
                        //Randomize
                        WeaponPosY[i] = -20;
                        Randomization(i);

                    }
                }

                //Drawing
                g.DrawImage(FormBackground, 0, 0, this.Width - 150, this.Height);
                if (MoveLeft == false)
                    g.DrawImage(WalkRight[CountR], Wormx, this.Height - 80);
                else if (MoveRight == false)
                    g.DrawImage(WalkLeft[CountL], Wormx, this.Height - 80);
                for (int i = 1; i <= WeaponAmount; i++)
                    g.DrawImage(Weapon[WeaponSlotType[i]], WeaponPosX[i], WeaponPosY[i]);
                if (BulletStatus)
                    g.DrawImage(Bullet, BulletX, BulletY);

                g.DrawString("Total Score", Titles, Writing, this.Width - 130, 25);
                g.DrawString(TotalScore.ToString(), Numbers, Writing, this.Width - 80, 50);
                g.DrawString("Wave", Titles, Writing, this.Width - 100, 75);
                g.DrawString(Levelcount.ToString(), Numbers, Writing, this.Width - 80, 100);
                g.DrawString("Wave Time", Titles, Writing, this.Width - 130, 125);
                g.DrawString((15-Score).ToString(), Numbers, Writing, this.Width - 80, 150);
                Invalidate();
            }
        }
    }
}
