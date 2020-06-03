using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlipBook
{
    public partial class FrmFlipBook : Form
    {
        public FrmFlipBook()
        {
            InitializeComponent();
        }

        Image[] images = new Image[8];
        int count = 1;
               
        private void FrmFlipBook_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 7; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\Dribble" + i.ToString() + ".bmp");
            }

            PicPlayer.Image = images[1]; // display first image

            // set PictureBox to be the same size as Image
            PicPlayer.Size = PicPlayer.Image.Size;  
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicPlayer.Image = images[count];
            count++;
            if (count > 7)
                count = 1;
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PicPlayer.Left += 5;

            if (PicPlayer.Left + PicPlayer.Width >= this.Width)
                timer2.Enabled=false; 
                
           
        }
    }
}