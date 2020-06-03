#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DiceRoll
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[] dots = new Image[7];
        Random myRandom = new Random();
        int roll1, roll2;

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                DisplayTotal();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize display
            dots[1] = picDots1.Image;
            dots[2] = picDots2.Image;
            dots[3] = picDots3.Image;
            dots[4] = picDots4.Image;
            dots[5] = picDots5.Image;
            dots[6] = picDots6.Image;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Roll Dice 1 and set display
            roll1 = myRandom.Next(1,7);
            picDice1.Image = dots[roll1];

            // Roll Dice 2 and set display
            roll2 = myRandom.Next(1,7);
            picDice2.Image = dots[roll2];
        }

        private void DisplayTotal()
        {
            int sum = roll1 + roll2;
            if (sum == 7)
            {
                LblResults.Text = "Your rolled lucky  " + sum.ToString();
            }
            else
            {
                LblResults.Text = "Your rolled " + sum.ToString();
            }
        }


    }
}