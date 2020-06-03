using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogoAnimator
{
    public partial class FrmLogoAnimator : Form
    {
        public FrmLogoAnimator()
        {
            InitializeComponent();
        }

        Image[] images = new Image[30];
        int count = 0;

        private void FrmLogoAnimator_Load(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < 30; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\images\deitel" + i + ".gif");
            }

            PicLogo.Image = images[0]; // display first image

            // set PictureBox to be the same size as Image
            PicLogo.Size = PicLogo.Image.Size;
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicLogo.Image = images[count];
            count++;
            if (count > 29)
                count = 0;
        }
    }
}