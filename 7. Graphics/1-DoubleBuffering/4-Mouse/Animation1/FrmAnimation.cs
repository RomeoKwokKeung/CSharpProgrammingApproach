using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //Added for double buffering
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace Animation1
{
    public partial class FrmAnimation : Form
    {
        public FrmAnimation()
        {
            InitializeComponent();

            //Enabling double-buffering to avoid flicker
            
            //The draw process is modified so that instead of the paint handler
            //being passed a Graphic for the screen, it is passed a Graphic for an
            //in memory bitmap. 
            //When you draw to this Graphic object, you are drawing on an invisible image
            ///At the end of the draw cycle, this bitmap is copied to the main window
            //automatically and the actual pixels you see are all changed in a fraction
            //of a second instead of one at a time as the draw cycle progresses.

            this.DoubleBuffered = true;

            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
        }

        Image background = Image.FromFile(Application.StartupPath + @"\whack.gif");
        Image explode = Image.FromFile(Application.StartupPath + @"\explosion.gif");

        // Sound file strings
        SoundPlayer explosion = new SoundPlayer();

        int mouseX, mouseY;
        bool clicked=false;
               

        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            DrawStuff(g);           

        }

        private void DrawStuff(Graphics g)
        {
            g.DrawImage(background, 0, 0);

            Pen pen = new Pen(Color.Yellow);
            g.DrawLine(pen, mouseX, 0, mouseX, ClientSize.Height);
            g.DrawLine(pen, 0, mouseY, ClientSize.Width, mouseY);

            if (clicked == true)    //draw and play explosion - but not for too long
            {                       //thats where the timer comes in

                g.DrawImage(explode, mouseX-explode.Width/2, mouseY-explode.Height/2);
                explosion.Play();
                //if we just used mouseX,mouseY the top,left part of image would
                //be the location of the explosion 
                //(it would appear to explode down and to the right from where you are)
            }

            
        }

        private void FrmAnimation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clicked = true;
                timer1.Enabled = true;      //turns on timer for 2/10 of a second
                Invalidate();               //then puts clicked flag to false
            }                               //and turns off timer
        }

        private void FrmAnimation_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            Invalidate();
        }

        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            explosion.LoadAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clicked = false;            //if we didn't use a timer
            timer1.Enabled = false;     //explosion image would constantly be redrawn
            Invalidate();
        }           

        

        
    }
}