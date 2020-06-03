using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media; 



namespace BowserAdventure
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.DoubleBuffered = true; 
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //-------------------------------------------Variable Dictionary-----------------------------------------------
        //bowser = holds the bowser image
        //flame = holds the flame images
        //marioN,E,S,W = all hold the array of mario going NSEW
        //bowserN,E,S,W = all hold the array of bowser goin NSEW
        //FlameN,E,S,W = all hold the array of the flame facing NSEW
        //back = holds the backround image
        //rannum = generates a random rumber used for the direction
        //randir = ""
        //bowserx,y = holds the position of bowser
        //mariox,y = holds the array of mario positions
        //dir = holds the direction of bowser
        //dir2 = holds the array of directions of mario
        //count = counter used in animation
        //i,j,t,g = counters used in timers
        //time = holds the time left to play
        //score = holds the user's score
        //fire = a bool used to make the flame disappear
        //hit,fball,roar,end = sounds stored in game
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        Image[] mario = new Image[11];
        Image bowser;
        Image flame;
        Image[] marioN = new Image[11];
        Image[] marioE = new Image[11];
        Image[] marioS = new Image[11];
        Image[] marioW= new Image[11];
        Image[] bowserN = new Image[9];
        Image[] bowserE = new Image[9];
        Image[] bowserS = new Image[9];
        Image[] bowserW = new Image[9];
        Image[] FlameN = new Image[9];
        Image[] FlameE = new Image[9];
        Image[] FlameS = new Image[9];
        Image[] FlameW = new Image[9];
        Image back;
        Random rannum = new Random();
        Random randir = new Random();
        int bowserx, bowsery;
        int[] mariox = new int[30];
        int[] marioy = new int[30];
        string dir;
        string[] dir2 = new string[11];
        int count;
        int i = 1;
        int j = 1;
        int t = 1;
        int g = 1;
        int score = 0;
        int time = 60;
        bool fire = false;
        SoundPlayer hit = new SoundPlayer();
        SoundPlayer fball = new SoundPlayer();
        SoundPlayer roar = new SoundPlayer();
        SoundPlayer end = new SoundPlayer();
        SoundPlayer hit2 = new SoundPlayer();
        SoundPlayer hit3 = new SoundPlayer();

  
        private void Main_Load(object sender, EventArgs e)
        {
            //loads in the images
            for (int i = 1; i <= 8; i++)
            {
                bowserN[i] = Image.FromFile(Application.StartupPath + @"\BWN" + i + ".gif");
                bowserE[i] = Image.FromFile(Application.StartupPath + @"\BWE" + i + ".gif");
                bowserS[i] = Image.FromFile(Application.StartupPath + @"\BWS" + i + ".gif");
                bowserW[i] = Image.FromFile(Application.StartupPath + @"\BWW" + i + ".gif");
                marioN[i] = Image.FromFile(Application.StartupPath + @"\MN" + i + ".gif");
                marioE[i] = Image.FromFile(Application.StartupPath + @"\ME" + i + ".gif");
                marioS[i] = Image.FromFile(Application.StartupPath + @"\MS" + i + ".gif");
                marioW[i] = Image.FromFile(Application.StartupPath + @"\MW" + i + ".gif");
                FlameN[i] = Image.FromFile(Application.StartupPath + @"\FN" + i + ".gif");
                FlameE[i] = Image.FromFile(Application.StartupPath + @"\FE" + i + ".gif");
                FlameS[i] = Image.FromFile(Application.StartupPath + @"\FS" + i + ".gif");
                FlameW[i] = Image.FromFile(Application.StartupPath + @"\FW" + i + ".gif");
            }

            
            //loads in backround
            back = Image.FromFile(Application.StartupPath + @"\back.bmp");

            //assigns the marios initial facing directions
            for (int c = 1; c <= 5; c++)
            {
                mario[c] = marioN[c];
                dir2[c] = "s";
            }

            //assignes the marios random starting positions
            for (int p = 1; p <= 5; p++)
            {
                mariox[p] = rannum.Next(30, 431);
                marioy[p] = rannum.Next(40, 361);
            }
            
            
            //assigns bowser's starting position
            bowserx = this.Width / 2;
            bowsery = this.Height / 2;

            //assigns initial flame pic
            flame = FlameS[8];
            
            bowser = bowserS[1];
            count = 1;
            dir = "s";
            score = 0;
            TxtScore.Text = "0";

            //loads in sounds
            hit.SoundLocation=Application.StartupPath + @"\hit.wav";
            hit.Load();
            fball.SoundLocation = Application.StartupPath + @"\fball.wav";
            fball.LoadAsync();
            roar.SoundLocation = Application.StartupPath + @"\roar.wav";
            roar.Load();
            end.SoundLocation = Application.StartupPath + @"\end.wav";
            end.Load();
            hit2.SoundLocation = Application.StartupPath + @"\mama.wav";
            hit3.SoundLocation = Application.StartupPath + @"\oooh.wav";
            hit2.Load();
            hit3.Load();

            StartGame();
            this.Focus();

            
        }

        

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            AnimateChar(g);

        }

        private void AnimateChar(Graphics g)
        {
           //the main animation function
            //draws the backround and bowser
            g.DrawImage(back, 0, 0);
            g.DrawImage(bowser, bowserx, bowsery);


            //draws the pictures of mario
            for (int f = 1; f <= 5; f++)
            {
                g.DrawImage(mario[f], mariox[f], marioy[f]);


            }

            //if spacebar is pressed the flame is drawn
            if (fire == true)
            {

                //draws the flame facing according to bowsers position
                if (dir == "n")
                {
                    g.DrawImage(flame, bowserx, bowsery - 90);


                }
                else if (dir == "s")
                {
                    g.DrawImage(flame, bowserx, bowsery + 50);


                }
                else if (dir == "e")
                {

                    g.DrawImage(flame, bowserx + 50, bowsery);


                }
                else if (dir == "w")
                {
                    g.DrawImage(flame, bowserx - 90, bowsery);


                }



            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {


            //moves bowser in a certain direction
            if (e.KeyCode == Keys.Up)
            {
                dir = "n";
                bowsery += -4;
            }
            else if (e.KeyCode == Keys.Down)
            {
                dir = "s";

                bowsery += 4;
            }
            else if (e.KeyCode == Keys.Left)
            {
                dir = "w";

                bowserx += -4;
            }
            else if (e.KeyCode == Keys.Right)
            {
                dir = "e";

                bowserx += 4;
            }

            //flags the flame as active and plays fire sound
            if (e.KeyCode == Keys.Space)
            {
                fire = true;
                fball.Play();
                Collision();

            }



            Invalidate();
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            fire = false;
            Invalidate();
        }

        private void Collision()
        {
            //stops bowser from proceeding outside of the form
            if (bowsery > this.Height - 90)
            {
                bowsery = this.Height - 90;
            }
            else if (bowserx > this.Width - 70)
            {
                bowserx = this.Width - 70;
            }
            else if (bowsery < 25)
            {
                bowsery = 25;
            }
            else if (bowserx < 25)
            {
                bowserx = 25;
            }


            //indentifys if the flame hits mario
            if (fire == true)
            {
                if (dir == "n")
                {
                    if ((bowserx + bowser.Width > mariox[t]) && (bowserx < mariox[t] + mario[t].Width) && (bowsery + flame.Height > marioy[t]) && (bowsery - 90 < marioy[t] + mario[t].Height))
                    {
                        fball.Play();
                        timer7.Enabled = true;
                        mariox[t] = rannum.Next(30, 431);
                        marioy[t] = rannum.Next(40, 361);
                        score += 3;
                        Invalidate();
                        TxtScore.Text = score.ToString();
                    }
                }
                else if (dir == "s")
                {
                    if ((bowserx + bowser.Width > mariox[t]) && (bowserx < mariox[t] + mario[t].Width) && (bowsery + bowser.Height + flame.Height > marioy[t]) && (bowsery < marioy[t] + mario[t].Height))
                    {
                        fball.Play();
                        timer7.Enabled = true;
                        mariox[t] = rannum.Next(30, 431);
                        marioy[t] = rannum.Next(40, 361);
                        score += 3;
                        Invalidate();
                        TxtScore.Text = score.ToString();
                    }

                }
                else if (dir == "e")
                {
                    if ((bowserx + bowser.Width + flame.Height > mariox[t]) && (bowserx < mariox[t] + mario[t].Width) && (bowsery + bowser.Height > marioy[t]) && (bowsery < marioy[t] + mario[t].Height))
                    {
                        fball.Play();
                        timer7.Enabled = true;
                        mariox[t] = rannum.Next(30, 431);
                        marioy[t] = rannum.Next(40, 361);
                        score += 3;
                        Invalidate();
                        TxtScore.Text = score.ToString();

                    }

                }
                else if (dir == "w")
                {
                    if ((bowserx + bowser.Width > mariox[t]) && (bowserx - flame.Height < mariox[t] + mario[t].Width) && (bowsery + bowser.Height > marioy[t]) && (bowsery < marioy[t] + mario[t].Height))
                    {
                        fball.Play();
                        timer7.Enabled = true;
                        mariox[t] = rannum.Next(30, 431);
                        marioy[t] = rannum.Next(40, 361);
                        Invalidate();
                        score += 3;
                        TxtScore.Text = score.ToString();
                    }

                }
            }


            //prevents mario from proceeding outside of the form
            if (marioy[t] > this.Height - 90)
            {
                marioy[t] = this.Height - 90;
                dir2[t] = "n";
            }
            else if (mariox[t] > this.Width - 70)
            {
                mariox[t] = this.Width - 70;
                dir2[t] = "w";
            }
            else if (marioy[t] < 25)
            {
                marioy[t] = 25;
                dir2[t] = "s";
            }
            else if (mariox[t] < 25)
            {
                mariox[t] = 25;
                dir2[t] = "e";
            }

            t++;
            if (t > 5)
            {
                t = 1;
            }
        }

        private void EndGame()
        {
            //ends timers
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer8.Enabled = false;
        }

        private void StartGame()
        {
            //starts timers
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
            timer8.Enabled = true;
            roar.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //animates bowser running in different directions
            if (dir == "n")
            {
                bowser = bowserN[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir == "s")
            {
                bowser = bowserS[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir == "e")
            {
                bowser = bowserE[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir == "w")
            {
                bowser = bowserW[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
        }

        


        private void timer2_Tick(object sender, EventArgs e)
        {
            //animates mario running in different directions
            if (dir2[g] == "n")
            {
                mario[g] = marioN[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir2[g] == "s")
            {
                mario[g] = marioS[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir2[g] == "e")
            {
                mario[g] = marioE[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir2[g] == "w")
            {
                mario[g] = marioW[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }

            g++;
            if (g > 5)
                g = 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //randomizes each marios movement direction
            int dn;
            dn = randir.Next(1, 5);

            if (dn == 1)
             {
                 dir2[i] = "n";
             }
            else if (dn == 2)
             {
                 dir2[i] = "e";
             }
            else if (dn == 3)
             {
                 dir2[i] = "s";
             }
             else if (dn == 4)
             {
                 dir2[i] = "w";
             }

             i++;
             if (i > 5)
             {
                 i = 1;
             }

             Invalidate();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            //moves mario according to the direction
            if (dir2[j] == "n")
            {

                marioy[j] += -15;
                Invalidate();
            }
            else if (dir2[j] == "s")
            {


                marioy[j] += 15;
                Invalidate();
            }
            else if (dir2[j] == "w")
            {


                mariox[j] += -15;
                Invalidate();
            }
            else if (dir2[j] == "e")
            {


                mariox[j] += 15;
                Invalidate();
            }

            
            j++;
            if (j > 5)
            {
                j = 1;
            }

            

            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //constantly checking for collisions
            Collision();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //animates the flame depending on where bowser if facing
            if (dir == "n")
            {
                flame = FlameN[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir == "s")
            {
                flame = FlameS[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir == "e")
            {
                flame = FlameE[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
            else if (dir == "w")
            {
                flame = FlameW[count];
                count++;
                if (count > 8)
                    count = 1;

                Invalidate();

            }
        }


        private void timer7_Tick(object sender, EventArgs e)
        {
            //plays hit sound after the fire sound
            Random sound = new Random();
            int x;
            x = sound.Next(1,4);
            if (x == 1)
            {
                hit.Play();
            }
            else if (x == 2)
            {
                hit2.Play();
            }
            else if (x == 3)
            {
                hit3.Play();
            }
            timer7.Enabled = false;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            //ends the game after the time is 0
            time -= 1;
            TxtTime.Text = time.ToString();

            if (time == 0)
            {
                EndGame();
                MessageBox.Show("YOU SCORED: " + score + " POINTS!");
                end.Play();
                this.Close();
                
            }

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //user prompted end game
            EndGame();
            end.Play();
            this.Close();
                
        }

    }



}