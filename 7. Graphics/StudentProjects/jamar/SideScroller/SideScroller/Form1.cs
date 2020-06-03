using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //doublebuffer
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true; ;



        }

        Random r = new Random();
        
        Image Link;
        Image Stal;
        Image RStal;
        Image Stand;
        Image Standl;
        Image Heart;
        Image Ded;
        Image gameoverfont;
        int xLink;
        int xEnemy = 570;
        int xEnemy2 = -100;
        int x = 0;
        int y = 0;
        int Direction = 0;

        int heartx = 0;
        int hearty = 10;
        int myheart = 3;


        bool hit = false;
        bool keypress = false;
        bool slash = false;
        bool death = false;

        Image[] linkmove = new Image[6];
        Image[] linkmovel = new Image[6];


        Image [] backgrounds = new Image [7];

        Image[] stalfos = new Image[7];
        Image[] rightstal = new Image[7];

        Image[] linkslash = new Image[4];
        Image[] linkslashl = new Image[4];

        
        int count;
        

        int slashcount;

        int points = 0 ;

        int backgroundcount=0;
        int enemycount;

        SoundPlayer steps = new SoundPlayer();
        SoundPlayer ow = new SoundPlayer();
        SoundPlayer owleft = new SoundPlayer();
        SoundPlayer hitz = new SoundPlayer();
        SoundPlayer hitzleft = new SoundPlayer();
        SoundPlayer enemyded = new SoundPlayer();
        SoundPlayer gameover = new SoundPlayer();

      

        private void Form1_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\Looost.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            
            // LOADS SOUNDS
            // gameover SE
            gameover.SoundLocation = Application.StartupPath + @"\gameover.wav";
            gameover.Load();
            // loads steps
            steps.SoundLocation = Application.StartupPath + @"\step.wav";
            steps.Load();
            // loads pain
            ow.SoundLocation = Application.StartupPath + @"\ow.wav";
            ow.Load();
            owleft.SoundLocation = Application.StartupPath + @"\ow2.wav";
            owleft.Load();
            //loads hitting to the right
            hitz.SoundLocation = Application.StartupPath + @"\hyah.wav";
            hitz.Load();
            //loads hitting to the left
            hitzleft.SoundLocation = Application.StartupPath + @"\lhyah.wav";
            hitzleft.Load();
            //loads hit collision
            enemyded.SoundLocation = Application.StartupPath + @"\hitwork.wav";
            enemyded.Load();

            xLink = this.Width / 3;
            count = 1;
            //loads background array
            for (int i = 0; i <= 3; i++)
            {
                backgrounds[i] = Image.FromFile(Application.StartupPath + @"\fields" + i.ToString() + ".bmp");
            }
            //loads link walking to the right image
            for (int i = 0; i <= 5; i++)
            {
                linkmove[i] = Image.FromFile(Application.StartupPath + @"\toon" + i.ToString() + ".gif");
            }
            //loads link walking to the left image
            for (int i = 0; i <= 5; i++)
            {
                linkmovel[i] = Image.FromFile(Application.StartupPath + @"\toonl" + i.ToString() + ".gif");
            }
            //loads stalfos
            for (int i = 0; i <= 6; i++)
            {
                stalfos[i] = Image.FromFile(Application.StartupPath + @"\stalfos" + i.ToString() + ".gif");
            }
            //loads stalfos facing right
            for (int i = 0; i <= 6; i++)
            {
                rightstal[i] = Image.FromFile(Application.StartupPath + @"\stalfosr" + i.ToString() + ".gif");
            }

            
            


            // slashin' to the right
            for (int i = 0; i <= 3; i++)
            {
                linkslash[i] = Image.FromFile(Application.StartupPath + @"\slashr" + i.ToString() + ".gif");
            }
            // slashin' to the left
            for (int i = 0; i <= 3; i++)
            {
                linkslashl[i] = Image.FromFile(Application.StartupPath + @"\slash" + i.ToString() + ".gif");
            }



            //loads heartz
            Heart = Image.FromFile(Application.StartupPath + @"\heart.gif");

            Ded = Image.FromFile(Application.StartupPath + @"\ded.gif");

            // loads link standing right and left
            Stand = Image.FromFile(Application.StartupPath + @"\toonstand.gif");
            Standl = Image.FromFile(Application.StartupPath + @"\toonstandl.gif");

            //gameover font
            gameoverfont = Image.FromFile(Application.StartupPath + @"\Gamefont.png");

            Link = linkmove [1] ;
            //*****
            Stal = stalfos[1];
            RStal = rightstal[1];


            
            


            this.Focus(); 
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);
        }

        private void DrawStuff(Graphics g)
        {
           
            // background sidescrollin'

            if (x > 524 || x < -524)
                x = 0;

            if (y > 427 || y < -427)
                y = 0;



            for (int i = -524; i < 1048; i += 524)
            {
                for (int j = -427; j < 427; j += 427)
                {
                    g.DrawImage(backgrounds[backgroundcount], x + i, y+j);

                }
            }



            Font font = new Font("Comic Sans MS", 20, FontStyle.Regular);

            SolidBrush Brush = new SolidBrush(Color.White);


            // positions enemy and link
            g.DrawString("Kills: " + points.ToString(), font, Brush, 390, 15);
           

            g.DrawImage(stalfos[enemycount], xEnemy, 300);
            g.DrawImage(rightstal[enemycount], xEnemy2, 300);
            g.DrawImage(Link, xLink, 300);
            if (death == true)
            {
                g.DrawImage(gameoverfont, 250, 250);
            }

            heartx = 0;

            for(int i = 1; i <= myheart; i++)
            {                
            g.DrawImage(Heart, heartx, 10);
            heartx += 61;
            }
        }
       
    

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            // Link's direction (use of "Direction" variable)

            if (Direction == 1)
            {
                Link = linkmove[count];
                count++;
                
                if (count > 5)
                    count = 0;
            }
            if (Direction == 0)
            {
                if (slash == false)
                {
                    Link = Stand;
                }
                else if (slash == true)
                {
                    
                    Link = linkslash[slashcount];
                    slashcount++;
                }
                if (slashcount == 1)
                {
                    hitz.Play();
                }
                if (slashcount > 3)
                {
                    if (Direction == 0)
                    {
                        slashcount = 0;
                        Link = Stand;
                        slash = false;
                    }
                }
              
            }
            if (Direction == 2)
            {
                Link = linkmovel[count];
                count++;
                if (count > 5)
                    count =0;
            }
            if (Direction == 3)
            {
                if (slash == false)
                {
                    Link = Standl;
                }
                else if (slash == true)
                {
                    
                    Link = linkslashl[slashcount];
                    slashcount++;
                }
                if (slashcount == 1)
                {
                    hitzleft.Play();
                }
                    if (slashcount > 3)
                    {
                        if (Direction == 3)
                        {
                            slashcount = 0;
                            Link = Standl;
                            slash = false;
                        }
                        
                }
                
                
                
            }
            



            enemycount++;
            xEnemy -= 2;

            xEnemy2 += 2;
            if (enemycount > 5)
            {
                enemycount = 0;
            }
            if (points > 4)
            {
                xEnemy -= 6;
                xEnemy2 += 4;
            }
            if (points > 14)
            {
                xEnemy -= 15;
                xEnemy2 += 10;
            }
            if (points > 34)
            {
                xEnemy -= 25;
                xEnemy2 += 20;
            }
                

            Invalidate();
            
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            // moving
            if (e.KeyCode == Keys.D)
            {
                if (Direction < 4)
                {
                    Direction = 1;

                    x -= 5;

                    xEnemy -= 7;
                    xEnemy2 -= 3;
                    if (points > 5)
                    {
                        xEnemy -= 5;
                        xEnemy2 += 8;
                    }

                    if (keypress == false)
                    {
                        steps.PlayLooping();
                        keypress = true;
                    }

                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (Direction < 4)
                {
                    Direction = 2;

                    x += 5;
                    xEnemy += 3;
                    xEnemy2 += 7;
                    if (keypress == false)
                    {
                        steps.PlayLooping();
                        keypress = true;
                    }
                    if (points > 5)
                    {
                        xEnemy -= 4;
                        xEnemy2 += 8;
                    }
                }
                


            }

            if (Direction == 0 || Direction == 3)
            {

            if (e.KeyCode == Keys.W)
            {
                
                    if (slash == false)
                    {
                            slash = true;                        
                    }
               
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (death == true)
                {
                    Direction = 0;
                    Link = Stand;
                    myheart = 3;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    points = 0;
                    xEnemy = 560;
                    xEnemy2 = -100;
                    death = false;

                }
            }
            if (e.KeyCode == Keys.Back)
            {
                if (death == true)
                {
                    this.Close();
                }
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keypress = false;

            if (Direction == 1)
            {
                steps.Stop();
                
                Direction = 0;
            }
            if (Direction == 2)
            {
                steps.Stop();
                Direction = 3;
            }
        }

        private void Backgroundtime_Tick(object sender, EventArgs e)
        {
            //background array stuff
            //background do change after 20 seconds
            backgroundcount++;

            if (backgroundcount > 3)
            {
                backgroundcount = 0;
            }


            if (backgroundcount == 1)
            {
                Backgroundtime.Interval = 20000;
            }
            if (backgroundcount == 2)
            {
                Backgroundtime.Interval = 20000;
            }

            if (backgroundcount == 3)
            {
                Backgroundtime.Interval = 20000;
              
            }

                if (backgroundcount == 0)
                {
                    Backgroundtime.Interval = 30000;
                }
            
        }
        private void Coolisnt_Tick(object sender, EventArgs e)
        {
            if (myheart == 0)
            {
                
                Direction = 4;
                Link = Ded;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                death = true;
                
               
            }
           

            
            // collision issues - fixed?
            //((x + baby.Width > xtarget) && (x < xtarget + babytarget.Width)
            if (hit ==false && xLink + Link.Width >= xEnemy)
            {
                
                if (slash == false)
                {
                    if (death == false)
                    {
                        hit = true;
                        ow.Play();
                        myheart -= 1;
                        xEnemy += 270;
                        hit = false;
                    }
                    if (myheart == 0)
                    {
                        gameover.Play();
                    }
                }


                if (slash == true)
                {
                    if (death == false)
                    {
                        hit = true;
                        enemyded.Play();
                        xEnemy += 270;
                        points += 1;
                        hit = false;
                    }

                }


            }
            if (hit == false && xLink <= xEnemy2 + rightstal[0].Width)
            {

                if (slash == false)
                {
                    if (death == false)
                    {
                        hit = true;
                        owleft.Play();
                        myheart -= 1;
                        xEnemy2 = -70;
                        hit = false;
                    }
                    if (myheart == 0)
                    {
                        gameover.Play();
                    }

                }


                if (slash == true)
                {
                    if (death == false)
                    {
                        hit = true;
                        enemyded.Play();
                        xEnemy2 = -70;
                        points += 1;
                        hit = false;
                    }
                }



            
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

