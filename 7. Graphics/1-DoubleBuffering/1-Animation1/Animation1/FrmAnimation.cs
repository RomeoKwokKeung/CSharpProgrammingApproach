using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //Added for double buffering
using System.Text;
using System.Windows.Forms;


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

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        Image background = Image.FromFile(Application.StartupPath + @"\background.jpg");
        Image red_car = Image.FromFile(Application.StartupPath + @"\red_car.gif");
        int x;


        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);            

        }

        private void DrawStuff(Graphics g)
        {
            g.DrawImage(background, 0, 0);
            g.DrawImage(red_car, x, 10);
            g.DrawImage(red_car, x, 60);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x < this.Width)
                x += 2;
            else
                x = -100;

            Invalidate();
        }

        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            x = 0;            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}