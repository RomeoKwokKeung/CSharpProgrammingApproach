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
                rNumber = r.Next(6) + 1;   //1-6 (Hi-Lo+1) + Lo
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

        //spinner game
        private void btnProblem1_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            int player1 = 0;
            int player2 = 0;
            int spin = 0;

            Random r = new Random();

            //play the game ten times
            for (int i = 1; i <= 10; i++)
            {
                spin = r.Next(1, 10);
                player1 = player1 + spin;

                spin = r.Next(1, 10);
                player2 = player2 + spin;
            }

            if (player1 > player2)
            {
                MessageBox.Show("Player 1 wins with " + player1.ToString());
                MessageBox.Show("Player 2 had " + player2.ToString());
            }
            else if (player2 > player1)
            {
                MessageBox.Show("Player 2 wins with " + player2.ToString());
                MessageBox.Show("Player 1 had " + player1.ToString());
            }
        }

        //count how many time I got a seven
        private void btnProblem2_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            int seven = 0;
            int dice1 = 0;
            int dice2 = 0;

            Random r = new Random();

            //roll the dice 50 times
            for (int i = 1; i <= 50; i++)
            {
                dice1 = r.Next(1, 7);
                dice2 = r.Next(1, 7);
                if (dice1 + dice2 == 7)
                {
                    seven++;
                }
            }

            LstDisplay.Items.Add("The number of 7's rolled in 50 experiments is " + Convert.ToString(seven));
        }

        private void btnProblem3_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();

            int heads = 0;
            int toss = 0;
            int c47 = 0;

            Random r = new Random();

            //50 experiments
            for (int i = 1; i <= 50; i++)
            {
                heads = 0;

                for (int t = 1; t <= 100; t++)
                {
                    toss = r.Next(1, 3);
                    if (toss == 1)
                    {
                        heads++;
                    }
                }

                if (heads == 47)
                {
                    c47 = c47 + 1;
                }
            }

            LstDisplay.Items.Add("Heads 47 times " + Convert.ToString(c47));
        }
    }
}