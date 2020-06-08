using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomNumbersIntro
{
    public partial class FrmRandomNumberIntro : Form
    {
        public FrmRandomNumberIntro()
        {
            InitializeComponent();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();
            
            int rNumber;

            for (int i = 1; i <= 100; i++)
            {
                rNumber = r.Next(10);   //0-9
                LstDisplay.Items.Add(Convert.ToString(rNumber));
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOneToSix_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();

            int rNumber;

            for (int i = 1; i <= 100; i++)
            {
                rNumber = r.Next(6) +1 ;   //1-6 (Hi-Lo+1) + Lo
                //rNumber = r.Next(1, 7);
                LstDisplay.Items.Add(Convert.ToString(rNumber));
            }
        }

        private void BtnSevenToTwenty_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();

            int rNumber;

            for (int i = 1; i <= 100; i++)
            {
                rNumber = r.Next(14) + 7;   //(Hi-Lo) + Lo
                //rNumber = r.Next(7, 21);
                LstDisplay.Items.Add(Convert.ToString(rNumber));
            }
        }

        private void BtnHeadsTails_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            int heads = 0;
            int tails = 0;

            int toss;

            Random r = new Random();

            for (int i = 1; i <= 100; i++)
            {
                toss = r.Next(1, 3);
                if (toss == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            LstDisplay.Items.Add("Heads " + Convert.ToString(heads));
            LstDisplay.Items.Add("Tails " + Convert.ToString(tails));

        }
    }
}