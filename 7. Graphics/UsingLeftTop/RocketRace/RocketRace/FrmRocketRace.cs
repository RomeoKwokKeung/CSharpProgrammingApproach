using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RocketRace
{
    public partial class FrmRocketRace : Form
    {
        public FrmRocketRace()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int r1up, r2up;

            while (PicRocket1.Top >= 0 && PicRocket2.Top >= 0)
            {
                r1up = r.Next(2); //0-1
                r2up = r.Next(2);
                
                PicRocket1.Top -= r1up;
                PicRocket2.Top -= r2up;
            }

            if (PicRocket1.Top <=0 && PicRocket2.Top <=0)
            {
                MessageBox.Show("Its a Tie!!!");
            }
            else if (PicRocket1.Top <= 0)
            {
                MessageBox.Show("Rocket 1 Wins !!!");
            }
            else
            {
                MessageBox.Show("Rocket 2 Wins !!!");
            }           
        
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PicRocket1.Left = 169;
            PicRocket1.Top = 337;
            
            PicRocket2.Left = 235;
            PicRocket2.Top = 337;
        }
    }
}