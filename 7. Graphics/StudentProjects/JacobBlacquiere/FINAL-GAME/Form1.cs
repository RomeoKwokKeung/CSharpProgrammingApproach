using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;//Required for double buffering. 
using System.Media;//Required for using sound files.  

namespace FINAL_GAME
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();

            this.DoubleBuffered = true; //Allows for double buffering.

        }

        //************************************VARIABLE DICTIONARY*********************************************************

        //Loads in the background image "ocean". 
        Image background = Image.FromFile(Application.StartupPath + @"\ocean.jpg");
        //Loads in the explosion image "exp".
        Image explode = Image.FromFile(Application.StartupPath + @"\exp.gif");
        //Loads in the background image "desert".
        Image background2 = Image.FromFile(Application.StartupPath + @"\desert.jpg");
        //Loads in the background image "sky".
        Image background3 = Image.FromFile(Application.StartupPath + @"\sky.jpg");
        //Represents all of the images in the enemy and team arrays.
        int guy;
        //X and Y position of the mouse
        int x, y;     
        //Array of the enemy X position.
        int [] enemyX =new int [5] ;
        //Array of the enemy Y position. 
        int[] enemyY = new int[5];
        //Array of the enemy respawn X position. 
        int [] enemyDX = new int [5];
        //Array of the enemy respawn Y position. 
        int []enemyDY= new int[5];
        //Array of the team X position. 
        int[] teamX = new int[5];
        //Array of the team Y position. 
        int[] teamY = new int[5];
        //Array of the team respawn X position.
        int[] teamDX = new int[5];
        //Array of the team respawn Y position.
        int[] teamDY = new int[5];
        //Creates and sets click to false.
        bool clicked = false;
        //Declares the score variable.
        int score;
        //Array of the enemy images for level 1.
        Image[] enemy = new Image[5];
        //Array of the team images for level 1. 
        Image[] team = new Image[5];
        //Array of the enemy images for level 2.
        Image[] enemy2 = new Image[9];
        //Array of the team images for level 2.
        Image[] team2 = new Image[9];
        //Array of enemy images for level 3.
        Image[] enemy3 = new Image[5];
        //Array of the team images for level 3.
        Image[] team3 = new Image[5];
        //Array of the reverse enemy images for level 2.
        Image[] revenemy2 = new Image[9];
        //Array of the original enemy images for level 2.
        Image[] rev1 = new Image[9];
        //Array of the reverse enemy images for level 3.
        Image[] revenemy3 = new Image[5];
        //Array of the original enemy images for level 3. 
        Image[] rev2 = new Image[5];
        //Array of the reverse team images for level 2.
        Image[] revteam2 = new Image[9];
        //Array of the original team images for level 2
        Image[] rev3 = new Image[9];
        //Array of the reverse team images for level 3. 
        Image[] revteam3 = new Image[5];
        //Array of the original team images for level 3.
        Image[] rev4 = new Image[5];
        //Variable to keep track of the number of times the user shoots the "team" images. 
        int teamhit = 0;
        //Initializes random numbers.
        Random r = new Random();
        // Sound file strings
        //SoundPlayer explosion = new SoundPlayer();
        //Creates a new soundplayer for the back music. 
        SoundPlayer backgroundmusic = new SoundPlayer();
        //Creates a new soundplayer for explosion.
        SoundPlayer explosion = new SoundPlayer();
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //Sets the score to zero.
            score = 0;
           

             for (int i = 1; i <= 4; i++)
            {
                //Sets the X position of the enemies to a random number between 1 and 10.
                enemyX[i] = r.Next(1,10);
                //Sets the Y position of the enemies to a random number between 1 and 10.
                enemyY[i] = r.Next(1, 10);

            }

            for (int i = 1; i <= 4; i++)
            {
                //Loads in all the enemy images for level 1.
                enemy[i] = Image.FromFile(Application.StartupPath + @"\enemy" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 4; i++)
            {
                //Loads in the orignal enemy images for level 2.
                rev1[i] = Image.FromFile(Application.StartupPath + @"\EnemyLand" + i.ToString() + ".gif");
                //Loads in the enemy images for level 2. 
                enemy2[i] = Image.FromFile(Application.StartupPath + @"\EnemyLand" + i.ToString() + ".gif");
                //Loads in the reverse enemy images for level 2.
                revenemy2[i] = Image.FromFile(Application.StartupPath + @"\RevEnemyLand" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 4; i++)
            {
                //Loads in the orignal enemy images for level 3.
                rev2[i] = Image.FromFile(Application.StartupPath + @"\EnemyAir" + i.ToString() + ".gif");
                //Loads in the enemy images for level 3. 
                enemy3[i] = Image.FromFile(Application.StartupPath + @"\EnemyAir" + i.ToString() + ".gif");
                //Loads in the reverse enemy images for level 3.
                revenemy3[i] = Image.FromFile(Application.StartupPath + @"\RevEnemyAir" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 4; i++)
            {
                //Loads in all the team images for level 1.
                team[i] = Image.FromFile(Application.StartupPath + @"\team" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 4; i++)
            {
                //Loads in the orignal team images for level 2.
                rev3[i] = Image.FromFile(Application.StartupPath + @"\TeamLand" + i.ToString() + ".gif");
                //Loads in the team images for level 2.
                team2[i] = Image.FromFile(Application.StartupPath + @"\TeamLand" + i.ToString() + ".gif");
                //Loads in the reverse team images for level 2.
                revteam2[i] = Image.FromFile(Application.StartupPath + @"\RevTeamLand" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 4; i++)
            {
                //Loads in the orignal team images for level 3.
                rev4[i] = Image.FromFile(Application.StartupPath + @"\TeamAir" + i.ToString() + ".gif");
                //Loads in the team images for level 3.
                team3[i] = Image.FromFile(Application.StartupPath + @"\TeamAir" + i.ToString() + ".gif");
                //Loads in the reverse team images for level 2.
                revteam3[i] = Image.FromFile(Application.StartupPath + @"\RevTeamAir" + i.ToString() + ".gif");
            }
            
            for (int i = 1; i <= 4; i++)
            {
                //Set team X position to a random position.
                teamX[i] = r.Next(1, 10);
                //Set team Y position to a random position.
                teamY[i] = r.Next(1,450);

            }

            //Set x to the width of the form / 3.
            x = ClientSize.Width / 3;
            
            //Load in the explosion sound file. 
            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            //Load in the background sound file. 
            backgroundmusic.SoundLocation = Application.StartupPath + @"\song.wav";
            
            //Load explosion sound file in seperate thread.
            explosion.LoadAsync();
            //Load background sound file in seperate thread. 
            backgroundmusic.LoadAsync();
            
         
            //Set focus to the form
            this.Focus(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Allows for drawing.
            Graphics g = e.Graphics;
            //Go to drawstuff method.
            DrawStuff(g); 
        }
        
        private void DrawStuff(Graphics g)
        {
            //Set font to arial, size 9, bold.
            Font font = new Font("Arial", 9, FontStyle.Bold);
            //Set brush colour to yellow.
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            //Set Gameover font to arial, 40, bold.
            Font GameOverfont = new Font("Arial", 40, FontStyle.Bold);
            //Set the brush to blue.
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            //Draw the background at point 0,0.
            g.DrawImage(background, 0, 0);
            //Display text "Current score" and attach score value.
            g.DrawString("Current Score -> " + score.ToString(), font, yellowBrush, 5, 5);
            //Display text "Teammates hit" and attach teamhit.
            g.DrawString("Teammates Hit -> " + teamhit.ToString(), font, yellowBrush, 5, 20);

            //Create pen and make it black.
            Pen pen = new Pen(Color.Black);
            //Draw the x axis of the cross hair.
            g.DrawLine(pen, x, 0, x, ClientSize.Height);
            //Draw the y axis of the cross hair.
            g.DrawLine(pen, 0, y, ClientSize.Width, y);

            //If clicked.
            if (clicked == true)
            {
                for (int i = 1; i <= 4; i++)
                {
                    //If enemyX position and x position of mouse are less then the enemyX position and the enemy width,
                    //and the y position of the mouse is greater than the y position of the enemy and less than the y
                    //position of the enemy and the enemy height.
                    if (x > enemyX[i] && x < enemyX[i] + enemy[i].Width && y > enemyY[i] && y < enemyY[i] + enemy[i].Height)
                    {
                        //Draw the explosion over the enemy.
                        g.DrawImage(explode, enemyX[i], enemyY[i]);
                        //Play the explosion sound file.
                        explosion.Play();
                        //Add 1 to score.
                        score += 1;
                        //Set i to "guy".
                        guy = i;
                        
                        //If user is one level 2 (score between 10 and 20).
                        if (score >= 10 && score < 20)
                        {
                            //Reverse the image.
                            enemy2[i] = rev1[i];
                            
                        }
                        //If user is on level 3(Score greater or equal to 20).
                        if (score >=20)
                        {
                            //Reverse the image. 
                            enemy3[i] = rev2[i];
                        }

                        //Call initialize
                        Initialize();
                    }
                    //If the x pos of the mouse is greater than x pos of team and the x pos of mouse is less than 
                    //x pos of team and the team width, and the y pos of the mouse is greater than the y pos of the
                    //team and less than y pos of team and the team height.
                    if (x > teamX[i] && x < teamX[i] + team[i].Width && y > teamY[i] && y < teamY[i] + team[i].Height)
                    {
                        //Draw the explosion over the team image. 
                        g.DrawImage(explode, teamX[i], teamY[i]);
                        //Play explosion sound file.
                        explosion.Play();
                        //Subtract 1 from score.
                        score -= 1;
                        //Add 1 to teamhit.
                        teamhit++;
                        //Set guy to i.
                        guy = i;

                        //If user is one level 2 (score between 10 and 20).
                        if (score >= 10 && score < 20)
                        {
                            //Reverse the image.
                            team2[i] = rev3[i];

                        }

                        //If user is on level 3(Score greater or equal to 20).
                        if (score >= 20)
                        {
                            //Reverse the image. 
                            team3[guy] = rev4[guy];
                        }
                        //Call initialize.
                        Initialize();

                    }

                }

            }
           
                           
            for (int i = 1; i <= 4; i++)
            {
                //Draw the enemy, enemyX and enemyY
                g.DrawImage(enemy[i], enemyX[i], enemyY[i]);
                //Draw the team, teamX and teamY
                g.DrawImage(team[i], teamX[i], teamY[i]);

            }
           
         
  
            //If teamhit reaches 3.
            if (teamhit == 3)
            {
                //Draw gameover text.
                g.DrawString("GAME OVER !!!", GameOverfont, blueBrush, ClientSize.Width / 2 - 200, ClientSize.Height / 2);
                //Draw restart text.
                g.DrawString("Press the Start Button to Play Again", font, yellowBrush, ClientSize.Width / 2 - 100, ClientSize.Height / 2 + 60);
                //Call stopgame.
                StopGame();
               
            }

            //If score reaches 30.
            if (score == 30)
            {
                //Draw "you win" text.
                g.DrawString("You WIN !!!", GameOverfont, blueBrush, ClientSize.Width / 2 - 150, ClientSize.Height / 2);

            }
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Call newgame
            NewGame();
            //Set teamhit to zero.
            teamhit = 0;
            //Enable timer1.
            timer1.Enabled = true;
            
            
        }
       
        private void Initialize()
        {

                 //Set enemyX to a random position.
                 enemyX[guy]= r.Next(1,10);
                 //Set enemyY to a random position.
                 enemyY[guy] = r.Next(1, 400);

                 //Set teamX to a random position. 
                 teamX[guy] = r.Next(1, 10);
                 //Set teamY to a random number.
                 teamY[guy] = r.Next(1, 400);
                 

            
             for (int i = 1; i <= 4; i++)
             {
                 //If enemy2 equals reverse enemy2.
                 if (enemy2[i] == revenemy2[i])
                 {
                     //Get out of loop.
                     break;
                 }
                 //If enemy3 equals reverse enemy3.
                 if (enemy3[i] == revenemy3[i])
                 {
                     //Get out of the loop.
                     break;
                 }
                 //If team2 equals reverse team2.
                 if (team2[i] == revteam2[i])
                 {
                     //Get out of the loop.
                     break;
                 }
                 //If team3 equals reverse team3.
                 if (team3[i] == revteam3[i])
                 {
                     //Get out of the loop.
                     break;
                 }

                 //Set enemyX respawn to a random number.
                 enemyDX[i] = r.Next(1,10);
                 //Set enemyY respawn to a random number.
                 enemyDY[i] = r.Next(1, 10);

                 //Set teamX respawn to a random number.
                 teamDX[i] = r.Next(1, 20);
                 //Set teamY respawn to a random number.
                 teamDY[i] = r.Next(1, 20);
                
             }

        }
        private void NewGame()
        {
            //Set score to zero.
            score = 0;           
            
            //Play background music.
            backgroundmusic.Play();   
            //Assign windows media player to song.wav.
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\song.wav";
         
            //Call initialize.
            Initialize();
        }

        private void StopGame()
        {
            //Disable timer1.
            timer1.Enabled = false;
            //Close windows media player. 
          axWindowsMediaPlayer1.close();
       
         
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 1; i <= 4; i++)
            {
                //Add enemyX respawn to enemyX.
                enemyX[i] += enemyDX[i];
                //Add enemyY respawn to enemyY.
                enemyY[i] += enemyDY[i];
                //Add teamX respawn to teamX.
                teamX[i] += teamDX[i];
                //Add teamY respawn to teamY.
                teamY[i] += teamDY[i];

            }


            for (int i = 1; i <= 4; i++)
            {
                //If enemyX is greater than form width - enemy width.
                if (enemyX[i] > ClientSize.Width - enemy[i].Width)
                {   //Move in opposite direction.                
                    enemyDX[i] = -enemyDX[i];
                }

                //If enemyX is less than 0.
                if (enemyX[i] < 0)
                {
                    //Move in opposite direction. 
                    enemyDX[i] = -enemyDX[i];
                }

                //If enemyY is greater than form height - enemy height.
                if (enemyY[i] > ClientSize.Height - enemy[i].Height)
                    //Move in opposite direction. 
                    enemyDY[i] = -enemyDY[i];

                //If enemyY is less than 0.
                if (enemyY[i] < 0)
                    //Move in opposite direction. 
                    enemyDY[i] = -enemyDY[i];

                //If teamX is greater than form width - team width.
                if (teamX[i] > ClientSize.Width - team[i].Width)
                    //Move in opposite direction. 
                    teamDX[i] = -teamDX[i];

                //If teamX is less than 0.
                if (teamX[i] < 0)
                    //Move in opposite direction. 
                    teamDX[i] = -teamDX[i];

                //If teamY is greater than form height - team height.
                if (teamY[i] > ClientSize.Height - team[i].Height)
                    //Move in opposite direction. 
                    teamDY[i] = -teamDY[i];

                //If teamY is less than 0.
                if (teamY[i] < 0)
                    //Move in opposite direction. 
                    teamDY[i] = -teamDY[i];

                //If user is on level 2 and enemyX is greater the form width minus enemy2 width.
                if (score >= 10 && score < 20 && enemyX[i] > ClientSize.Width - enemy2[i].Width)
                {
                    //Reverse image.
                    enemy2[i] = revenemy2[i];

                }
                //If user is on level 2 and enemyX is less than 0.
                if (score >= 10 && score < 20 && enemyX[i] < 0)
                {
                    //Reverse image.
                    enemy2[i] = rev1[i];

                }
                //If user is on level 2 and teamX is greater the form width minus team2 width.
                if (score >= 10 && score < 20 && teamX[i] > ClientSize.Width - team2[i].Width)
                {
                    //Reverse image.
                    team2[i] = revteam2[i];

                }
                //If user is on level 2 and teamX is less than 0.
                if (score >= 10 && score < 20 && teamX[i] < 0)
                {
                    //Reverse image.
                    team2[i] = rev3[i];

                }

                //If user is on level 3 and enemyX is greater than form width minus enemy3 width.
                if (score >=20 && enemyX[i] > ClientSize.Width - enemy3[i].Width)
                {
                    //Reverse image.
                    enemy3[i] = revenemy3[i];

                }
                //If user is on level 3 and enemyX is less than 0.
                if (score >= 20 && enemyX[i] < 0)
                {
                    //Reverse image.
                    enemy3[i] = rev2[i];

                }
                //If user is on level 3 and teamX is greater than form width minus team3 width.
                if (score >= 20 && teamX[i] > ClientSize.Width - team3[i].Width)
                {
                    //Reverse image.
                    team3[i] = revteam3[i];

                }

                //If user is on level 3 and teamX is less than 0.
                if (score >= 20 && teamX[i] < 0)
                {
                    //Reverse image.
                    team3[i] = rev4[i];

                }
                
                    //If score is greater than or equal to 10.
                    if (score >= 10)
                    {
                        //Background becomes bacground 2.
                        background = background2;
                        //Enemy becomes enemy2.
                        enemy = enemy2;
                        //Team becomes team2.
                        team = team2;

                    }
                    //If score is greater than or equal to 20.
                    if (score >= 20)
                    {
                        //Background 2 becomes background 3.
                        background2 = background3;
                        //Enemy2 becomes enemy3.
                        enemy2 = enemy3;
                        //Team2 becomes team3.
                        team2 = team3;

                    }

                   //Call invalidate.
                    Invalidate();

                }
            }
      

      
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Set x to mouse X.
            x = e.X;
            //Set y to mouse Y.
            y = e.Y;
            //Call invalidate.
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //If click left mouse.
            if (e.Button == MouseButtons.Left)
            {
                //Clicked becomes true.
                clicked = true;
                //Explosion timer is enabled.
                timExp.Enabled = true; 
                //Call invalidate.
                Invalidate();               
            }                               
        }

        private void timExp_Tick(object sender, EventArgs e)
        {
            //Clicked becomes false.
            clicked = false;   
            //Disable timer explosion.
            timExp.Enabled = false;   
            //Call invalidate. 
            Invalidate();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

       
    
    }
}
