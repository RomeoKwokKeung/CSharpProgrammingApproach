//Variable Dictionary
//hitpoints - The player's current hitpoints
//power - The player's current power level
//enemyhp1 - The first boss's hitpoints
//enemyhp2 - The second boss's hitpoints
//enemyhp3 - The third boss's hitpoints.
//counterbackground - The counter that flips through the background images to create an animation.
//level - The current level the player is on.
//counterplayer - The counter that flips through the player images to create an animation.
//BossX - The X position of the boss
//BossY - The Y position of the boss
//enemyattack - The boolean that checks to see if the enemy is currently attacking
//playerattack - The boolean that checks to see if the player is currently attacking
//playerspec - The boolean that checks to see if the player is attacking with a special attack
//playerattackdelay - The boolean that checks if the player should still be showing the attack image
//enemyattackdelay - The boolean that checks if the boss should still be showing the attack image
//healing - The boolean that checks if the player activated the healinga bility
//gameover - The boolean that checks if the game is over.
//winner - The temporary name of the winner of the player so the highscores can be updated
//projectileX - The X position of the player's attacking projectile
//projectileY - The Y position of the player's attacking projectile
//SpecX - The X position of the player's spec projectile
//SpecY - The Y position of the player's spec projectile
//deathcheck - The int used to see if the player has truly died
//enemyprojectileX - The X position of the enemy's projectile
//enemyprojectileY - The Y position of the enemy's projectile
//enemyprojectileSpeed - How fast the enemy's projectile moves
//PlayerX - The X position of the player
//PlayerY - The Y position of the player 
//lol - The location of the winners file.
//f - The location of the winners file.
//highscorescounter - used to determine the # of people on the highscores            
//winners[] - used to store the player names of all winners.

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

namespace FinalGameAssignment
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
                      
            SetStyle(ControlStyles.UserPaint, true); //Activates double buffering to prevent flickering.
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
            
            //Variables
            int hitpoints;
            int power;
            int enemyhp1;
            int enemyhp2;
            int enemyhp3;
            int counterbackground = 1;
            int level;
            int counterplayer = 1;
            int PlayerX = 100;
            int PlayerY = 200;
            int counterboss = 1;
            int bossX = 300;
            int bossY = 100;
            bool enemyattack = false;
            bool playerattack = false;
            bool playerspec = false;
            bool playerattackdelay = false;
            bool enemyattackdelay = false;
            bool healing = false;
            bool gameover = false;
            string winner;
            string[] winners = new String[100];
            
            int highscorecounter;

            //Declarations
            Random r = new Random(); 
            
            //Pictures
            Image[] boss1images = new Image[7];
            Image boss;

            Image[] boss2images = new Image[7];
            Image[] boss3images = new Image[7];

            Image[] playerimage = new Image[7];
            Image player;
            
            Image[] backgroundimage = new Image[13];
            Image background;

            Image bullet;
            Image spec;

            

            //Sounds
            SoundPlayer attack = new SoundPlayer();
            SoundPlayer specialattack = new SoundPlayer();
        
            Image enemybullet;
            
            //Variables (See variable dictionary)
            int projectileX = -50; 
            int projectileY = -50;
            int projectileSpeed = 0;
            int specX = -50;
            int specY = -50;
            int deathcheck = 0;
            int enemyprojectileX = -50;
            int enemyprojectileY = -50;
            int enemyprojectileSpeed = 10;
            string lol = Application.StartupPath + @"\Winners.txt";
            

            Graphics g;
        
        private void FrmGame_Load(object sender, EventArgs e)
        {
            hitpoints = 50; //Starts the game by setting player's hitpoints to full.
            power = 5; //Starts the game by setting the player's power to a small value.
            enemyhp1 = 50; //Sets bosses Hitpoints to max.
            enemyhp2 = 100;
            enemyhp3 = 200;
            TmrImages.Enabled = true; //Enables the timer that plays the animations.
            TmrHeal.Enabled = true; //Enables the timer that heals the bosses.
            level = 1; //Sets the game to level 1
            BarEnemy1.Visible = true; //Shows the first boss's hp bar.
            WmpBgm.URL = Application.StartupPath + @"\Level1.mp3"; //Plays level one's background music
            TmrBoss.Enabled = true; //Starts the boss timer which controls their movements.
            attack.SoundLocation = Application.StartupPath + @"\Fireball.wav"; //The path to the fireball sound effect
            attack.LoadAsync(); //Loads the sound effect 
            specialattack.SoundLocation = Application.StartupPath + @"\Special.wav"; //The path to the special attack sound effect
            specialattack.LoadAsync(); //Loads in the sound effect 
            enemybullet = Image.FromFile(Application.StartupPath + @"\bossattack.gif"); //Loads in the image of the enemy's projectile
            TmrUpdate.Enabled = true; //Enables the game updating timer.
            for (int i = 1; i <= 12; i++) //Loads in the background images.
            {
                backgroundimage[i] = Image.FromFile(Application.StartupPath + @"\background" + i.ToString() + ".jpg");
            }
            
            background = backgroundimage[1]; //Sets the background image to the first one.

            for (int i = 1; i <= 6; i++) //Loads in the player's images.
            {
                playerimage[i] = Image.FromFile(Application.StartupPath + @"\Player" + i.ToString() + ".gif");
            }

            player = playerimage[1]; //Sets the first player image.

            for (int i = 1; i <= 5; i++) //Loads in the first boss's images.
            {
                boss1images[i] = Image.FromFile(Application.StartupPath + @"\Boss1" + i.ToString() + ".gif");
            }

            boss = boss1images[1]; //Sets the first boss image.

            for (int i = 1; i <= 6; i++) //Loads in the second boss's images.
            {
                boss2images[i] = Image.FromFile(Application.StartupPath + @"\Boss2" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 6; i++) //Loads in the thir dboss's images.
            {
                boss3images[i] = Image.FromFile(Application.StartupPath + @"\Boss3" + i.ToString() + ".gif");
            }
            
            bullet = Image.FromFile(Application.StartupPath + @"\PlayerFireball5.gif"); //Loads in the image for the player's projectile.
            spec = Image.FromFile(Application.StartupPath + @"\playerspec.gif"); //Loads in the image for the player's special attack.

            
        }

        
        private void DrawStuff(Graphics g)
        {
            
            g.DrawImage(background, 0, 0); //Refreshes the backgrund image
            g.DrawImage(player, PlayerX, PlayerY); //Redraws the player's position and image
            g.DrawImage(bullet, projectileX, projectileY); //Redraws the player's projectile
            g.DrawImage(spec, specX, specY); //Redraws the player's special  attack
            g.DrawImage(enemybullet, enemyprojectileX, enemyprojectileY); //Redraws the enemy's projectile
            g.DrawImage(boss, bossX, bossY); //Redraws the boss

        }

        private void TmrUpdate_Tick(object sender, EventArgs e)
        {
            BarHitpoints.Value = hitpoints; //Updates the player's hitpoints bar
            BarPower.Value = power; //Updates the player's power bar
            

            switch (level)  //A statement used multiple times which affects what happens depending on the level. Each case is a specific level.
            {
                case 1:
                
                    BarEnemy1.Value = enemyhp1; //Updates the first boss's hp bar
                    
                
                break;

                case 2:

                    BarEnemy2.Value = enemyhp2; //Updates the second boss's hp bar
                
                break;

                case 3:
                
                    BarEnemy3.Value = enemyhp3; //Updates the third boss's hp bar
                
                break;
            }
        }
    
        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics; //Sets the graphics to the form.


            DrawStuff(g); //Redraws all images.
          
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counterbackground > 11) //Loops through the background images to turn it into an animation
            {
                counterbackground = 0;
            }

            counterbackground++;

            background = backgroundimage[counterbackground]; //Updates the background image

            
            
            
            

            
            if (counterplayer >= 4) //Loops through the player images to turn it intoan animation
            {
                counterplayer = 0;
            }

            counterplayer++;

            if (!playerattackdelay) //Checks to see if the player stopped attacking, if they did, then the player image updates
            {
                player = playerimage[counterplayer];
            }
            else
            {
                player = playerimage[6]; //If the player is attacking, the attacking picture is displayed. 
            }
            if (playerattack) //If the projectile is on screen
            {
                
                projectileX += projectileSpeed; //Moves it
                if (projectileX >= 200) //Time for when the delay of the attack is turned off so the player stops his attacking image
                {
                    playerattackdelay = false;
                }
            }
            else if (playerspec) //Does the exact same as above, but for a special attack.
            {
                
                specX += projectileSpeed;
                if (specX >= 200)
                {
                    playerattackdelay = false;
                }
            }
            if (enemyprojectileX <= ClientSize.Width / 2) //Determines when the enemy's delay ends.
            {
                enemyattackdelay = false;
            }
            if (enemyprojectileX <= 0) //If the enemy projectile goes off screen, reset it.
            {
                NewEnemyProjectile();
            }
            if (enemyprojectileX <= PlayerX + player.Width && enemyprojectileX >= PlayerX && enemyprojectileY + 10 <= PlayerY + player.Height && enemyprojectileY + 15 >= PlayerY - 10) //Checks for a collision between the enemy projectile and the player
            {
                NewEnemyProjectile(); //Resets the projectile
                WmpEffects.URL = Application.StartupPath + @"\hit.wma"; //Plays the hit sound
                switch(level) 
                {
                    case 1:
                        if (hitpoints >= 5) //Lowers the player's hitpoints by 5 or drops it to 0, and pushes the player back
                        {
                            PlayerX = 10;
                            hitpoints -= 5;
                        }
                        else
                        {
                            hitpoints = 0;
                            
                        }
                        break;

                    case 2:
                        if (hitpoints >= 10) //Same as above but more damage
                        {
                            hitpoints -= 10;
                            PlayerX = 10;
                        }
                        else
                        {
                            hitpoints = 0;
                            
                        }
                        break;

                    case 3:
                        if (hitpoints >= 20) //Same as above but more damage
                        {
                            hitpoints -= 20;
                            PlayerX = 10;
                        }
                        else
                        {
                            hitpoints = 0;
                            
                        }
                        break;
                }
            }

            if (enemyattackdelay) //If the boss's delay is still active 
            {
                switch (level)
                {
                    case 1:
                        
                        boss = boss1images[5]; //Boss's image is the attacking image.
                        break;

                    case 2:

                        boss = boss2images[5]; //Boss's image is the attacking image.
                        break;

                    case 3:
                        boss = boss3images[6]; //Boss's image is the attacking image.
                        break;
                }
            }
            if (enemyattack) //If the projectile of the enemy is onscreen
            {
                enemyprojectileX -= enemyprojectileSpeed; //Move it left a bit
            }

            switch (level)
            {
                case 1:
                    if (enemyhp1 == 0) //Checks to see if the boss died
                    {
                        NextLevel();
                    }
                    break;

                case 2:
                    if (enemyhp2 == 0) //Checks to see if the boss died
                    {
                        NextLevel();
                    }
                    break;

                case 3:
                    if (enemyhp3 == 0) //Checks to see if the boss died
                    { 
                        NextLevel();
                    }
                    break;
            }



            if (!enemyattackdelay) //If the boss isn't attacking, the image of the boss changes
            {
                counterboss++;
            }
            if (counterboss >= 5)  
            {
                counterboss = 1;
            }

            
            
            switch (level)
            {
                case 1:

                    if (!enemyattackdelay) //If the boss isn't attacking, the image displayed is the regular animation of the boss
                    {
                        boss = boss1images[counterboss]; //Updates the image
                    }
                    
                    break;

                case 2:

                    if (!enemyattackdelay) //Same as above
                    {
                        boss = boss2images[counterboss]; //Updates the image
                    }
                    break;

                case 3:
                    if (!enemyattackdelay) //Same as above
                    {
                        boss = boss3images[counterboss]; //Updates the image
                    }
                    

                    break;
            }
                
                switch (level)
                {
                    case 1:
                        if (projectileX - 10 >= bossX && projectileY >= bossY - 15 && projectileY - 10 <= boss.Height + bossY) //Checks for a collision between the player's normal projectile and the boss
                        {
                            NewProjectile(); //Resets the projectile 
                            if (enemyhp1 >= 5) //Drops the enemy hp by 5
                            {
                                enemyhp1 -= 5;
                               
                                if (hitpoints <= 48) //Heals the player a bit
                                {
                                    hitpoints += 2;
                                }
                                else
                                {
                                    hitpoints = 50;
                                }
                                if (power < 20) //Increases the player's power a bit
                                {
                                    power += 1;
                                }
                            }
                            else
                            {
                                enemyhp1 = 0; //Enemy dies
                                
                            }
                        }
                        if (specX >= bossX && specY - 10 >= bossY - 15 && specY - 20 <= bossY + boss.Height) //Checks for a collision between the player special attack and the boss
                        {
                            NewProjectile();
                            WmpPlayerEffects.URL = Application.StartupPath + @"\hitboss.wma"; //Plays the sound
                            if (enemyhp1 >= 20) //Checks for boss's hp and drops it by 20
                            {
                                enemyhp1 -= 20;
                            }
                            else
                            {
                                enemyhp1 = 0; //Kills the boss
                            }
                        }
                        break;

                    case 2:
                        if (projectileX - 10 >= bossX && projectileY - 10 >= bossY - 15 && projectileY - 10 <= boss.Height + bossY) //Same as above, but more hitpoints healed
                        {
                            NewProjectile();
                            if (enemyhp2 >= 5)
                            {
                                enemyhp2 -= 5;
                                if (hitpoints <= 48)
                                {
                                    hitpoints += 2;
                                }
                                else
                                {
                                    hitpoints = 50;
                                }
                                if (power < 19)
                                {
                                    power += 2;
                                }
                            }
                            else
                            {
                                enemyhp2 = 0;

                            }
                        }
                        if (specX >= bossX && specY - 10 >= bossY - 15 && specY - 20 <= bossY + boss.Height) //Same as above but a bit more damage
                        {
                            NewProjectile();
                            WmpPlayerEffects.URL = Application.StartupPath + @"\hitboss.wma";
                            if (enemyhp2 >= 5)
                            {
                                enemyhp2 -= 5;
                            }
                            else
                            {
                                enemyhp2 = 0;
                            }
                        }
                        break;

                    case 3:
                        if (projectileX - 10 >= bossX && projectileY - 10 >= bossY - 15 && projectileY - 10 <= boss.Height + bossY) //Same as above but more damage done
                        {
                            NewProjectile();
                            if (enemyhp3 >= 9)
                            {
                                enemyhp3 -= 9;
                                if (hitpoints <= 48)
                                {
                                    hitpoints += 2;
                                }
                                else
                                {
                                    hitpoints = 50;
                                }
                                if (power < 17)
                                {
                                    power += 4;
                                }
                                else
                                {
                                    power = 20;
                                }
                            }
                            else
                            {
                                enemyhp3 = 0;

                            }
                        }
                        if (specX >= bossX && specY - 10 >= bossY - 15 && specY - 20 <= bossY + boss.Height && specX <= bossX + boss.Height) //Same as above but more damage
                        {
                            NewProjectile();
                            WmpPlayerEffects.URL = Application.StartupPath + @"\hitboss.wma";
                            if (enemyhp3 >= 12)
                            {
                                enemyhp3 -= 12;
                            }
                            else
                            {
                                enemyhp1 = 0;
                            }
                        }
                        break;

                }
                
            
            
            if (projectileX >= ClientSize.Width || specX >= ClientSize.Width) //Checks if the player's projectile goes off screen
            {
                NewProjectile(); //Resets the projectile 
            }

            if (hitpoints == 0 && gameover == false) //Checks if the player's hitpoints is 0
            {
                deathcheck++; //If it is, death check increases by 1. Death check must be 3 before the player is considered dead.
                if (deathcheck == 3) //if the player is considered dead,
                {
                    BarHitpoints.Value = 0;
                    TmrBoss.Enabled = false; //Stops the game
                    TmrHeal.Enabled = false;
                    TmrUpdate.Enabled = false;
                    gameover = true; //Stops a few bugs
                    MessageBox.Show("You were killed. Game over.", "Good Fight"); //Displays a message
                    this.Close(); //Ends the game.
                }
            }

            if (healing) //Checks to see if the player is healing himself 
            {
                if (power == 0 || hitpoints == 50) //If the player's power is 0 or their hp is full
                {
                    healing = false; //Stop healing
                }
                else //if not
                {
                    hitpoints += 1; //Heal one hitpoint and lose one power.
                    power -= 1;
                }
            }
            Invalidate(); //Necessary for the images to change.

            

        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmStart f = new FrmStart(); //Opens up the starting form.
            
            f.Show();
            WmpBgm.Ctlcontrols.stop(); //Stops the music player
        }

        private void TmrBoss_Tick(object sender, EventArgs e)
        {
                bossX = r.Next(250, 450); //Sets a random position for the boss
                bossY = r.Next(50, 250);

            
                Shoot(); //Shoots a projectile 
           
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: // Player moves up when you press W
                    if (PlayerY >= 50)//Checks for clipping issues
                    {
                        PlayerY -= 10;
                    }
                    break;

                case Keys.S: //Player moves down when you press S

                    if (PlayerY <= 350)//Checks for clipping issues
                    {
                        PlayerY += 10;
                    }

                    break;

                case Keys.A: //Player moves left when you press A
                    
                    if (PlayerX >= 5) //Checks for clipping issues
                    {
                        PlayerX -= 10;
                    }
                    
                    break;

                case Keys.D: //Player moves right when you press D
                   
                    if (PlayerX <= ClientSize.Width / 2 - 50) //Checks for clipping issues
                    {
                        PlayerX += 10;
                    }
                    break;
                
                case Keys.Space:

                    if (specX <= 0 && projectileX <= 0 && power >= 2 && healing == false) //Checks to see if the player didn't already shoot and if they aren't healing and if they have enough power
                    {
                        playerspec = true; //Sets the spec bool to true
                        projectileSpeed = 20; //Sets a projectile speed 
                        specX = PlayerX + 30; //Spawns the image near the player 
                        specY = PlayerY + 15;
                        playerattackdelay = true; //Starts the attack delay so the image of the player attacking appears.
                        power -= 2; //Decreases the power 
                        specialattack.Play(); //Plays the sound
                        
                    }
                    break;

                case Keys.ControlKey:
                    
                    if (projectileX <= 0 && specX <= 0) //Checks to see if the player didn't recently shoot anything
                    {
                        playerattack = true; //Same as above but for attacking
                        playerattackdelay = true; //Same as above but for normal attacking 
                        projectileSpeed = 20; 
                        projectileX = PlayerX + 30;
                        projectileY = PlayerY + 20;
                        attack.Play(); //Plays the sound
                        
                    }
                    break;

                case Keys.H:
                    
                    if (healing == false && power > 0 && hitpoints != 50) //Checks if the player is eligible to start healing
                    {
                        healing = true; //Starts healing the player
                    }

                    break;



            }
        }


        public void NewProjectile() //Resets the projectile by hiding it off screen and setting the values to false
        {
            playerattack = false;
            playerspec = false;
            specX = -50;
            projectileX = -50;
        }

        public void Shoot()
        {
            if (!enemyattack) //Shoots a projectile from the boss if the boss isn't attacking
            {
                WmpEffects.URL = Application.StartupPath + @"\Attack.wma"; //Plays the sound
                bossY = PlayerY - 20; //Puts boss in line with the player
                enemyattack = true;
                enemyprojectileX = bossX; //Puts the projectile near the boss
                enemyprojectileY = bossY + 25;
                enemyattackdelay = true;
            }
        }

        public void NewEnemyProjectile() //Resets the enemy's projectile
        {
            enemyattack = false; 
            enemyprojectileX = -200;
            
        }

        public void NextLevel() //Moves the player to the next level.
        {
            TmrUpdate.Enabled = false;
            enemyhp1 = 1;
            BarEnemy1.Value = 0;
            enemyhp2 = 1;
            BarEnemy2.Value = 0;
            enemyhp3 = 1;
            BarEnemy3.Value = 0;
            switch (level)
            {
                case 1: //Resets the whole game by turning off the timers, displaying a message, speeding up the boss, and then reenabling the timers after the player presses ok.
                   
                    TmrBoss.Enabled = false;
                    TmrHeal.Enabled = false;
                    enemyprojectileX = -50;
                    MessageBox.Show("Congratulations! You have defeated the first boss.", "Level One Completed");
                    enemyhp1 = 50;
                    enemyhp2 = 100;
                    TmrBoss.Interval = 3000;
                    enemyprojectileSpeed = 25;
                    level = 2;
                    enemyattack = false;
                    enemyattackdelay = false;
                    LblLevel.Text = "Level 2";
                    MessageBox.Show("Level Two. Good luck!", "Level Two");
                    TmrUpdate.Enabled = true;

                    BarEnemy1.Visible = false;
                    BarEnemy2.Visible = true;
                    TmrBoss.Enabled = true;
                    TmrHeal.Enabled = true;
                    WmpBgm.URL = Application.StartupPath + @"\Level2.mp3";
                    break;

                case 2://Resets the whole game by turning off the timers, displaying a message, speeding up the boss, and then reenabling the timers after the player presses ok.
                    TmrUpdate.Enabled = false;
                    TmrBoss.Enabled = false;
                    TmrHeal.Enabled = false;
                    enemyprojectileX = -50;
                    enemyhp3 = 200 ;
                    MessageBox.Show("Congratulations! You have defeated the second boss.", "Level Two Completed");
                    
                    TmrBoss.Interval = 2000;
                    level = 3;
                    enemyattack = false;
                    enemyattackdelay = false;
                    enemyprojectileSpeed = 35;
                    MessageBox.Show("This is the last level, good luck!", "Final Challenge");
                    LblLevel.Text = "Level 3";
                    TmrUpdate.Enabled = true;
                    BarEnemy2.Visible = false;
                    BarEnemy3.Visible = true;
                    TmrBoss.Enabled = true;
                    TmrHeal.Enabled = true;
                    WmpBgm.URL = Application.StartupPath + @"\Level3.wma";
                    TmrBossMove.Enabled = true;
                    TmrMusic.Enabled = true;
                    break;

                case 3: //Turns off the game and asks the player for their name to add to the highscores
                    enemyhp3 = 200;
                    TmrUpdate.Enabled = false;
                    TmrBoss.Enabled = false;
                    TmrHeal.Enabled = false;
                    TmrBossMove.Enabled = false;
                    TmrMusic.Enabled = false;
                    MessageBox.Show("Congratulations! You have completed the game!", "Game Completed");

                    StreamReader v = new StreamReader(Application.StartupPath + @"\Winners.txt"); //Gets ready to read in the data file

                    while (true)
                    {
                        highscorecounter++;

                        winners[highscorecounter] = v.ReadLine();

                        if (winners[highscorecounter] == null)
                        {
                            break;
                        }
                    }
                    v.Close();
                    StreamWriter w = new StreamWriter(Application.StartupPath + @"\Winners.txt"); //Gets ready to write in the data file

                    winner = Microsoft.VisualBasic.Interaction.InputBox("Please enter your name to be added into the highscores.", "Highscores", "", 250, 250);

                    winners[highscorecounter] = winner;
                    for (int i = 1; i <= highscorecounter; i++)
                    {
                        w.WriteLine(winners[i]);
                    }


                    w.Close();
                    this.Close();
                    break;

            }
        }

        private void TmrHeal_Tick(object sender, EventArgs e) //Heals the boss by 1 every time this timer ticks.
        {
            switch (level)
            {
                case 1:
                    if (enemyhp1 < 50 && enemyhp1 != 0) //If the boss isn't full hp and not dead
                    {
                        enemyhp1++; //Heal by 1
                    }
                    break;

                case 2:
                    if (enemyhp2 < 100 && enemyhp2 != 0) //If the boss isn't full hp and not dead
                    {

                        enemyhp2++;//Heal by 1
                    }
                    break;

                case 3:
                    if (enemyhp3 < 198d && enemyhp3 != 0) //If the boss isn't full hp and not dead
                    {
                        enemyhp3 += 2; //Heal by 2
                    }
                    break;
            }
        }

        private void TmrBossMove_Tick(object sender, EventArgs e)
        {
            bossX = r.Next(250, 450);
            bossY = r.Next(50, 250);//Randomly moves the boss, this is only for the 3rd boss.
        }

        private void TmrMusic_Tick(object sender, EventArgs e)
        {
            WmpBgm.URL = Application.StartupPath + @"\Level3.wma";
        }

        
    }
}
