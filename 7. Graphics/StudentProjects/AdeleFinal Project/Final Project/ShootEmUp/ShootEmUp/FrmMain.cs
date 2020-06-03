using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;//added to use double buffering
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;//added to use sounds
using System.IO;//added to use data files

namespace Shooter
{
    public partial class frmMain : Form
    {
        //********************************VARIABLE DICTIONARY*****************************************************
        /* Background: The image to be put behind everything else.
         * Bullet: Image that will be shot from the character's gun
         * bulletx: Stores the bullets' x coordinates
         * bullety: Stores the bullets' y coordinates
         * bulletspeed: Stores how fast the bullet is going, or if it's not moving at all
         * bulletcount: allows up to three bullets to be fired at once
         * score: how many points the player has accumulated. It is a public int to allow the other form to access it.
         * Animate: The array of images used in the animated Hero character
         * hero: stores the hero's current frame
         * Baddie: the 4 baddies
         * AniCount: Which frame is the hero's animation on? Used to animate the hero
         * badx: the x coordinate of the bad guys
         * bady: the y coordinate of the bad guys
         * herox: the hero's x coordinate
         * Heroy: the hero's y coordinate
         * lives: how many times the player can get hit before game over
         * x: the background's x coordinate
         * y: the background's y coordinate
         * r: a random number generator to determine where the bad guys go
         * game: a bool to tell if the game is running or not.
         * hit: used to see if any of the bad guys have been hit
         * backgroundmusic: the music to be played in the background
         * shot: The gunshot noise
         * g: enables use of graphics
         * speed: Int that stores how fast the background + baddies move. Over time gets faster and therefore increases the difficulty
         * font: Papyrus font to be used in the case of a GAME OVER
         * brush: Allows for drawing strings along with font
         * gOver:bool to see if there has been a gameover
         * drawOver:bool to check that "GAME OVER" has been drawn on the screen
         * */
        public frmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            // here i enable double buffering to reduce flicker
        }

        Image Background = Image.FromFile(Application.StartupPath + @"\L.Png");//loading in the background

        Image[] Bullet = new Image[4];//this is set to four to allow three bullets to be shot at once.

        
        //keeping track of the bullet, and how fast it goes
        int[] bulletx = new int[4];
        int[] bullety = new int[4];
        int[] bulletspeed= new int[4];
        //as well as counting how many bullets have been shot.
        int bulletcount=1;//this is initialized as one so that the player starts with their first bullet
        int score;       
        

        Image[] Animate = new Image[6];
        Image hero;
        
        Image[] baddie= new Image[5];//this is 5 because there will be 4 enemies
        
        
        int AniCount = 1;//Chiarelli ... should start at 1 not 0 (Thank you for the fix)
        
        //these are used for animating both the character and the baddie.

        int[] badx = new int[5];
        int[] bady = new int[5];
        
         
        //the location of the 4 bad guys.
        

        int herox, heroy;
        //location of the hero.

        int lives;
        //for keeping track ofhow many times you have been hit.
        

        int x, y;
        //used for scrolling the background

        Random r = new Random();//used for generating any random numbers

        bool game = false;//used to tell if the game is running or not
        bool[] hit = new bool[5];//used to tell if any of the imps have been hit
        
        SoundPlayer backgroundmusic = new SoundPlayer();
        SoundPlayer shot = new SoundPlayer();

        int speed;//how fast the baddies and background move, gets harder over time

        Font font = new Font("Papyrus", 30);
        SolidBrush brush = new SolidBrush(Color.Red);

        bool gOver;
        

        private void DrawStuff(Graphics g)
        {

            if (x > 400 || x < -400)
                x = 0;

            if (y > 1601 || y < -1601)
                y = 0;
            //used to scroll the background

            for (int i = -40; i < 40; i += 40)
            {
                for (int j = -1601; j < 1601; j += 1601)
                {
                    g.DrawImage(Background, x + i, y + j);

                    //for (int z = 1; z <= 4; z++)
                    //{
                    //    g.DrawImage(baddie[z], badx[z], bady[z]); //draw the baddies

                    //}

                }
            }
            //from the scrolling Baby Game, I modified it to fit the background image that I made
            
            for (int i = 1; i <= 4; i++)
            {
                g.DrawImage(baddie[i],badx[i],bady[i]); //draw the baddies
                if (hit[i] == true)
                {
                    AddPoints(i);
                    hit[i] = false;
                }
            }
            for (int b = 1; b <= 3; b++)
            {
                g.DrawImage(Bullet[b], bulletx[b], bullety[b]);//draws each of the 3 possible bullets
            }

            g.DrawImage(hero, herox, heroy); //draw the hero at the coordinates

            if (gOver == true)
            {
                g.DrawString("GAME OVER", font, brush, 40, 90);
            }

        }
        
        

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //must use this to create graphics
            
            DrawStuff(g);
            //sends g to be used in actually drawing everything.
        }

        private void NewGame()
        {
            WMPMusic.URL = Application.StartupPath + @"\Encore.MP3";//starting the music
            lives = 3;//resetting to full hit points
            score = 0;//resetting score to zero

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            txtPoints.Text = "0";
            
            //starting all timers
            herox = this.Width / 3;
            heroy = this.Width-85;
            hero = Animate[1];
            game = true;
            speed = 6;
            for (int x = 1; x <= 4; x++)
            {
                badx[x] = x * 50;
                bady[x] = baddie[x].Height - this.Height;

            }
            bulletcount = 1;//setting bullet one to be shot first
            for (int b = 1; b <= 3; b++)
            {                
                bulletx[b] = -100;
                bullety[b] = -100;
                bulletspeed[b] = 0;
                //starting all of the bullets offscreen and stationary
            }
            lblInstructions.Visible = false;
            lblInstructions2.Visible = false;
            lblInstructions3.Visible = false;
            
            gOver = false;
            
        }

        private void StopGame()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            //stopping all the timers

            WMPMusic.close();
            //and ending the music
            game = false;

            
        }

        

        private void FrmMain_Load(object sender, EventArgs e)
        {

            score = 0;
            lives = 3;
            herox = this.Width / 3;
            heroy = this.Height-75;
            
            

            //Chiarelli Fix
            //Mistake here ... can't assign hero Animate[1] ... you haven't loaded them in yet
            //do it after you load them in
            
            for (int x = 1; x <= 5; x++)
            {
                Animate[x] = Image.FromFile(Application.StartupPath + @"\Jake" + x.ToString() + ".PNG");
            }

            //assign hero here not before... Chiarelli(thanks for this fix too!)
            hero = Animate[1];

            for (int i = 1; i <= 4; i++)
            {
                baddie[i] = Image.FromFile(Application.StartupPath + @"\Imp1.PNG");
                badx[i] = -300;
                bady[i] = -300;
            }
            for (int b = 1; b <= 3; b++)
            {
                Bullet[b] = Image.FromFile(Application.StartupPath + @"\bullet.PNG");
                bulletx[b] = -300;
                bullety[b] = -300;
            }

            
            
            backgroundmusic.SoundLocation = Application.StartupPath + @"\Encore.MP3";
            shot.SoundLocation = Application.StartupPath + @"\Gunshot.wav";


            backgroundmusic.LoadAsync();
            shot.LoadAsync();


            this.Focus();//must focus the form in order to use the keys.
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (game == false)
            {
                NewGame();
            }
            else if (game)
            {
                StopGame();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hero = Animate[AniCount];
            AniCount++;
            if (AniCount >= 5)
                AniCount = 1;
            //standard animation, used for the hero. 
                  
            Invalidate();//force a redraw
             
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y += speed;//scrolls the background

            for (int b = 0; b <= 3; b++)
            {
                bullety[b] += bulletspeed[b];
                //moves the bullet depending on its speed
                //if it's off screen, and the speed is 0 then it just won't move.
                if (bullety[b] <= 0)
                {
                    bulletspeed[b] = 0;
                    bulletx[b] = ClientSize.Width + 100;
                    bullety[b] = ClientSize.Height + 100;
                    //if the bullet goes off screen, move it to the side and set the speed to 0
                }

            }
            for (int m = 0; m <= 4; m++)//for moving the baddies
            {
                bady[m] += speed;
                //this makes it look as if they move with the background.
                
                badx[m] += r.Next(-3, 4);
                //also moves the baddie side to side randomly


            }


            //below codes for displaying how many lives the player has left.
            //it will turn hearts empty for however many hits the player has taken.
            DrawLives();
            Invalidate();
        }
        private void DrawLives()
        {
            if (lives == 3)
            {
                picHeart.Image = Image.FromFile(Application.StartupPath + @"\Heart.PNG");
                picHeart2.Image = Image.FromFile(Application.StartupPath + @"\Heart.PNG");
                picHeart3.Image = Image.FromFile(Application.StartupPath + @"\Heart.PNG");
            }
            else if (lives == 2)
            {
                picHeart.Image = Image.FromFile(Application.StartupPath + @"\EmptyHeart.PNG");
                picHeart2.Image = Image.FromFile(Application.StartupPath + @"\Heart.PNG");
                picHeart3.Image = Image.FromFile(Application.StartupPath + @"\Heart.PNG");
            }
            else if (lives == 1)
            {
                picHeart.Image = Image.FromFile(Application.StartupPath + @"\EmptyHeart.PNG");
                picHeart2.Image = Image.FromFile(Application.StartupPath + @"\EmptyHeart.PNG");
                picHeart3.Image = Image.FromFile(Application.StartupPath + @"\Heart.PNG");
            }
            else if (lives == 0)
            {
                picHeart.Image = Image.FromFile(Application.StartupPath + @"\EmptyHeart.PNG");
                picHeart2.Image = Image.FromFile(Application.StartupPath + @"\EmptyHeart.PNG");
                picHeart3.Image = Image.FromFile(Application.StartupPath + @"\EmptyHeart.PNG");

                StopGame();
                GameOver();
                                
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            for (int i = 1; i <= 3; i++)
            {
                for (int z = 1; z <= 4; z++)
                {

                    if (((bulletx[i] + Bullet[i].Width) > badx[z]) && (bulletx[i]+Bullet[i].Width < badx[z] + 50) && (bullety[i] + Bullet[i].Height > bady[z]) && (bullety[i]< bady[z] + 60) && (hit[z] == false))
                        //in this line I had to change baddie.Height and baddie.Width to numbers because when I used .Width and .Height, the hitboxes got much larger than the actual targets.

                    {
                        // baddie[z] has been hit

                        bady[z] = -(baddie[z].Height + r.Next(1, 201));
                        //move the baddie back to the top of the screen plus a random amount extra
                        hit[z] = true;
                        //activate the hit flag
                        
                    }
                    // check for moving off bottom
                    if (bady[z]  > this.Height)
                    {
                        // object [i] reaches bottom without being hit                    
                        bady[z] = -(baddie[z].Height + r.Next(1, 201));
                        lives--;
                        //move the baddie back to the top of the screen plus a random amount extra
                        //and also takes away one life

                    }                                        
                }                             

            }
            
            


        }
        private void AddPoints(int h)
        {
            score += 10;
            txtPoints.Text = score.ToString();
            

        }

        private void GameOver()
        {
            gOver = true;
            Invalidate();            
            MessageBox.Show("Your score was " + score.ToString() + " points!");
            Shooter.GlobalClass.GlobalVar = score;
            FrmHighscore hi = new FrmHighscore();
            hi.Show();

        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (game == true)
            {
                if (e.KeyCode == Keys.W)
                {

                    bulletx[bulletcount] = herox + 5;
                    bullety[bulletcount] = heroy - 20;
                    bulletspeed[bulletcount] = -10;
                    if (bulletcount < 3)
                    {
                        bulletcount++;
                    }
                    else if (bulletcount >= 3)
                    {
                        bulletcount = 1;
                    }

                    shot.Play();
                }
                if (e.KeyCode == Keys.A)
                {
                    if (herox <= x)
                        herox = x;
                    else
                        herox -= 5;
                }
                if (e.KeyCode == Keys.D)
                {
                    if (herox + hero.Width >= Background.Width)
                        herox = Background.Width - hero.Width;
                    else
                        herox += 5;
                }

                Invalidate();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            speed++;
            //start to amp up the difficulty every time timer 4 ticks
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHighscore x = new FrmHighscore();
            x.Show();
        }

       

        

        

       

        
        

        
    }
}
