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
        Image baby;
        int x;

        Image[] images = new Image[15];
        int count ;

        // Sound file strings
        SoundPlayer explosion = new SoundPlayer();
        

        private void FrmAnimation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);            

        }

        private void DrawStuff(Graphics g)
        {
            Font font = new Font("Arial",9,FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            
            g.DrawImage(background, 0, 0);
            g.DrawString("Turn Num Lock On Then move left and right with the 4 and 6 keys", font, yellowBrush, 3, 10);
            g.DrawString("Shoot with the 8 key", font, yellowBrush, 100, 110);
            g.DrawImage(baby, x, 30);
            
        }
               

        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            x = this.Width/3;
            count = 1;

            for (int i = 1; i <= 14; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\baby" + i.ToString() + ".gif");
            }

            baby = images[1];

            explosion.SoundLocation = Application.StartupPath + @"\explosion.wav";
            explosion.LoadAsync();

            this.Focus(); 
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
            
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
                explosion.Play();
            }

            Invalidate();
        }

        
    }
}