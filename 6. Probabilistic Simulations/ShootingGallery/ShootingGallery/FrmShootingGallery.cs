using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShootingGallery
{
    public partial class FrmShootingGallery : Form
    {
        public FrmShootingGallery()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShootingGallery_Click(object sender, EventArgs e)
        {
            int PlatesHit;
            double TotalMoneyMade = 0;
            double MoneyMadeThisGame;
            double Average;

            Random r = new Random();

            LstDisplay.Items.Clear();

            //play 1000 times
            for (int simulation = 1; simulation <= 1000; simulation++)
            {

                MoneyMadeThisGame = 0.25;
                TotalMoneyMade += 0.25;

                string HitString = "";
                PlatesHit = 0;

                //each person takes 3 shots
                for (int shot = 1; shot <= 3; shot++)
                {
                    //hit or miss
                    int rNumber = r.Next(1, 3);
                    if (rNumber == 1)
                    {
                        PlatesHit++;
                        HitString += "H";
                        MoneyMadeThisGame -= 0.04;
                        TotalMoneyMade -= 0.04;
                    }
                    else
                    {
                        HitString += "M";
                    }
                }
                if (PlatesHit == 3)
                {
                    HitString += "*";
                    MoneyMadeThisGame -= 1.0;
                    TotalMoneyMade -= 1.0;
                }

                LstDisplay.Items.Add(HitString + "\t" + MoneyMadeThisGame.ToString("c2"));
            }
            Average = TotalMoneyMade / 1000;
            MessageBox.Show("Average Amount of Money Made per Player is " + Average.ToString("c2"));
        }
    }
}