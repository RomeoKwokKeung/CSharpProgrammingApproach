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
//Global Variable list

//Image apple, background = basic image variables
//Image, sheep, explosion, worm, arrow, torch = animated array images
//SoundPlayer baa,collisionr, thud, torchr,walking= sound FX
//int sheepX= controls sheep X position
//int sheepY= controls sheep Y position
//int sheepcount = controls sheep animation
//bool sheepground = controls if sheep has hit ground
//int wormX=controls worm X position
//  int wormY= controls worm Y position
//  int wormcount = controls worm animatino
// bool drawworm = whether worm has been drawn
//torchX= controls torch X position
//torchY = controls  torch Y posiiton
//torchcount controls torch animation
//torchfin controls if torch animation is finished
//int appleX and appleY controls apple coordinates
//int arrowcount controls angle degree
//int expX and expY control explosion positions
//int expcount controls explosion animation
//int point controls point for dotted line
//int score controls score variable
//double wormangle controls angle of sheep shot
//bool start whether or not game has started
//bool collision if collision occured
//soundplayer conrtols if sound is playing
//Points pointz controls points of dotted line
//
//
//
//
//
//

//features:
//sheep, torch, worm and explosion all have animations and sounds
//worm loads in a random position each time and as your score increases so does the worm speed
//background music is played throughout whole game
//quadratic formula used to control sheep flying in the air
namespace TheGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

        }

        Image apple = Image.FromFile(Application.StartupPath + @"\apple.png");

        Image background = Image.FromFile(Application.StartupPath + @"\bacground2.jpg");
        Image[] sheep =new Image[7];
        Image[] explosion = new Image[9];
        Image[] worm = new Image[15];
        Image[] arrow = new Image[30];
        Image[] torch = new Image[15];

        //Declare sounds
        SoundPlayer baa = new SoundPlayer();
        SoundPlayer collisionr = new SoundPlayer();
        SoundPlayer thud = new SoundPlayer();
        SoundPlayer torchr = new SoundPlayer();
        SoundPlayer walking = new SoundPlayer();

        int sheepX;
        int sheepXX;
        int sheepY;
        int sheepcount = 0;
        bool sheepground = true;


        int wormX=0;
        int wormY=0;
        int wormcount = 0;
        bool drawworm = true;

        int torchX = 900;
        int torchY = 738;
        int torchcount = 0;
        bool torchfin = false;

        int appleX =0;
        int appleY = 0;
        bool appledetect;
        
        int arrowcount = 15;

        int expX=0;
        int expY=0;
        int explosioncount = 0;

        int pointamount =75 ;
        
        int score = 0;

       
        double wormangle = 0.0050;

        bool start = false;
        bool collision = false;

        bool soundplay=false;
        bool soundplay2 = false;

        Point[] points = new Point[400]; 

        

        private void Game_Load(object sender, EventArgs e)
        {
            
            
            //Loads all Images into Arrays                             
            for (int i = 0; i <= 6; i++)
            {
                sheep[i] = Image.FromFile(Application.StartupPath + @"\Sheeps\sheep" + i.ToString() + ".gif");
            }
            for (int i = 0; i <= 8; i++)
            {
                explosion[i] = Image.FromFile(Application.StartupPath + @"\Explosion\Exp" + i.ToString() + ".png");
            }

            for (int i = 0; i <= 29; i++)
            {
                arrow[i] = Image.FromFile(Application.StartupPath + @"\Arrows\arrows" + i.ToString() + ".gif");
            }

            for (int i = 0; i <= 14; i++)
            {
                worm[i] = Image.FromFile(Application.StartupPath + @"\Walking\walks" + i.ToString() + ".png");
            }

            for (int i = 0; i <= 14; i++)
            {
                torch[i] = Image.FromFile(Application.StartupPath + @"\Torch\blow" + i.ToString() + ".png");
            }

            //load sounds
            baa.SoundLocation = Application.StartupPath + @"\Sound\sheepsss.wav";
            collisionr.SoundLocation = Application.StartupPath + @"\Sound\collision.wav";
            thud.SoundLocation = Application.StartupPath + @"\Sound\thud.wav";
            torchr.SoundLocation = Application.StartupPath + @"\Sound\torch.wav";
            walking.SoundLocation = Application.StartupPath + @"\Sound\walking.wav";

            //set to async
            baa.LoadAsync();
            collisionr.LoadAsync();
            thud.LoadAsync();
            torchr.LoadAsync();
            walking.LoadAsync();


            //declares Points for Dotted Line
            points = pointz(sheepX, wormangle, -2.0, 600);
            //Sets Sheep Start point
            sheepX = 0;
            //Sets Sheep Y value
            sheepY = 600 - sheep[sheepcount].Height;
            //Sets Torch Worm X position
            torchX = wormXpos();

            
           //Sets Worm Y value
            wormY = 600 - worm[wormcount].Height;
            //Sets apple X and Y
            appleY = 610-apple.Height;
            appleX = 100;
            //Gives form focus
            this.Focus();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            //declares paint event
            Graphics g = e.Graphics;
            drawobjects(g);
            
        }


        private void drawobjects(Graphics g)
        {
            //gives dotted line points
            float[] dashValues = { 5, 5, 5, 5 };
            //sets pen colour
            Pen greenPen = new Pen(Color.Red, 3);
            //declares dashpattern
            greenPen.DashPattern = dashValues;

            //draws background
            g.DrawImage(background,0,0);
            //draws curverd line
            g.DrawCurve(greenPen, points);
            //draws sheep
            g.DrawImage(sheep[sheepcount], sheepX, sheepY);
            //draws apple
            g.DrawImage(apple, appleX, appleY);

            //if collision is false
            if (collision == false)
            {//if the torch hasnt finished its motion
                if (torchfin == false)
                {//draw torch worm
                    g.DrawImage(torch[torchcount], torchX, torchY);
                    
                }
                    //if the torch is finished motion
                else if (torchfin==true)
                {//draw worm
                    g.DrawImage(worm[wormcount], wormX, wormY);

                }
            }
         
            if (collision == true)
            {    //if collision is true
                //draw explosion
                 g.DrawImage(explosion[explosioncount], expX, expY);
            }
                       
            
        }
        


        //method to call for points for dotted line
        private Point[] pointz(int x, double a, double b, int c)
        {
            int X = x;
            Point[] point = new Point[pointamount];
           
            for (int g = 0; g <= pointamount-1; g++)
            {
                double y = 0;
                y = a * Math.Pow(X, 2) + b * X + c - sheep[sheepcount].Height;
                int yy = Convert.ToInt32(y);

                X += 3;

                point[g] = new Point(X, yy);

                
            }

            return point;
            
        }

        private void Sheeptimer_Tick(object sender, EventArgs e)
        {
                 //if sheep misses       
            if (sheepY >= 605 - sheep[sheepcount].Height)
            {        //disable timer        
                Sheeptimer.Enabled = false;
               //set sheepground to true verify the sheep hit the ground
                sheepground = true;
                //set the explosion frame to 0
                explosioncount = 0;
                //reset collision
                collision = false;
                Sheeptimer.Enabled = false;
                sheepground = true;
                //reset sheep X and Y
                sheepX = 0;
                sheepY = 600 - sheep[sheepcount].Height;
                collision = false;
                thud.Play();
                             
            }
                    //if sheep hits worm
            if (sheepY + sheep[0].Height >= wormY && sheepX + sheep[sheepcount].Width >= wormX && sheepX  <= wormX + worm[wormcount].Width)
            {//add score
                score++;
                //reset torch worm
                torchfin = false;
                torchX = wormXpos();
                torchY = 738;
                //enable explosion
                expX = wormX;
                expY = wormY;
                //stop timer
                Sheeptimer.Enabled = false;
               // Animation.Enabled = false;
                //set bools
                sheepground = true;
                collision = true;

                    //reset sheep X and Y            
                sheepX = 0;
                sheepY = 600 - sheep[sheepcount].Height;
                walking.Stop();
                collisionr.Play();
                
                
                
            }
                     
            

            //increase a to shorten distance, ... 
            sheepY = SheepYpos(sheepX, wormangle, -2.0, 600);
            //a = 0.0024
            //b = -2.4
            //c=600

            //sheepXX += 10;

            sheepX += 3; 
            

            label1.Text = score.ToString();
            

            Invalidate(); 

            
        }

        private int wormXpos()
        {//method to randomly choose worm X position
            Random r = new Random();
            
            int x = r.Next(1,6);
            int q=0;

            if(x==1)
            {
                q = 800;
            }
            if(x==2)
            {
                 q=500;
            }
            if(x==3)
            {
                q = 600;
            }
            if(x==4)
            {
                q = 700;
            }
            if(x>=5)
            {
                q = 900;
            }
            
            
            return q;

            
        }

        private int SheepYpos(int x, double a, double b, int c)
        {//uses quadratics to find sheep Y
            double y = 0;


            y = a * Math.Pow(x, 2) + b * x + c - sheep[sheepcount].Height;
          //  y = a * Math.Pow((x - h), 2) + k - sheep.Height;
                     

            //y= int.Parse(y.ToString("n2"));
            int yy = Convert.ToInt32(y);

            return yy;



        }

        private void button1_Click(object sender, EventArgs e)
        {    //starts game
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\guile.mp3";
            Animation.Enabled = true;
            start = true;
            appledetect = true;
            
            this.Focus();
            Invalidate();
        }
                
        private void Animation_Tick(object sender, EventArgs e)
        {//controls all animation
          
            if (torchY +torch[0].Height <= 600)
            {
                torchfin = true;
                torchr.Stop();
            }
            //checks sheep frames
            if (sheepcount >= 6)
            {
                sheepcount = 0;
            }
            //allows animation
            if (sheepground == false)
            {
                sheepcount++;
            }
            //plays sound and animation
            if (torchfin == false)
            {
                torchcount++;
                if (soundplay == false)
                {
                    torchr.PlayLooping();
                    soundplay = true;
                }
            }
            //conrtols worm frames
            if (torchcount >= 14)
            {
                torchcount = 0;
            }


            //controls explosion count
            if (explosioncount >= 8)
            {
                explosioncount = 0;
                collision = false;
                soundplay = false;
                
            }
            
            if (collision == true)
            {
                explosioncount++;
            }


            if (torchfin == true)
            {
                
                wormcount++;
                                
               wormX -= score + 1;

               
            }

            else if (torchfin == false)
            {
                torchX-= 2;
                torchY -= 3;
                wormX = torchX;
            }
            if (wormcount >= 14)
            {
                wormcount = 0;
            }

            //detects if the worm eats the apple 
            if (appledetect == true)
            {
                if (wormX <= appleX + apple.Width)
                {//resets appropriate variables
                    appledetect = false;
                    
                    sheepground = true;
                    start = false;
                    appledetect = false;
                    torchfin = false;

                    explosioncount = 0;
                    score = 0;

                    sheepcount = 0;
                    sheepX = 0;
                    sheepY = 600 - sheep[sheepcount].Height;
                    wormX = 0;
                    wormY = 600 - worm[wormcount].Height;
                    wormcount = 0;
                    drawworm = true;

                    torchX = wormXpos();
                    torchY = 738;
                    torchcount = 0;
                    appleY = 610 - apple.Height;
                    appleX = 100;

                    arrowcount = 15;
                    expX = -30;
                    expY = -30;
                    explosioncount = 0;

                    pointamount = 75;

                    wormangle = 0.0050;

                    start = false;
                    collision = false;
                    label1.Text = score.ToString();

                    Sheeptimer.Enabled = false;
                    Animation.Enabled = false;

                    walking.Stop();
                    torchr.Stop();


                    this.Focus();
                    MessageBox.Show("gameover");
                }
            }

            Invalidate();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //displays help
            if (e.KeyCode == Keys.H)
            {
                MessageBox.Show("How to Play" + Environment.NewLine + "To aim up and down use the W/S keys." + Environment.NewLine + "To shoot the sheep Press D" + Environment.NewLine + "The goal of the game is to" + Environment.NewLine + "kill the worm before he gets" + Environment.NewLine + "to the apple!");
            }
            //closes game
            if (e.KeyCode == Keys.Q)
            {
                this.Close();
            }

            if (start == true)
            {//shoots sheep
                if (e.KeyCode == Keys.D)
                {                    
                        Sheeptimer.Enabled = true;
                        sheepground = false;
                        baa.Play();
                }
                               

                if (e.KeyCode == Keys.W)
                {//aims up
                    if (arrowcount != 44)
                    {
                        if (arrowcount > 14)
                        {
                            //wormangle += 0.0004;
                            wormangle -= 0.0001;
                        }

                        else
                        {
                            wormangle -= 0.0004;
                        }

                        // wormangle -= 0.0004;

                        arrowcount++;
                        pointamount = arrowcount * 5;
                        points = pointz(sheepX, wormangle, -2.0, 600);
                        Invalidate();
                        
                    }
                }

                else if (e.KeyCode == Keys.S)
                {//aims down
                    if (arrowcount != 1)
                    {
                        if (arrowcount > 14)
                        {
                            //wormangle += 0.0004;
                            wormangle += 0.0001;
                        }
                        else
                        {
                            wormangle += 0.0004;
                        }

                        //wormangle += 0.0004;

                        arrowcount--;
                        pointamount = arrowcount * 5;
                        points = pointz(sheepX, wormangle, -2.0, 600);
                        Invalidate();
                    }
                }
            }


        }

        private void Btnstop_Click(object sender, EventArgs e)
        {//stops and resets all values
            sheepground = true;
            start = false;
            appledetect = false;
            torchfin = false;

            explosioncount = 0;
            score = 0;

            sheepcount = 0;
            sheepX = 0;
            sheepY = 600 - sheep[sheepcount].Height;
            wormX = 0;
            wormY = 600 - worm[wormcount].Height;
            wormcount = 0;
            drawworm = true;

            torchX = wormXpos();
            torchY = 738;
            torchcount = 0;
            appleY = 610 - apple.Height;
            appleX = 100;

            arrowcount = 15;
            expX = -30;
            expY = -30;
            explosioncount = 0;

            pointamount = 75;

            wormangle = 0.0050;

            start = false;
            collision = false;
            label1.Text = score.ToString();

            Sheeptimer.Enabled = false;
            Animation.Enabled = false;
            
            torchr.Stop();
           
            this.Focus();

           // Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to Play" + Environment.NewLine + "To aim up and down use the W/S keys." + Environment.NewLine + "To shoot the sheep Press D" + Environment.NewLine + "The goal of the game is to" + Environment.NewLine + "kill the worm before he gets" + Environment.NewLine + "to the apple!");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

    }
}
