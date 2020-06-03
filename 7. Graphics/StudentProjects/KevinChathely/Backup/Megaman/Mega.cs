using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;//better graphics
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;//sound
using System.IO; //for Streamreader and writer

//Variable Dictionary
//----------------------
//Image stand = used to store the "right" standing pose of megaman
//Image stand2 = used to store the "left" standing pose of megaman
//Image shot = used to store the enemy's bullet
//Image[] dragon = array used to store all the images that make the dragon fly
//Image[] dragone = array used to store all the images that make the dragon fly/glow
//Image[] polar = array used to store all the images that make the polar bear shoot crystal left
//Image[] polar2 = array used to store all the images that make the polar bear shoot crystal right
//Image[] polare = array used to store all the images that make the polar bear glow/facing left
//Image[] polare2 = array used to store all the images that make the polar bear glow/facing right
//Image[] rhino = array used to store all the images that make the rhino charge left
//Image[] rhino2 = array used to store all the images that make the rhino charge right
//Image[] rhinoe = array used to store all the images that make the rhino glow/facing left
//Image[] rhinoe2 = array used to store all the images that make the rhino glow/facing right
//Image[] heart = array used to store the heart images (same image x5)
//Image[] background = array used to store all the background images 
//Image[] images = array used to store all the images that make the megaman move right
//Image[] images2 = array used to store all the images that make the megaman move left
//Image[] images3 = array used to store all the images that make the megaman teleport in
//Image[] images4 = array used to store all the images that make the megaman shoot right
//Image[] images5 = array used to store all the images that make the megaman shoot left
//Image[] images6 = array used to store all the heart images that make megaman look as if he is hurt
//Image[] images7 = array used to store all the images that make the megaman jump right
//Image[] images8 = array used to store all the images that make the megaman jump left 
        
//int x, y = used to store the x and y position,of megaman         
//int picx = used to spread the hearts apart      
//int targetX, targetY = used to store the x and y position,of enemy
//int targetDX, targetDY = used to store the number that is added to x and y position of the enemy (basically controls the direction,movement and speed the enemy's movement) 

//int bulletX, bulletY =used to store the number of x and y position,of megaman's bullet  
//int bulletDX=used to store the number that is added to the x and y position,of megaman's bullet (basically controls the direction,movement and speed of bullet) 
//int shotX, shotY =used to store the x and y position,of the enemy's bullet  
//int shotDX, shotDY =used to store the number that is added to x and y position,of enemy's bullet (basically controls the direction,movement and speed of bullet) 

//int score = used to store the score achieved by user
//int dir = used as a flag to check which way megaman is facing
//int side = used as a flag to check which way enemy is facing
//bool flag = breaks the while loop in bubble sort (Sort())
//int chec = used as a flag to tell when to stop, in bubble sorting (Sort())
//bool hit =used to tell when megaman is hit
//bool hit2 =used to tell when enemy is hit
//bool aa = used to tell if the flashing animation of the enemy is off or on (need this or else you cant tell when to glow/prevent cheating)
//bool flag2 = used to tell if jump is initiated and if so not be able to use keys A & D
//bool flag3 = used to check if megaman is done showing his damaged animation (hurt)

//string[] name = array used to store all the names used in high score, into seperate box for each player
//int[] points = array used to store all the scores used in high score, into seperate box for each player
               
//Image bullet = Used to store the current image from the array of images of megaman's bullet. (use this when drawing, much easier this way)
//Image ship = Used to store the current image from the array of images of megaman's body. (use this when drawing, credit goes to C. Chiarelli)
//Image tbird = Used to store the current image from the array of images of Enemy's body. (use this when drawing, credit goes to C. Chiarelli)
//Image Back = Used to store the current image from the array of images of backgrounds. (use this when drawing, much easier this way)
        

//int level = counter used to tell what level the user is on
//int fir =counter used to tell which way to shoot
//int counter = counter used in highscore, reading/sorting,and writing (to tell how many users are there) 
//int count = counter used to flip through the megaman's movement right
//int count2 =counter used to flip through the megaman's movement left
//int count3 = counter used to flip through the megaman's teleportation animation
//int count4 =counter used to flip through the megaman's firing animation right
//int count5 =counter used to flip through the megaman's firing animation left
//int count6 =counter used to flip through the megaman's hurt animation
//int dir2 = counter used to tell what direction to jump at (cant be used as same as dir for various reasons)
//int p = counter used to tell how many hearts megaman has currently
//int count7 = counter used to flip through the megaman's jump
//int count8 = counter used to flip through the Enemy's animation
//int countsep = counter used to flip through the Enemy's glow animation

//Random r =  used as a Random number generator

        // Sound file strings
//SoundPlayer explosion = explosion sound when megaman is hurt
//SoundPlayer Roar = roar sound when enemy is hurt        
//SoundPlayer laser = shooting sound when laser is fired
//string temp = used as a temporary storage space for names
//int temp2 = used as a temporary storage space for scores
//string StartUpPath =used as a storage space for the application path + directory to Debug folder
//string f = used to activate reading lines from text file
//string w =used to activate writing lines from text file

namespace Megaman
{
    public partial class Mega : Form
    {
        public Mega()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }              
                    

        // Loads in all images that are used in this game
        Image stand = Image.FromFile(Application.StartupPath + @"\Images\j7.gif");
        Image stand2 = Image.FromFile(Application.StartupPath + @"\Images\j17.gif");
        Image shot = Image.FromFile(Application.StartupPath + @"\Enemy1\Snow.gif");
        //Loads in all image arrays used in this game
        Image[] dragon = new Image[17];
        Image[] dragone = new Image[17];
        Image[] polar = new Image[19];
        Image[] polar2 = new Image[19];
        Image[] polare = new Image[19];
        Image[] polare2 = new Image[19];
        Image[] rhino = new Image[30];
        Image[] rhino2 = new Image[30];
        Image[] rhinoe = new Image[30];
        Image[] rhinoe2 = new Image[30];
        Image[] heart = new Image[6];
        Image[] background = new Image[17];
        Image[] images = new Image[17];
        Image[] images2 = new Image[17];
        Image[] images3 = new Image[17];
        Image[] images4 = new Image[17];
        Image[] images5 = new Image[17];
        Image[] images6 = new Image[17];
        Image[] images7 = new Image[17];
        Image[] images8 = new Image[17]; 
        
        int x, y;        //declaring all variables
        int picx = 30;      
        int targetX, targetY;
        int targetDX, targetDY;

        int bulletX, bulletY;
        int bulletDX;
        int shotX, shotY;
        int shotDX, shotDY;

        int score;
        int dir = 1;
        int side = 1;
        bool flag = false;
        int chec;
        bool hit;
        bool hit2;
        bool aa = false;
        bool flag2;
        bool flag3;

        string[] name = new string[100];
        int[] points = new int[100];
               
        Image bullet;
        Image ship;
        Image tbird;
        Image Back;
        

        int level = 1;
        int fir;
        int counter = 0;
        int count;
        int count2;
        int count3;
        int count4;
        int count5;
        int count6;
        int dir2 = 1;
        int p = 5;
        int count7;
        int count8 = 2;
        int countsep = 2;

      
        //Random generator
        Random r = new Random();

        // Sound file strings
        SoundPlayer explosion = new SoundPlayer();
        SoundPlayer Roar = new SoundPlayer();        
        SoundPlayer laser = new SoundPlayer();

        private void Mega_Load(object sender, EventArgs e)
        {         
            hit = false;
            hit2 = false;
            score = 0;         

            targetX = 400;
            targetY = 250;
              //position until start button pressed

            bulletX = ClientSize.Width + 100;   //position bullet offscreen until needed
            bulletY = ClientSize.Height + 100;
            shotX = ClientSize.Width + 100;   //position enemy bullet offscreen until needed
            
            //loading in the pictures to all the image arrays

            for (int i = 1; i <= 3; i++)
            {
                background[i] = Image.FromFile(Application.StartupPath + @"\fire" + i.ToString() + ".png");

            }

            for (int i = 1; i <= 10; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\Images\m" + i.ToString() + ".gif");
                images2[i] = Image.FromFile(Application.StartupPath + @"\Images\me" + i.ToString() + ".gif");
            }

            for (int i = 2; i <= 18; i++)
            {
                polar[i] = Image.FromFile(Application.StartupPath + @"\Boss\polar " + i.ToString() + ".gif");
                polar2[i] = Image.FromFile(Application.StartupPath + @"\Boss\polar2 " + i.ToString() + ".gif");
            }
            for (int i = 2; i <= 6; i++)
            {
                polare[i] = Image.FromFile(Application.StartupPath + @"\Boss\polare " + i.ToString() + ".gif");
                polare2[i] = Image.FromFile(Application.StartupPath + @"\Boss\polar2e " + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 8; i++)
            {
                images3[i] = Image.FromFile(Application.StartupPath + @"\Images\e" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 11; i++)
            {
                images6[i] = Image.FromFile(Application.StartupPath + @"\Images\h" + i.ToString() + ".gif");
            }

            for (int i = 1; i <= 3; i++)
            {
                images4[i] = Image.FromFile(Application.StartupPath + @"\New Folder\s" + i.ToString() + ".gif");
                images5[i] = Image.FromFile(Application.StartupPath + @"\New Folder\s1" + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 4; i++)
            {
                dragon[i] = Image.FromFile(Application.StartupPath + @"\Boss\dragon " + i.ToString() + ".gif");
                dragone[i] = Image.FromFile(Application.StartupPath + @"\Boss\dragon " + i.ToString() + "e.gif");
                
            }
            for (int i = 5; i <= 8; i++)
            {                
                dragone[i] = Image.FromFile(Application.StartupPath + @"\Boss\dragon " + i.ToString() + "e.gif");

            }

            for (int i = 1; i <= 7; i++)
            {
                images7[i] = Image.FromFile(Application.StartupPath + @"\Images\j" + i.ToString() + ".gif");
                images8[i] = Image.FromFile(Application.StartupPath + @"\Images\j1" + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 28; i++)
            {
                rhino[i] = Image.FromFile(Application.StartupPath + @"\Enemy1\rh" + i.ToString() + ".gif");
                rhino2[i] = Image.FromFile(Application.StartupPath + @"\Enemy1\rh " + i.ToString() + ".gif");
            }
            for (int i = 1; i <= 6; i++)
            {
                rhinoe[i] = Image.FromFile(Application.StartupPath + @"\Enemy1\rhe" + i.ToString() + ".gif");
                rhinoe2[i] = Image.FromFile(Application.StartupPath + @"\Enemy1\rhes" + i.ToString() + ".gif");
            }

            for(int i = 1; i <=5; i++)
            {
                heart[i] = Image.FromFile(Application.StartupPath + @"\hrt.gif");
            }

            //putting the first image into all the image variables used when drawing the image itself
            //done so that it does not encounter "null" image error
            ship = images3[1];
            bullet = images4[1];
            tbird = polar[2];
            Back = background[2];
                        
            //loading in wav soundeffects
            Roar.SoundLocation = Application.StartupPath + @"\Sounds\Dinosaur Roar.wav";            
            laser.SoundLocation = Application.StartupPath + @"\Sounds\Laser.wav";
            explosion.SoundLocation = Application.StartupPath + @"\Sounds\hit.wav";

            Roar.LoadAsync();
            explosion.LoadAsync();            
            laser.LoadAsync();
            //gives the form focus so that the keys can work
            this.Focus(); 
        }

        private void Mega_Paint(object sender, PaintEventArgs e)
        {
            //declares the special word "Graphics" to g which is used to paint/draw all images 
            Graphics g = e.Graphics;

            DrawStuff(g); //calls up method DrawStuff and passses down the g so that "Graphics" can be used there as well
        }

        private void DrawStuff(Graphics g)
        {
            picx = 30; //done here so that picx does not continue to add on 35 from where it left off
            
            //declaring all brushes, and font used in writing 
            Font font = new Font("Arial", 9, FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Font GameOverfont = new Font("Arial", 40, FontStyle.Bold);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            
            //draws the background + score 
            g.DrawImage(Back,0,0,ClientSize.Width, ClientSize.Height);            
            g.DrawString("Current Score -> " + score.ToString(), font, yellowBrush, 5, 50);

            //this loop picks up on the variable that detects how many lives megaman has ("p")
            for (int i = 1; i <= p; i++)
            {
                g.DrawImage(heart[i], picx, 350); //draws the hearts for megaman
                picx += 35;     //used to space out the hearts
            }           

            //draws the enemy, megaman, his bullet, and enemy bullet 
            g.DrawImage(ship, x, y);
            g.DrawImage(tbird, targetX, targetY);
            g.DrawImage(bullet, bulletX, bulletY);
            g.DrawImage(shot, shotX, shotY);          


            //if an enemy is hit plays roar and turns on the flag saying it is hit
            if (hit && aa==false)
            {               
                Roar.Play();                
                aa = true;
                Initialize(); //calls up initiaize   
            }         

            //if lifepoints are over draw Gameover + to play again and play the game over sound
            if (p==0)
            {
                g.DrawString("GAME OVER !!!", GameOverfont, blueBrush, ClientSize.Width / 2 - 200, ClientSize.Height / 2);
                g.DrawString("Press the Restart Button to Play Again", font, yellowBrush, ClientSize.Width / 2 - 100, ClientSize.Height / 2 + 60);
                axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Sounds\Game Over.mp3";
                
                
            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //starts at level one with 5 lives
            level = 1;
            p = 5;
            //turns the button to restart(text)
            BtnStart.Text = "Restart";
            //done so that user cant move until certain animation is over
            KeyPreview = false;
            counter = 0; //sets the counter for naem score arrays
            NewGame();  //calls up new game method
            //enable timers that start the game
            timer1.Enabled = true;       
            
            //makes the high score table invisible
            LstDis.Visible = false;
            //play background music
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Sounds\ZXA.mp3";

        }

        private void Initialize()
        {
            //sets the hit flags and the bullets back to what the where before
            hit = false;
            hit2 = false;     

            bulletX = ClientSize.Width + 100;   //position bullet offscreen until needed
            bulletY = ClientSize.Height + 100;            
            
            //don't move bullet until L is pressed
            bulletDX = 0;
            


        }

        private void NewGame()
        {
            //starts the timer that makes megaman teleport in 
            timer4.Enabled = true;   
            //if it is last level activates the ability to move up and down 
            if(level==3)
            targetDY = 10;            
            count = 1;          //all counters are reset
            count2 = 1;
            count3 = 1;
            count4 = 1;
            count5 = 1;
            count6 = 1;
            count7 = 1;           
            x = ClientSize.Width / 3;   // positions megaman in each level
            if (level == 1)
                y = 270;
            else if (level ==3)
                y = ClientSize.Height - ship.Height - 50;
            else if (level == 2)
                y = 260;

            //reset hit flag
            hit2 = false;
            shotX = ClientSize.Width + 100;   //position enemy bullet offscreen until needed
            
            

            Initialize();//call up initialize method
        }

        private void StopGame()
        {
            //method that stops the game by turning everything off
            timer1.Enabled = false;
            TimRun.Enabled = false;            
            timer8.Enabled = false;
            timer7.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;

            //plays vic song
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Sounds\Victory.mp3";
           
            //calls up methods involved in reading writing and sorting the highscore list

            Read();            
            name[counter] = Microsoft.VisualBasic.Interaction.InputBox("Input name", "Highscore", "", 325, 267);
            points[counter] = score;
            Sort();
            Write();
            axWindowsMediaPlayer1.close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer that makes megaman move 
            if (dir == 1 && flag2 == false )
            {
                ship = images[count];
                count++;                
                x += 8;
                if (count > 10)
                    count = 1;
            }
            else if (dir == 2 && flag2 == false)
            {
                
                ship = images2[count2];
                count2++;
                if (x > 0)
                x -= 8;
                if (count2 > 10)
                    count2 = 1;
            }

            Invalidate();   //refreshes screen otherwise image wont change

        }
        

        private void Mega_KeyDown(object sender, KeyEventArgs e)
        {
            //when the control keys are pressed down:-

            
            if (e.KeyCode == Keys.D)    //starts the moving timer
            {
                
                TimRun.Start();
                dir = 1;
                dir2 = 1;
                
            }
            else if (e.KeyCode == Keys.A)
            {
                TimRun.Start();
                dir = 2;
                dir2 = 2;              
                
            }
            
            else if (e.KeyCode == Keys.L)   //stops moving and starts shooting timer
            {
                TimRun.Enabled = false;
                
                timer5.Enabled = true;
                
               if (dir == 1 && bulletX > 432)   //specific so that user cant rapid fire so easily
                    {                                               
                        fir = 1;                //flag set to tell which direction to shoot at
                        bullet = images4[1];        //bullet is displayed infront of megaman
                        bulletX = x + 35;
                        bulletY = y - 5;
                        ship = stand;           //makes megman stand still facing which ever direction he was facing
                        bulletDX = +30;
                        laser.Play();           //laser noise
                    }

                    else if (dir == 2 && bulletX > 432)
                    {
                        fir = 2;
                        bullet = images5[1];
                        bulletX = x - 35;
                        bulletY = y - 5;
                        ship = stand2;
                        bulletDX = -30;
                        laser.Play();
                    }

                    
            }
            
            else if (e.KeyCode == Keys.W)       //stops moving and starts jumping timer
            {
                TimRun.Enabled = false;         //another flag is used so that computer knows megaman is jumping
                flag2 = true;
                timer7.Start();
            }
            Invalidate(); //refreshes screen otherwise image wont change
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bulletX += bulletDX;    //main timer that checks for hits and enemy lifepoints
            shotX += shotDX;        //moves all the bullets
            shotY += shotDY;

            if (level == 3)             //on level 3 only move bullet sideways and down hence diagonally
            {
                targetX += targetDX;
                targetY += targetDY;
            }
            //if bullet reaches side without hitting target
            //move it off screen
            if (bulletX <= -30 || bulletX > 568)
            {
                bulletDX = 0;
                bulletX = ClientSize.Width + 100;
                bulletY = ClientSize.Height + 100;
            }
            //on level3 bullets go off screen at the bottom
            if (level == 3)
            {
                if (shotY > ClientSize.Height)
                {
                    shotDX = 0;
                    shotDY = 0;
                    shotX = ClientSize.Width + 100;

                }
            }            
            //level 3 has enemy moving up and down (restrictions in case of 
            if (level == 3)
            {
                if (targetX >= ClientSize.Width - tbird.Width)
                    targetDX = -targetDX;

                if (targetX <= 0)
                    targetDX = -targetDX;

                if (targetY <= 0)
                    targetDY = -targetDY;

                if (targetY >= ClientSize.Height - tbird.Height)
                    targetDY = -targetDY;

            }

            //calls up hit method
            Hit();

            Invalidate(); //refreshes screen otherwise image wont change
        }
        private void Hit()
        {
            //checks if the bullet is in fact toouching enemy + takes away lifepoints accordingly
            if ((bulletX + bullet.Width > targetX) && (bulletX < targetX + tbird.Width) && (bulletY + bullet.Height > targetY) && (bulletY < targetY + tbird.Height / 2) && (aa == false))
            {
                score += 100;
                if (level == 1)
                {
                    ProL.Value -= 25;
                    if (ProL.Value <= 0)
                    {
                        Pause();

                    }
                }
                else if (level == 2)
                {
                    ProL.Value -= 20;
                    if (ProL.Value <= 0)
                    {
                        Pause();
                    }
                }
                else
                {
                    ProL.Value -= 10;
                    if (ProL.Value <= 0)
                    {
                        StopGame();
                    }
                }

                hit = true;
            }

            //on levels 1,3 enemy fire is accounted for as well
            if (level == 3 || level == 1)
            {
                if (((targetX + tbird.Width > x) && (targetX < x + ship.Width) && (targetY / 2 + tbird.Height > y) && (targetY < y + ship.Height) && (hit2 == false) && (flag3 == false)) || ((shotX + shot.Width > x) && (shotX < x + ship.Width) && (shotY + shot.Height > y) && (shotY < y + ship.Height)) && timer6.Enabled == false)
                {
                    hit2 = true;
                    if (level == 3)
                        shotX = ClientSize.Width + 100;   //position bullet offscreen until needed
                    TimRun.Enabled = false;
                    timer6.Enabled = true;
                    y -= 10;
                    score -= 50;
                    Damage();
                }
            }
            if (level == 2)
            {
                if ((targetX - 20 + tbird.Width > x) && (targetX + 20 < x + ship.Width) && (targetY + tbird.Height > y) && (targetY + 50 < y + ship.Height) && (hit2 == false) && (flag3 == false) && timer6.Enabled == false)
                {
                    hit2 = true;
                    TimRun.Enabled = false;
                    timer6.Enabled = true;
                    y -= 10;
                    score -= 50;
                    Damage();
                }
            }
        }       

        private void timer4_Tick(object sender, EventArgs e)
        {
            //timer that shows animation of megaman teleporting in
            ship = images3[count3];
            count3++;
            if (count3 > 8)
            {
                count3 = 1;
                ship = stand;                
                x += 8; //for positioning accuratly
                y += 20;
                KeyPreview = true;  // now the user can use the keys to move
                timer8.Enabled = true;  //so does the enemy
                timer4.Stop();       //stops this timer or else megaman will keep teleporting in 
          
            }
            Invalidate(); //refreshes screen otherwise image wont change
        }

        private void Mega_KeyUp(object sender, KeyEventArgs e)
        {
         //makes it so that the timer that make megaman animation move, stop + show him standing     
            if (e.KeyCode == Keys.D)
            {
                TimRun.Enabled = false;
                ship = stand;
            }
           if (e.KeyCode == Keys.A)
           {
               TimRun.Enabled = false;
               ship = stand2;                
            }
               
        }
        
        private void timer5_Tick(object sender, EventArgs e)
        {
            //timer that does bullet animation + checks and shoots at right direction (fir)
            if (fir == 1)
            {            
                    bullet = images4[count4];
                    count4++;
                    if (count4 > 3)
                        count4 = 1;             
                

            }
            else if (fir ==2)
            {

                bullet = images5[count5];
                count5++;
                if (count5 > 3)
                count5 = 1;                    
                
            }
            if (bulletX == ClientSize.Width + 100)   //once bullet dissapears to that location i set stop this timer. 
                timer5.Enabled = false;
            Invalidate(); //refreshes screen otherwise image wont change
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //timer that shows megaman in pain(animation)
            //also uses flag to denote that he is hit and that other hits that occur during animation will not count 
            //user cant move at this point
            KeyPreview = false;
            TimRun.Stop();
            flag3 = true;
            ship = images6[count6];
            count6++;
            if (count6 > 11)
            {
                count6 = 1;
                y += 10;
                ship = stand;                
                KeyPreview = true;                
                timer6.Stop();
                flag3 = false;
                hit2 = false;
                                
            }
            Invalidate(); //refreshes screen otherwise image wont change
        }

        
        private void Damage()
        {
            //damage method that subtracts megamans life and stops game when it reaches 0
            explosion.Play();                
                p--;
                if (p == 0)
                {
                    StopGame();
                }

        }

        

        private void timer7_Tick(object sender, EventArgs e)
        {
            //timer that shows jumping animation + uses many flags to make sure he is able to jump
                       
            if (dir2 == 1 && flag3 == false)        //makes sure he jumps toward the right direction
                ship = images7[count7];

            else if (dir2 == 2 && flag3== false)
                ship = images8[count7];

            if (count7 < 4)
            {
                if (dir2 == 1)
                {
                    x += 15;
                    y -= 32;
                }
                else if (dir2 ==2)
                {
                    if(x>0)
                    x -= 15;
                    y -= 32;
                }
            }

            else if (count7 >= 4 && count7 <= 6)
            {
                if (dir2 == 1)
                {
                    x += 15;
                    y += 32;
                }
                else
                {
                    if(x>0)
                    x -= 15;
                    y += 32;
                }

            }
                count7++;
            if (count7 > 6 && flag3==false)
            {
                
                count7 = 1;
                if (dir2 == 1)      //once he lands show standing pose at the right direction
                    ship = stand;
                else if (dir2 ==2)
                    ship = stand2;
                flag2 = false;

                timer7.Stop();  //stop timer after the one jump
            }
            Invalidate(); //refreshes screen otherwise image wont change
        }

        private void Read()
        {
            //method that uses streamreader to read the Score text file in Debuf folder
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\Score.txt";
            StreamReader r = new StreamReader(f);
            string line1, line2;
            bool finished = false;



            while (!finished)
            {
                line1 = r.ReadLine();
                line2 = r.ReadLine();

                // Reads each line of data file


                //Loop that checks to see if it is done reading, if not keep storing info into each variable array
                //Counter goes up by one each time to store each of the gamer's info in their own seperate array box 

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    counter++;
                    name[counter] = line1;
                    points[counter] = Convert.ToInt32(line2);

                }

            }
            r.Close();  //close the streamreader so that streamwriter can be used next
            counter++;  //does this to make it so that there exists one more member which will be the current user
        }

        private void Write()
        {
            //method that writes in all members and their scores over again on to the text file
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\Score.txt";
            StreamWriter w = new StreamWriter(f);

            
            for (int i = 1; i <= counter; i++)
            {
                w.WriteLine(name[i].ToString());
                w.WriteLine(points[i].ToString());

            }

            w.Close();
            //display all the users + score in a nice and orderly format
            LstDis.Items.Add("_______________________________________________________________________________");
            LstDis.Items.Add("");
            LstDis.Items.Add("                       " + "HIGH SCORE");
            LstDis.Items.Add("");
            for (int i = 1; i <= counter; i++)
            {
                LstDis.Items.Add(name[i].ToString()); 
                LstDis.Items.Add(points[i].ToString());
                LstDis.Items.Add("");
            }
            LstDis.Visible = true;  //makes the highscore visible
        }
        
        private void Sort()
        {
            //sorting method that sorts all the users from highest score to lowest
            int temp;
            string temp2;
                       
            while (flag != true)
            {
                chec = 0;
                for (int i = 1; i <= counter-1; i++)
                {
                    //bubble sort that i came up with
                    if (points[i] < points[i+1])
                    {
                        temp = points[i + 1];
                        temp2 = name[i + 1];
                        points[i+1] = points[i];
                        name[i + 1] = name[i];
                        points[i] = temp;
                        name[i] = temp2;
                        chec = 1;   //checks if any of them where switched
                    }                        
                }

                if (chec == 0)  //if not then sort is done so break away from the loop
                    flag = true;
            }
        }


       
        
        private void timer8_Tick_1(object sender, EventArgs e)
        {
            //important timer that calls methods depending on level, so that the particular enemy can do its job(move, shoot etc)
            if (level == 1)
            {
                Polar();
            }
            else if (level ==2)
            {
                Rhino();
            }
            else if (level ==3)
            {
                Dragon();
            }

            Invalidate(); //refreshes screen otherwise image wont change

        }        
        
        private void Dragon()
        {
            //the level three boss movement + shooting 
            if (aa == true) //flag saying he is hit so make him glow 
            {
                tbird = dragone[countsep];
                countsep++;
                if (countsep > 8)
                {
                    countsep = 1;
                    aa = false;
                }
            }

            if (aa == false)
            {
                tbird = dragon[count8];
                count8++;
                if (count8 > 4)
                    count8 = 1;
            }


            if (shotX == 660) //when enemy bullet is of scrren call it up and shoot again
            {
                shotX = targetX + 20;
                shotY = targetY + r.Next(50, 110);
            }
            shotDX = -20;
            shotDY = +20;   //makes bullet go diagonally
        }
        private void Polar()
        {
            //the level 1 boss movement(appears from either side of screen) + shooting only
            Bear(); //method that holds that animation to make him glow when hit

            if (side == 1)
            {
                if (aa == false)
                {
                    tbird = polar[count8];
                    count8++;
                    if (count8 > 18)
                    {
                        shotDX = 0;                        
                        shotX = ClientSize.Width + 100;
                        count8 = 2;
                    }
                }
                if ((shotX == 660) && (tbird == polar[18] || tbird == polar2[18]))
                {
                    shotX = targetX + 20;
                    shotY = targetY + tbird.Height - shot.Height;
                }
                shotDX = -18; 
            }
            if (side == 2)
            {
                if (aa == false)
                {
                    tbird = polar2[count8];
                    count8++;
                    if (count8 > 18)
                    {
                        shotDX = 0;                        
                        shotX = ClientSize.Width + 100;
                        count8 = 2;
                    }
                }
                if ((shotX == 660) && (tbird == polar[18] || tbird == polar2[18]))
                {
                    shotX = targetX + tbird.Width - 20;
                    shotY = targetY + tbird.Height - shot.Height;
                }
                shotDX = +18;
            }
                       
        }
        private void Rhino()
        {
            //level 2 boss hit + glow
            if (aa == true && side == 1)
            {
                tbird = rhinoe[countsep];
                countsep++;
                if (countsep > 6)
                {
                    countsep = 1;
                    aa = false;
                }
            }

            if (aa == true && side ==2)
            {
                tbird = rhinoe2[countsep];
                countsep++;
                if (countsep > 6)
                {
                    countsep = 1;
                    aa = false;
                }
            }

            Horn();//method to make him move
        }

        private void Horn()
        {
            //level 2 boss movement
                if (aa == false && side==1)
                {
                    tbird = rhino[count8];
                    count8++;
                    targetX -= 18;                    
                    if (count8 > 28)
                    {                        
                        count8 = 1;
                        side = 2;
                    }
                }               
                
            
            
                if (aa == false && side ==2)
                {
                    tbird = rhino2[count8];
                    count8++;
                    targetX += 18;
                    if (count8 > 28)
                    {                        
                        count8 = 1;
                        side = 1;
                    }
                }                              
            
        }

        private void level3MagmaDragoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu level 3 is selected call up the level 3 method
            Lvl3();
            
        }
        private void Bear()
        {
            //level 1 boss hit + glow
            if (aa == true)
            {
                shotX = ClientSize.Width + 100;
                shotDX = 0;
                if (side == 1)
                {
                    tbird = polare[countsep];
                    countsep++;
                    if (countsep > 6)
                    {
                        countsep = 2;
                        side = r.Next(1,3);
                        if (side == 2)
                        {
                            shot = Image.FromFile(Application.StartupPath + @"\Enemy1\Snow2.gif");
                            targetX = 0;
                        }
                        aa = false;
                    }
                }
                else
                {
                    
                    tbird = polare2[countsep];
                    countsep++;
                    if (countsep > 6)
                    {
                        countsep = 2;
                        side = r.Next(1, 3);
                        if (side == 1)
                        {
                            shot = Image.FromFile(Application.StartupPath + @"\Enemy1\Snow.gif");
                            targetX = 400;
                        }
                        aa = false;
                    }
                }

            }
        }

        private void level2RockyCanyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu level 2 is selected call up the level 2 method
            Lvl2();            
        }

        private void Pause()
        {
            //used when boss is defeated
            //disables movement + bullet damage only, enemy still moves (because i want them to, no glitch)
            timer1.Enabled = false;
            BtnLvl.Visible = true;//button becomes visible
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when clicked sends u to the next level bby calling the right lvl method
            timer1.Enabled = true;
            if (level == 2)
                Lvl3();
            else if (level == 1)
                Lvl2();            
            BtnLvl.Visible = false;
        }
        private void Lvl1()
        {
            //sets all the variables that are diff for each boss to its preference. eg polar bear shoots snow , and array starts at 2 not 1
            ProL.Value = 100;   //full health bar for the boss
            side = 1;
            level = 1;
            count8 = 2;
            countsep = 2;
            shot = Image.FromFile(Application.StartupPath + @"\Enemy1\Snow.gif");
            shotX = ClientSize.Width + 100;
            shotDX = 0;
            targetX = 400;
            targetY = 270;
            tbird = polar[2];
            Back = background[2];   //own background
            NewGame();
        }
        private void Lvl2()
        {
            //sets all the variables that are diff for each boss to its preference
            ProL.Value = 100; //full health bar for the boss
            side = 1;
            level = 2;
            count8 = 1;
            countsep = 1;
            shotX = ClientSize.Width + 100; //put away the bullets since it doesnt use any
            shotDX = 0;
            targetX = ClientSize.Width - 100;
            targetY = 250;
            tbird = rhino[1];
            Back = background[3];//own background
            NewGame();
        }
        private void Lvl3()
        {
            //sets all the variables that are diff for each boss to its preference
            ProL.Value = 100;//full health bar for the boss
            level = 3;
            count8 = 1;
            countsep = 1;
            targetX = 300;
            targetY = 5;
            tbird = dragon[1];
            shot = Image.FromFile(Application.StartupPath + @"\Boss\bullet.gif");//different bullet
            Back = background[1];//own background
            NewGame();
        }

        private void level1IceLandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when menu level 1 is selected call up the level 1 method
            Lvl1();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form close menu button
            this.Close();
            timer8.Enabled = false;
            timer1.Enabled = false;
            axWindowsMediaPlayer1.URL = null;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //help menu button, calls the intro form again so user can see controls
            timer1.Enabled = false;
            timer8.Enabled = false;
            Mega2 l = new Mega2();
            l.ShowDialog();
        }

        
      
    }

}
