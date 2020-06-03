using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //needed for double buffering
using System.Text;
using System.Windows.Forms;
using System.Media; //needed to play audio files
using System.IO; //Needed to use Dialogs

namespace Mario_Game
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();

            this.DoubleBuffered = true; //Double buffering command
        }

        public int playerscore
        {
            get { return score; }
        }

        //******************VARIABLE DICTIONARY*********************
        //Random r = new Random(); random number generator
        //name; the name of the player for highscores
        //mcount = 1; mario image counter
        //gcount = 1; goomba image counter
        //ccount = 1; coin image counter
        //fcount = 1; flame image counter
        //kcount = 1; koopa image counter
        //bcount = 1; block image counter
        //marioX; mario's x-coordinate location
        //koopaX; koopa's x-coordinate location
        //int [] goombaX = new int[5]; each goomba's x-coordinate        
        //int [] coinX = new int [10]; each coin's x-coordinate 
        //int[] blockX = new int[3]; block x-coordinate location
        //int[] blockY = new int[3]; block y-coordinate location
        //int[] blockspeed = new int[3]; block speed
        //int bnum = 1; background counter
        //int lives = 3; mario's lives
        //int score; score
        //int totalscore; the player's total game score
        //int time; time counter
        //int x, z; variables that will determine the number 
        //of coins or goombas
        //int [] coinflag = new int [10]; flag for coin
        //int [] flaggoomba = new int [5]; flag for goomba
        //int flagkoopa = 1; flag for koopa
        //bool hit, hit2; variables to see if enemy was hit
        //bool flag = false; flag for game start    
        //int flameX, flameY; x and y co-ordinates of flame
        //int flameDY;
        //Image[] Imgmario = new Image[4]; image array for mario
        //Image[] Imgcoin = new Image[5]; image array for coin
        //Image[] Imggoomba = new Image[3]; image array for goomba
        //Image[] Imgkoopa = new Image[3]; image array for koopa
        //Image[] Imgbackground = new Image[5]; image array for backgrounds
        //Image[] Imgflame = new Image[5]; image array for flame
        //Image[] Imgblock = new Image[3]; image array for block        
        //SoundPlayer bling = new SoundPlayer(); sound for when coin is collected 
        //SoundPlayer fire = new SoundPlayer(); sound when fire is shot
        //SoundPlayer gameover = new SoundPlayer(); sound when game is over

        Random r = new Random();

        string name;
        string hs;

        int mcount = 1;
        int gcount = 1;
        int ccount = 1;
        int fcount = 1;
        int kcount = 1;
        int bcount = 1;

        int marioX;
        int koopaX;
        int [] goombaX = new int[5];        
        int [] coinX = new int [10];

        int[] blockX = new int[3];
        int[] blockY = new int[3];
        int[] blockspeed = new int[3];

        int bnum = 1;
        int lives = 3;

        int score;
        int totalscore;
        int highscore;

        int time;
        int x, z;

        int [] coinflag = new int [10];
        int [] flaggoomba = new int [5];
        int flagkoopa = 1;

        bool hit, hit2;
        bool flag = false;        

        int flameX, flameY;
        int flameDY;

        Image[] Imgmario = new Image[4];
        Image[] Imgcoin = new Image[5];
        Image[] Imggoomba = new Image[3];
        Image[] Imgkoopa = new Image[3];
        Image[] Imgbackground = new Image[5];
        Image[] Imgflame = new Image[5];
        Image[] Imgblock = new Image[3];

        Image mario;
        Image background;
        Image flame;
        Image koopa;
        
        Image []block = new Image [5];
        Image [] goomba = new Image [5];        
        Image [] coin = new Image [10];          

        SoundPlayer bling = new SoundPlayer();
        SoundPlayer fire = new SoundPlayer();
        SoundPlayer gameover = new SoundPlayer();
                
        private void FrmGame_Load(object sender, EventArgs e)
        {
            //load in all the images for background
            for (int i = 1; i <= 4; i++)
            {
                Imgbackground[i] = Image.FromFile(Application.StartupPath + @"\Background\Background" + i + ".jpg");
            }
            //load images for mario
            for (int i = 1; i <= 3; i++)
            {
                Imgmario[i] = Image.FromFile(Application.StartupPath + @"\Mario\mario" + i.ToString() + ".gif");
            }
            //load coin images
            for (int i = 1; i <= 4; i++)
            {
                Imgcoin[i] = Image.FromFile(Application.StartupPath + @"\Coin\coin" + i.ToString() + ".gif");
            }
            //load enemy images
            for (int i = 1; i <= 2; i++)
            {
                Imggoomba[i] = Image.FromFile(Application.StartupPath + @"\Goomba\goomba" + i.ToString() + ".gif");
                Imgkoopa[i] = Image.FromFile(Application.StartupPath + @"\Koopa\koopa" + i.ToString() + ".gif");
            }
            //load flame images
            for (int i = 1; i <= 4; i++)
            {
                Imgflame[i] = Image.FromFile(Application.StartupPath + @"\Flame\Flame" + i.ToString() + ".gif");
            }
            //load block images
            for (int i = 1; i <= 2; i++)
            {
                Imgblock[i] = Image.FromFile(Application.StartupPath + @"\Block\block" + i.ToString() + ".gif");
            }
            //locations of the sound clips
            bling.SoundLocation = Application.StartupPath + @"\SoundFX\points.wav";
            fire.SoundLocation = Application.StartupPath + @"\SoundFX\flame.wav";
            gameover.SoundLocation = Application.StartupPath + @"\SoundFX\gameover.wav";

            //load sound clips
            bling.LoadAsync();
            fire.LoadAsync();
            gameover.LoadAsync();

            //set initial images
            mario = Imgmario[1];
            background = Imgbackground[bnum];            
            koopa = Imgkoopa[1];
            flame = Imgflame[1];            

            //set flame, mario and koopa offscreen
            flameX = ClientSize.Width + 100;
            flameY = ClientSize.Height + 100;

            marioX = ClientSize.Width + 50;
            koopaX = ClientSize.Width + 50;

            //set block off screen
            for (int i = 1; i < 2; i++)
            {
                blockX[i] = ClientSize.Width + 100;
                block[i] = Imgblock[1];
            }

            //go to coin and goomba method
            Coin();
            Goomba();
            HighScore();

            //initialize variables
            hit = false;
            hit2 = false;

            score = 0;
            time = 0;

            txtName.Text = ("Name");

            //put focus on screen so that keyboard commands can be used 
            this.Focus();           
            
        }     
       
        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (flag == true)
            {
                if (e.KeyCode == Keys.A)
                {
                    //timer is enabled and mario moves backward
                    tmrMario.Enabled = true;
                    marioX = marioX - 5;                    
                }
                else if (e.KeyCode == Keys.D)
                {
                    //timer is enabled and mario moves forward
                    tmrMario.Enabled = true;
                    marioX = marioX + 5;
                }
                else if (e.KeyCode == Keys.J)
                {
                    //mario stops moving and shoots flame
                    tmrFlame.Enabled = true;
                    tmrMario.Enabled = false;
                    flameX = marioX + 10;
                    flameY = 175;

                    flameDY = 10;

                    //fire soundclip plays
                    fire.Play();
                }

                //double buffering, images are redraw
                Invalidate();
            }
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A) || (e.KeyCode == Keys.D))
            {
                //if no key is pressed mario does not move
                tmrMario.Enabled = false;
                mario = Imgmario[1];
            }
        }        

        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            //graphics command
            Graphics g = e.Graphics;
            DrawStuff(g);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                //set variables
                flag = true;
                time = 0;
                btnStart.Text = "Stop";
                PicHelp.Visible = false;

                //set location of mario and koopa
                marioX = 0;
                koopaX = r.Next(150, 498);

                //go to coin and goomba method
                Coin();
                Goomba();

                //set block speed
                for (int i = 1; i < 3; i++)
                {
                    blockY[i] -= 3;
                    blockspeed[i] = r.Next(5, 25);
                }

                Invalidate();
                NewGame();

                //put focus on form
                this.Focus();
            }
            else
            {
                flag = false;
                btnStart.Text = "Start";
                tmrMario.Enabled = false;
            }

            //enable timers
            tmrGoopa.Enabled = !(tmrGoopa.Enabled);
            tmrCoin.Enabled = !(tmrCoin.Enabled);
            tmrtime.Enabled = !(tmrtime.Enabled);
            tmrBlock.Enabled = !(tmrBlock.Enabled);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //display help image
            PicHelp.Visible = true;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            TotalScore();

            if (txtName.Text != "Name")
            {
                //user can enter name into text box
                name = txtName.Text;
                
                HighScore();

                if (totalscore > highscore)
                {
                    //the name and the score are inputted into a text file
                    TextWriter tw = new StreamWriter("Scores.txt");
                    TextWriter nm = new StreamWriter("Name.txt");

                    tw.WriteLine(totalscore);
                    tw.Close();

                    nm.WriteLine(name);
                    nm.Close();

                    MessageBox.Show("Congratualtions you are the new highscorer!");
                }
            }

            //set variables to false
            txtName.Visible = false;
            btnOkay.Visible = false;
            lblOver.Visible = false;

            tmrBlock.Enabled = false;
            tmrCoin.Enabled = false;
            tmrtime.Enabled = false;
            tmrMario.Enabled = false;
            tmrGoopa.Enabled = false;

            flag = false;
            time = 0;
            btnStart.Text = "Start";
            txtName.Text = "Name";
        }

        //***************************METHODS***********************************

        private void DrawStuff(Graphics g)
        { 
            Background();

            //draw these images onto the form
            g.DrawImage(background, 0, 0);
            g.DrawImage(mario, marioX, ClientSize.Height - mario.Width - 16, mario.Width, mario.Height);
            g.DrawImage(Imgmario[1], 78, -5, 30, 32);
            g.DrawImage(Imgcoin[1], 4, 6, 10, 13);
            g.DrawImage(flame, flameX, flameY);

            //if the goomba[i] has not been hit flaggoomba == 1 and therefore it will be
            //drawn onto the form , but if it equals two the certain goomba will not be drawn
            for (int i = 1; i <= z; i++)
            {
                if (flaggoomba[i] == 1)
                {
                    g.DrawImage(goomba[i], goombaX[i], ClientSize.Height - goomba[i].Width - 16, goomba[i].Width, goomba[i].Height);
                }
            }

            //if the koopa has not been hit it will be redrawn onto the form
            if (flagkoopa == 1)
            {
                g.DrawImage(koopa, koopaX, ClientSize.Height - koopa.Width - 16, koopa.Width, koopa.Height);
            }            

            //if the coin[i] has not been collected by mario it will be redrawn
            for (int i = 2; i <= x; i++)
            {
                if (coinflag[i] == 1)
                {
                    g.DrawImage(coin[i], coinX[i], ClientSize.Height - coin[i].Width - 37, coin[i].Width, coin[i].Height);
                }
            }

            //draws the falling block
            //for (int i = 1; i < 3; i++)
            //{
            //    g.DrawImage(block[i], blockX[i], blockY[i], block[i].Width, block[i].Height);
            //}

            //creates and font and a drawing tool 
            Font font = new Font("Arial", 9, FontStyle.Bold);
            SolidBrush blackbrush = new SolidBrush(Color.Black);

            //draws the score, lives and time on the top of the form
            g.DrawString("Score: " + score.ToString(), font, blackbrush, 15, 5);
            g.DrawString("Lives: " + lives.ToString(), font, blackbrush, 100, 5);
            g.DrawString("Time: " + time.ToString(), font, blackbrush, 170, 5);
            g.DrawString("Highscore: " + highscore.ToString(), font, blackbrush, 250, 5);
            //g.DrawString("" + name.ToString(), font, blackbrush, 270, 5);
            
            //if a koopa(hit2) or goomba(hit1) has been hit the 
            //score will increase by 120
            if (hit || hit2)
            {
                Initialize();
                score += 120;
            }
        }        

        private void Initialize()
        {   
            //initialize variables for the flame
            flameX = ClientSize.Width + 100;
            flameY = ClientSize.Height + 100;

            flameDY = 0;

            hit = false;
            hit2 = false;
        }

        private void Background()
        {
            if (tmrMario.Enabled == true)
            {
                //if mario walks to the end of the form
                //and the bnum is not equal to five then
                //he will enter another "world" and be
                //repositioned at x = 0

                //new world is just a different img
                //being drawn as the background
                if (ClientSize.Width - marioX < 0)
                {                    
                    if (bnum == 5)
                    {
                        GameOver();
                    }
                    
                    else if (bnum <= 4)
                    {                        
                        marioX = 0;
                        Coin();
                        Goomba();                        

                        background = Imgbackground[bnum];
                        
                        bnum++;
                    }
                }
            }

        }

        private void NewGame()
        {
            //for a new game all the flags have to
            //be reset to 1 
            for (int i = 1; i <= x; i++)
            {
                coinflag[i] = 1;
            }

            for (int i = 1; i <= z; i++)
            {
                flaggoomba[i] = 1;
            }

            //variables reset to original values
            coinflag[1] = 2;
            score = 0;
            lives = 3;
            hit = false;
            hit2 = false;
            flagkoopa = 1;
            bnum = 1;

            HighScore();

            Initialize();
        }

        private void Goomba()
        {
            //random number of goomba is selected for
            //each "world" mario enters
            z = r.Next(1, 5);

            //goompa are also randomly placed on form
            if (flag == true)
            {
                for (int i = 1; i <= z; i++)
                {
                    goomba[i] = Imggoomba[1];
                    flaggoomba[i] = 1;
                    goombaX[i] = ClientSize.Width + 50;
                    goombaX[i] = r.Next(200, 498);
                }
            }
        }

        private void Coin()
        {
            //as with the goomba's the number of 
            //coins drawn for each world are also
            //randomly selected
            x = r.Next(3, 10);

            //the location is also randomly chosen
            if (flag == true)
            {
                for (int i = 1; i <= x; i++)
                {
                    coin[i] = Imgcoin[1];
                    coinflag[i] = 1;
                    coinX[i] = ClientSize.Width + 50;
                }

                coinflag[1] = 2;
                coinX[1] = r.Next(100, 350);

                for (int i = 2; i <= x; i++)
                {
                    coinX[i] = coinX[1] + (25 * i);
                }
            }
            //the first coin is not drawn because it 
            //determines the location of the following 
            //coins which space out evenly

        }        

        private void GameOver()
        {
            //all timers are disabled and
            //the textbox to enter your name is displayed
            txtName.Visible = true;
            btnOkay.Visible = true;

            lblOver.Visible = true;

            tmrBlock.Enabled = false;
            tmrCoin.Enabled = false;
            tmrtime.Enabled = false;
            tmrMario.Enabled = false;
            tmrGoopa.Enabled = false;

            flag = false;
            btnStart.Text = "Start";
        }

        private void TotalScore()
        {
            totalscore = score + (lives * 1005) - time;
        }

        private void HighScore()
        {
            //loads up previous highscore so that
            //it can be compared to the current players score
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\Scores.txt";

            StreamReader r = new StreamReader(f);
            
            bool finished = false;

            while (!finished)
            {
                hs = r.ReadLine();
                
                if (hs == null)
                {
                    finished = true;
                }
            }

            r.Close();

            highscore = Convert.ToInt32(hs);
        }

        //***************************TIMERS***********************************

        private void tmrMario_Tick(object sender, EventArgs e)
        {
            //displays the images of mario running
            mario = Imgmario[mcount];
            mcount++;
            if (mcount > 3)
                mcount = 1;

            Invalidate();
        }

        private void tmrGoopa_Tick(object sender, EventArgs e)
        {
            //cycles through goompa images
            for (int i = 1; i <= z; i++)
                goomba[i] = Imggoomba[gcount];
            gcount++;
            if (gcount > 2)
                gcount = 1;

            //cycles through koopa images
            koopa = Imgkoopa[kcount];
            kcount++;
            if (kcount > 2)
                kcount = 1;

            for (int i = 1; i <= z; i++)
            {
                //if mario and goomba[i] or koopa have hit each other than mario loses one life
                //and is repositioned back at the beginning of the form at x = 0
                if (((marioX + mario.Width > goombaX[i]) && (flaggoomba[i] == 1)) || ((marioX + mario.Width > koopaX) && (flagkoopa == 1)))
                {
                    if (lives > 0)
                    {
                        lives -= 1;
                        marioX = 0;
                    }
                    else if (lives == 0)
                    {
                        //gameover song plays 
                        gameover.Play();
                        GameOver();
                    }
                }
            }

            Invalidate();

            //goomba and koopa move across the screen
            for (int i = 1; i <= z; i++)
                if (flaggoomba[i] == 1)
                    goombaX[i] -= 3;
                else
                    goombaX[i] = ClientSize.Width - 550;

            if (flagkoopa == 1)
                koopaX -= 3;
            else
                koopaX = ClientSize.Width - 550;

        }

        private void tmrCoin_Tick(object sender, EventArgs e)
        {
            //cycles through the coin images
            for (int i = 1; i <= x; i++)
                coin[i] = Imgcoin[ccount];
            ccount++;
            if (ccount > 4)
                ccount = 1;

            //if mario hits and collects a 
            //coin he earns 100 points
            for (int i = 1; i <= x; i++)
            {
                if (marioX + mario.Width > coinX[i])
                {
                    if (coinflag[i] == 1)
                    {
                        score += 100;
                        coinflag[i] = 2;
                        bling.Play();
                    }
                }
            }

            Invalidate();
        }

        private void tmrFlame_Tick(object sender, EventArgs e)
        {
            //cycles through the flame images
            flame = Imgflame[fcount];
            fcount++;
            if (fcount > 4)
                fcount = 1;

            //moves flame across the screen
            flameX += flameDY;

            //if flame goes off the form it is repositioned
            if (flameX > ClientSize.Width)
            {
                flameDY = 0;
                flameX = ClientSize.Width + 100;
                flameY = ClientSize.Height + 100;
            }

            //if the flame hits one of the targets
            //(either a goompa or koopa)
            //then the target disappers along with the flame
            //as they are not redrawn 
            for (int i = 1; i <= z; i++)
            {
                if ((flame.Width + flameX > goombaX[i]) && (flameX < goombaX[i] + mario.Width) && (hit == false))
                {
                    hit = true;
                    flaggoomba[i] = 2;
                }
            }

            if ((flame.Width + flameX > koopaX) && (flameX < koopaX + mario.Width) && (hit == false))
            {
                hit2 = true;
                flagkoopa = 2;
            }
        }

        private void tmrtime_Tick(object sender, EventArgs e)
        {
            //keeps track of time
            time++;
        }

        private void tmrBlock_Tick(object sender, EventArgs e)
        {
            //cycles through block images
            for (int i = 1; i <= 2; i++)
            {
                block[i] = Imgblock[bcount];
                bcount++;
                if (bcount > 2)
                    bcount = 1;
            }
 
            //allows block to fall down the form
            for (int i = 1; i <= 2; i++)
            {
                blockY[i] = blockY[i] + blockspeed[i];
                
                    if (blockY[i] > (this.Height - mario.Height))
                    {
                        if (blockX[i] - 20 < marioX)
                        { 
                            if ((blockX[i]+20) > (marioX + mario.Width))
                            {
                                score += 75;
                            }
                        }
                        
                    }                 
            }
        }      


    }
}