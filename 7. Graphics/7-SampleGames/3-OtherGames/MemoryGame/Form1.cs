#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace MemoryGame
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int choice;
        int[] picked = new int[2];
        int[] behind = new int[16];
        PictureBox[] displayed = new PictureBox[16];
        PictureBox[] choices = new PictureBox[8];
        Random myRandom = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //establish display and choices picture boxes
            displayed[0] = picHidden0;
            displayed[1] = picHidden1;
            displayed[2] = picHidden2;
            displayed[3] = picHidden3;
            displayed[4] = picHidden4;
            displayed[5] = picHidden5;
            displayed[6] = picHidden6;
            displayed[7] = picHidden7;
            displayed[8] = picHidden8;
            displayed[9] = picHidden9;
            displayed[10] = picHidden10;
            displayed[11] = picHidden11;
            displayed[12] = picHidden12;
            displayed[13] = picHidden13;
            displayed[14] = picHidden14;
            displayed[15] = picHidden15;
            choices[0] = picChoice0;
            choices[1] = picChoice1;
            choices[2] = picChoice2;
            choices[3] = picChoice3;
            choices[4] = picChoice4;
            choices[5] = picChoice5;
            choices[6] = picChoice6;
            choices[7] = picChoice7;
            // start new game
            btnNew.PerformClick();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                // replace with card back
                displayed[i].Image = picBack.Image;
                displayed[i].Visible = true;
                behind[i] = i;
            }
            // Randomly sort 16 integers (0 to 15) 
            // behind array contains indexes (0-7) for hidden pictures
            // Work through remaining values
            // Start at 16 and swap one value
            // at each for loop step
            // After each step, remaining is decreased by 1
            for (int remaining = 16; remaining >= 1; remaining--)
            {
                // Pick item at random
                int itemPicked = myRandom.Next(remaining);
                // Swap picked item with bottom item
                int tempValue = behind[itemPicked];
                behind[itemPicked] = behind[remaining - 1];
                behind[remaining - 1] = tempValue;
            }
            for (int i = 0; i < 16; i++)
            {
                if (behind[i] > 7)
                {
                    behind[i] = behind[i] - 8;
                }
            }
            choice = 0;
        }

        private void picHidden0_Click(object sender, EventArgs e)
        {
            picked[choice] = 0;
            btnCheck.PerformClick();
        }

        private void picHidden1_Click(object sender, EventArgs e)
        {
            picked[choice] = 1;
            btnCheck.PerformClick();
        }

        private void picHidden2_Click(object sender, EventArgs e)
        {
            picked[choice] = 2;
            btnCheck.PerformClick();
        }

        private void picHidden3_Click(object sender, EventArgs e)
        {
            picked[choice] = 3;
            btnCheck.PerformClick();
        }

        private void picHidden4_Click(object sender, EventArgs e)
        {
            picked[choice] = 4;
            btnCheck.PerformClick();
        }

        private void picHidden5_Click(object sender, EventArgs e)
        {
            picked[choice] = 5;
            btnCheck.PerformClick();
        }

        private void picHidden6_Click(object sender, EventArgs e)
        {
            picked[choice] = 6;
            btnCheck.PerformClick();
        }

        private void picHidden7_Click(object sender, EventArgs e)
        {
            picked[choice] = 7;
            btnCheck.PerformClick();
        }

        private void picHidden8_Click(object sender, EventArgs e)
        {
            picked[choice] = 8;
            btnCheck.PerformClick();
        }

        private void picHidden9_Click(object sender, EventArgs e)
        {
            picked[choice] = 9;
            btnCheck.PerformClick();
        }

        private void picHidden10_Click(object sender, EventArgs e)
        {
            picked[choice] = 10;
            btnCheck.PerformClick();
        }

        private void picHidden11_Click(object sender, EventArgs e)
        {
            picked[choice] = 11;
            btnCheck.PerformClick();
        }

        private void picHidden12_Click(object sender, EventArgs e)
        {
            picked[choice] = 12;
            btnCheck.PerformClick();
        }

        private void picHidden13_Click(object sender, EventArgs e)
        {
            picked[choice] = 13;
            btnCheck.PerformClick();
        }

        private void picHidden14_Click(object sender, EventArgs e)
        {
            picked[choice] = 14;
            btnCheck.PerformClick();
        }

        private void picHidden15_Click(object sender, EventArgs e)
        {
            picked[choice] = 15;
            btnCheck.PerformClick();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Only execute if not trying to pick same box
            if (choice == 0 || (choice == 1 && picked[0] != picked[1]))
            {
                // Display selected picture
                displayed[picked[choice]].Image = choices[behind[picked[choice]]].Image;
                displayed[picked[choice]].Refresh();
                if (choice == 0)
                {
                    // first choice - just display
                    choice = 1;
                }
                else
                {
                    // Delay for one second before checking
                    timDelay.Enabled = true;
                }
            }
        }

        private void timDelay_Tick(object sender, EventArgs e)
        {
            timDelay.Enabled = false;
            // After delay, check for match
            if (behind[picked[0]] == behind[picked[1]])
            {
                // If match, remove pictures
                displayed[picked[0]].Visible = false;
                displayed[picked[1]].Visible = false;
            }
            else
            {
                // If no match, blank picture, restore backs
                displayed[picked[0]].Image = picBack.Image;
                displayed[picked[1]].Image = picBack.Image;
            }
            choice = 0;
        }
    }
}