using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;//added for double buffering 
using System.Media;//needed for sound effects

namespace FMACatCatcher
{
    public partial class frmgame : Form
    {
        public frmgame()
        {
            InitializeComponent();
            //Enables double buffering
            this.DoubleBuffered = true;
        }
        /*VARIABLE DICTONARY
         * al: an array which hold the different 'happiness' levels of Al in the corner
         * alrighted: a sound where Ed says alright
         * awwwmaned: a sound where Ed says aww man
         * background: holds the background image
         * cat: an array that will display all of the cats images on screen 
         * catleft: An array that holds the animated images of the cat walking left
         * catright: An array that holds the animated images of the cat walking right
         * catx and caty: arrays that respectively hold the x and y positions of the cats
         * countdown: hold the time left in the game
         * countercat: counter used to go through cats animations
         * countered: counter used to go through Ed's animations
         * direction: random number generatior for figuring out the directions of the cats
         * dog: holds the dog's image
         * dogsound: used to hold a random number which is used to chose a sound to play when the dog is hit
         * dogx and dogy: respectively hold the x and y position of the dog
         * ed: displays the image of Ed on the screen
         * edleft: An array that holds the animated images of Ed walking left
         * edright: An array that holds the animated images of Ed walking right
         * edsound: used to hold a random number which is used to chose a sound to play when a cat is hit
         * edx and edy: respectively hold the x and y position of Ed
         * flag: bool  used to tell is button is on "Start" or "Stop"
         * gotchaed: a sound where Ed says gotcha
         * hit: bool used to tell if an animal has been hit or not
         * laughal: a sound where Al laughs
         * leftright: keeps track of Ed's direction
         * leftrightcat: an array that keeps track of all the cat's directions
         * meow: A sound where a cat meowa
         * number: random number generatior for figuring out many things; the sound each character 
         *         will randomly make when something is hit, the direction of the cats, and where 
         *         the cats and dog will randomly appear                
         * puppy: A sound where a puppy barks
         * randomdirection: used to hold a random number which is used to chose a direction for each cat
         * score: hold the score, or number of cats caught
         * thatticklesal: A sound where Al says that tickles
         */

        //varables used throughout the game (explained in varable dictionary
        Image background = Image.FromFile(Application.StartupPath + @"\pictures\background.bmp");

        Image ed;
        Image[] edleft = new Image[9];
        Image[] edright = new Image[9];
        int edx, edy;

        Image[] cat = new Image[6];
        Image[] catleft = new Image[7];
        Image[] catright = new Image[7];
        int[] catx = new int[6];
        int[] caty = new int[6];

        Image dog = Image.FromFile(Application.StartupPath + @"\pictures\dog.gif");
        int dogx, dogy;

        Image[] al = new Image[4];

        Random number = new Random();
        Random direction = new Random();

        string leftright;
        string[] leftrightcat = new string[6];

        int countered;
        int countercat;

        int edsound;
        int dogsound;

        int score = 0;
        int countdown = 60;
        int randomdirection;
        
        bool hit;
        bool flag;

        SoundPlayer alrighted = new SoundPlayer();
        SoundPlayer meow = new SoundPlayer();
        SoundPlayer gotchaed = new SoundPlayer();

        SoundPlayer laughal = new SoundPlayer();
        SoundPlayer thatticklesal = new SoundPlayer();

        SoundPlayer awwwmaned = new SoundPlayer();
        SoundPlayer puppy = new SoundPlayer();        


        private void frmgame_Load(object sender, EventArgs e)
        {
            //finds and loads in Ed walking animation
            for (int i = 1; i <= 8; i++)
            {
                edleft[i] = Image.FromFile(Application.StartupPath + @"\pictures\edl" + i.ToString() + ".gif");
                edright[i] = Image.FromFile(Application.StartupPath + @"\pictures\edr" + i.ToString() + ".gif");
            }

            //finds and loads in Al animations
            for (int i = 1; i <= 3; i++)
            {
                al[i] = Image.FromFile(Application.StartupPath + @"\pictures\al" + i.ToString() + ".gif");
            }

            //finds and loads in cat walking animation
            for (int i = 1; i <= 6; i++)
            {
                catleft[i] = Image.FromFile(Application.StartupPath + @"\pictures\catl" + i.ToString() + ".gif");
                catright[i] = Image.FromFile(Application.StartupPath + @"\pictures\catr" + i.ToString() + ".gif");
            }

            //finads and loads in all cats direction at game start
            for (int i = 1; i <= 5; i++)
            {
                cat[i] = catright[i];
                leftrightcat[i] = "right";
            }

            //figures out the random areas the cats will appear
            for (int i = 1; i <= 5; i++)
            {
                catx[i] = number.Next(10, 901);
                caty[i] = number.Next(20, 571);
            }

            //places Ed in the middle of the form at the start

            edx = this.Width / 2;
            edy = this.Height / 2;

            //this places the dog off-screen for the start of the game
            dogx = -100;
            dogy = -100;
            
            //makes Ed start off facing right 
            ed = edright[1];
            countered = 1;
            leftright = "right";
            
            //sets animation counters for the game start
            countercat = 1;
            countered = 1;

            //tells computer nothing has been hit yet
            hit = false;

            //finds all the sounds used in the game screen
            alrighted.SoundLocation = Application.StartupPath + @"\musicandsounds\alrighted.wav";
            meow.SoundLocation = Application.StartupPath + @"\musicandsounds\meow.wav";
            gotchaed.SoundLocation = Application.StartupPath + @"\musicandsounds\gotchaed.wav";

            laughal.SoundLocation = Application.StartupPath + @"\musicandsounds\laughal.wav";
            thatticklesal.SoundLocation = Application.StartupPath + @"\musicandsounds\thatticklesal.wav";

            awwwmaned.SoundLocation = Application.StartupPath + @"\musicandsounds\awwmaned.wav";
            puppy.SoundLocation = Application.StartupPath + @"\musicandsounds\puppy.wav";

            //loads in all the sounds
            alrighted.Load();
            meow.Load();
            gotchaed.Load();

            laughal.Load();
            thatticklesal.Load();

            awwwmaned.Load();
            puppy.Load();

            //tells the computer to be alert to key strokes
            this.Focus();             
        }

        private void frmgame_Paint(object sender, PaintEventArgs e)
        {
            //allows for graphics to be draw on the form
            Graphics g = e.Graphics;

            //calls method that draws everything in the form
            redraw(g);
        }

        private void redraw(Graphics g)
        {

            //sets font and colour that can be chosen for the writing on the game form
            Font main = new Font("Comic Sans MS", 18, FontStyle.Bold);
            SolidBrush red = new SolidBrush(Color.Red);

            //draws in background, Ed, the dog, and the array of cats
                g.DrawImage(background, 0, 0);
                g.DrawImage(ed, edx, edy);
                g.DrawImage(dog, dogx, dogy);
                for (int i = 1; i <= 5; i++)
                {
                    g.DrawImage(cat[i], catx[i], caty[i]);
                }

                //changes the 'happiness' of Al in the corner 
                //depending on how many cats you have
                if (score >= 0 && score <= 10)
                {
                    g.DrawImage(al[1], 815, 482);
                }
                else if (score >= 11 && score <= 19)
                {
                    g.DrawImage(al[2], 815, 482);
                }
                else if (score >= 20)
                {
                    g.DrawImage(al[3], 815, 482);
                }

                
            //draws the writting on the form that displays the number of 
            //cats caught and the time left
                g.DrawString("Cats:" + score.ToString(), main, red, 735, 545);
                g.DrawString("Time Left:" + countdown.ToString(), main, red, 5, 545);
            //if you caught something, resets the hit value to false (so 
            //things can be caught again) and resets the area the dog pops up 
                if (hit)
                {
                    hit = false;

                    dogx = number.Next(10, 901);
                    dogy = number.Next(20, 571);
                }
            
        }

        private void edtimer_Tick(object sender, EventArgs e)
        {
            //animates Ed walking left or right depending on the direction he is facing
            if (leftright == "left")
            {
                ed = edleft[countered];
                countered++;
                if (countered > 8)
                    countered = 1;

                Invalidate();
            }
            else if (leftright == "right")
            {
                ed = edright[countered];
                countered++;
                if (countered > 8)
                    countered = 1;

                Invalidate();
            }
        }

        private void frmgame_KeyDown(object sender, KeyEventArgs e)
        {
            //assigns the keys used to move Ed, as long as the start button has been pressed
            //also changes what direction Ed is facing depending on the direction he is walking
            if (flag == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    leftright = "right";
                    edy -= 6;
                }
                else if (e.KeyCode == Keys.S)
                {
                    leftright = "left";
                    edy += 6;
                }
                else if (e.KeyCode == Keys.A)
                {
                    leftright = "left";
                    edx -= 6;
                }
                else if (e.KeyCode == Keys.D)
                {
                    leftright = "right";
                    edx += 6;
                }
            }

            Invalidate();
        }

        private void hittimer_Tick(object sender, EventArgs e)
        {
            //method that checks if Ed has hit an animal or the wall
            collision();
        }
        private void collision()
        {
            //makes sure ed can't walk off screen
            if (edy > this.Height - 180)
            {
                edy = this.Height - 180;
            }
            else if (edx > this.Width - 80)
            {
                edx = this.Width - 80;
            }
            else if (edy < 20)
            {
                edy = 20;
            }
            else if (edx < 10)
            {
                edx = 10;
            }

            //checks of ed has hit the dog 
            if (edx + ed.Width > dogx && edx < dogx + dog.Width && edy + ed.Height > dogy && edy < dogy + dog.Height && hit == false)
            {
                //if he has, resets the dogs position
                dogx = number.Next(10, 901);
                dogy = number.Next(20, 571);
                //minus 3 cats from the score
                score -= 3;
                //makes sure you can't have negative amount of cats
                if (score == -1 || score == -2 || score== -3)
                {
                    score = 0;
                }

                //plays random dog catching sound
                dogsound = number.Next(1, 3);

                if (dogsound == 1)
                {
                    awwwmaned.Play();
                }

                else if (dogsound == 2)
                {
                    puppy.Play();
                }
                //tells the computer you have hit something (the dog)
                hit = true;
                Invalidate();
            }
           //checks to see if Ed hit a cat
            for (int t = 1; t <= 5; t++)
           if(edx+ed.Width>catx[t] &&edx<catx[t]+cat[t].Width && edy+ed.Height>caty[t] && edy<caty[t]+cat[t].Height && hit==false)
            {
               //if he has, resets cat's position on the screen
                catx[t]=number.Next(10, 901);
                caty[t] = number.Next(20, 571);
               //Adds one to the score
                score+=1;
               //tells the computer you have hit something (a cat)
                hit=true;
               //plays random cat catching sound
                edsound = number.Next(1, 4);

                if (edsound == 1 && score != 11 ||edsound == 1&& score != 20)
                {
                    alrighted.Play();
                }
                else if (edsound == 2 && score != 11 || edsound == 2 && score != 20)
                {
                    meow.Play();
                }
                else if (edsound == 3 && score != 11 || edsound == 3 && score != 20)
                {
                    gotchaed.Play();
                }
               //plays a sound from all if his 'happiness' has increases a level
                if (score == 11)
                {
                    laughal.Play();
                }

                if (score == 20)
                {
                    thatticklesal.Play();
                }
                Invalidate();
            }
            
            {
                //makes sure the cats do not walk off-screen
                for (int v = 1; v <= 5; v++)
                {
                    if (caty[v] > ClientSize.Height - 100)
                    {
                        caty[v] = ClientSize.Height - 100;
                        leftrightcat[v] = "leftup";
                       
                    }
                    else if (catx[v] > ClientSize.Width - 80)
                    {
                        catx[v] = ClientSize.Width - 80;
                        leftrightcat[v] = "left";
                       
                    }
                    else if (caty[v] < 20)
                    {
                        caty[v] = 20;
                        leftrightcat[v] = "rightdown";
                        
                    }
                    else if (catx[v] < 10)
                    {
                        catx[v] = 10;
                        leftrightcat[v] = "right";
                        
                    }
                }
            }

           
        }

        private void catstimer_Tick(object sender, EventArgs e)
        {
            //animates cat walking depending on its direction
           for(int g=1;g<=5;g++)
           {
               if (leftrightcat[g] == "left" || leftrightcat[g] == "leftup")
            {
                cat[g] = catleft[countercat];
                countercat++;
                if (countercat > 6)
                    countercat = 1;

                Invalidate();
            }
            else if (leftrightcat[g] == "right" || leftrightcat[g] == "rightdown")
            {
                cat[g] = catright[countercat];
                countercat++;
                if (countercat > 6)
                    countercat = 1;

                Invalidate();
            }
            }            
        }

        private void countdowntimer_Tick(object sender, EventArgs e)
        {
            //keeps coundown, and makes sure that when it reaches 0, the 
            //game is stoped and the either winning or losing form pops up
            countdown -= 1;
            if (countdown == 0&&score>=20)
            {
                endgame();

                frmwin w = new frmwin();
                this.Hide();
                w.ShowDialog();
            }
            else if (countdown == 0 && score < 20)
            {
                endgame();

                frmlose z = new frmlose();
                this.Hide();
                z.ShowDialog();
            }
        }

        private void endgame()
        {
            //method which stops the game
            edtimer.Enabled = false;
            hittimer.Enabled = false;
            catdirectiontimer.Enabled = false;
            catstimer.Enabled = false;
            catmovetimer.Enabled = false;
            countdowntimer.Enabled = false;

            axWindowsMediaPlayer2.URL = null;
        }

        private void startgame()
        {
            //method which starts the game
            countdown = 60;
            score = 0;
            axWindowsMediaPlayer2.URL = Application.StartupPath + @"\musicandsounds\catmusic.wav";

            edtimer.Enabled = true;
            hittimer.Enabled = true;
            catdirectiontimer.Enabled = true;
            catstimer.Enabled = true;
            catmovetimer.Enabled = true;
            countdowntimer.Enabled = true;
        }

        private void btnstartstop_Click(object sender, EventArgs e)
        {
            //if the button is pressed when it says "Start" the game will begin
            if (btnstartstop.Text == "Start")
            {
                startgame();
                flag = true;
                btnstartstop.Text = "Stop";
            }
                //if the button is pressed when it says "Stop", the game will stop 
            else
            {
                endgame();
                flag = false;
                btnstartstop.Text = "Start";
            }
            
        }

        private void catmovetimer_Tick(object sender, EventArgs e)
        {
            //makes cats move depending on the direction they are facing
            for (int j = 1; j <= 5; j++)
            {
                if (leftrightcat[j] == "left")
                {
                    catx[j] -= 4;
                }
                else if(leftrightcat[j]=="leftup")
                {
                    caty[j]-=4;
                }
                else if (leftrightcat[j]=="right")
                {
                    catx[j] += 4;
                }
                else if (leftrightcat[j] == "rightdown")
                {
                    caty[j] += 4;
                }             
            }
        }

        private void catdirectiontimer_Tick(object sender, EventArgs e)
        {
            //randomizes the direction each cat faces
            for (int i = 1; i <= 5; i++)
            {
                randomdirection = direction.Next(1, 5);
                if (randomdirection == 1)
                {
                    leftrightcat[i] = "left";
                }
                else if (randomdirection == 2)
                {
                    leftrightcat[i] = "right";
                }
                else if (randomdirection == 3)
                {
                    leftrightcat[i] = "leftup";
                }
                else if (randomdirection == 4)
                {
                    leftrightcat[i] = "rightdown";
                }

                Invalidate();
            }
        }

        

    }
}
