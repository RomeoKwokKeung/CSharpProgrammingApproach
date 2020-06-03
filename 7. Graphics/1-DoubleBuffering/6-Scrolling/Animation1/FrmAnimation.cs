using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //Added for double buffering
using System.Text;
using System.Windows.Forms;
using System.Media;         //needed for SoundPlayer Class


namespace Animation1
{
    public partial class FrmAnimation : Form
    {
        public FrmAnimation()
        {
            InitializeComponent();

            //Enabling double-buffering to avoid flicker
                        
            this.DoubleBuffered = true; ;
        }

        Image background = Image.FromFile(Application.StartupPath + @"\tile.jpg");
        Image baby;
        int xbaby;

        int x=0;  //used for scrolling
        int y=0;

        Image[] images = new Image[15];
        int count ;
                

        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);            

        }

        private void DrawStuff(Graphics g)
        {

            if (x > 100 || x < -100)
                x = 0;

            if (y > 100 || y < -100)
                y = 0;
            
            for (int i = -100; i < 400; i += 100)
            {
                for (int j = -100; j < 400; j += 100)
                {
                    g.DrawImage(background, x + i, y+j);

                }
            }

            g.DrawImage(baby, xbaby, 30);               
            
        }


        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            xbaby = this.Width/3;
            count = 1;

            for (int i = 1; i <= 14; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\baby" + i.ToString() + ".gif");
            }

            baby = images[1];
            
            this.Focus(); 
        }
                
        private void timer2_Tick(object sender, EventArgs e)
        {
            baby= images[count];
            count++;
            if (count > 14)
                count = 1;

            Invalidate();   //refreshes screen otherwise image wont change

        }

        private void FrmAnimation_KeyDown(object sender, KeyEventArgs e)
        {
            //Make sure to turn Num Lock on
            
            if (e.KeyCode == Keys.NumPad6)
            {
                x += 5;
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                x -= 5;
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                y -= 5;
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                y += 5;
            }
            
            Invalidate();
        }

        
    }
}