#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace CardWars
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [] cardNumber = new int[52];
        int cardIndex;

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Exit")
            {
                // Stop program
                this.Close();
            }
            else
            {
                //  Stop game
                txtOver.Visible = true;
                btnExit.Text = "Exit";
                btnNew.Text = "New Game";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Method level variables
            Random myRandom = new Random();
            int yourNumber = 0; // Your card number
            int computerNumber = 0; // Computer card number
            if (btnNew.Text == "New Game")
            {
                // New game clicked
                txtOver.Visible = false;
                btnNew.Text = "Next Card";
                btnExit.Text = "Stop";
                // Zero out scores
                txtYouScore.Text = "0";
                txtCompScore.Text = "0";
                // Shuffle cards using one card shuffle code
                // Initialize CardNumbers
                for (int loopCounter = 0; loopCounter < 52; loopCounter++)
                {
                    cardNumber[loopCounter] = loopCounter;
                }
                // Work through remaining values
                // Start at 52 and swap one value
                // at each for loop step
                // After each step, remaining is decreased by 1
                for (int remaining = 52; remaining >= 1; remaining--)
                {
                    // Pick item at random
                    int itemPicked = myRandom.Next(remaining);
                    // Swap picked item with bottom item
                    int tempValue = cardNumber[itemPicked];
                    cardNumber[itemPicked] = cardNumber[remaining - 1];
                    cardNumber[remaining - 1] = tempValue;
                }
                // Set CardIndex to zero
                cardIndex = 0;
            }
            // Display cards
            // Display your card's suit
            // Determine your card's number for comparisons
            if (cardNumber[cardIndex] >= 0 && cardNumber[cardIndex] <= 12)
            {
                picPlayer.Image = picHeart.Image;
                yourNumber = cardNumber[cardIndex];
            }
            else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 25)
            {
                picPlayer.Image = picDiamond.Image;
                yourNumber = cardNumber[cardIndex] - 13;
            }
            else if (cardNumber[cardIndex] >= 26 && cardNumber[cardIndex] <= 38)
            {
                picPlayer.Image = picClub.Image;
                yourNumber = cardNumber[cardIndex] - 26;
            }
            else if (cardNumber[cardIndex] >= 39 && cardNumber[cardIndex] <= 51)
            {
                picPlayer.Image = picSpade.Image;
                yourNumber = cardNumber[cardIndex] - 39;
            }
            // Display your card's value
            switch (yourNumber)
            {
                case 9:
                    lblPlayer.Text = "J";
                    break;
                case 10:
                    lblPlayer.Text = "Q";
                    break;
                case 11:
                    lblPlayer.Text = "K";
                    break;
                case 12:
                    lblPlayer.Text = "A";
                    break;
                default:
                    lblPlayer.Text = Convert.ToString(yourNumber + 2) + " ";
                    break;
            }

            // Display computer's card suit
            // Determine computer's number for comparisons
            if (cardNumber[cardIndex + 26] >= 0 && cardNumber[cardIndex + 26] <= 12)
            {
                picComputer.Image = picHeart.Image;
                computerNumber = cardNumber[cardIndex + 26];
            }
            else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 25)
            {
                picComputer.Image = picDiamond.Image;
                computerNumber = cardNumber[cardIndex + 26] - 13;
            }
            else if (cardNumber[cardIndex + 26] >= 26 && cardNumber[cardIndex + 26] <= 38)
            {
                picComputer.Image = picClub.Image;
                computerNumber = cardNumber[cardIndex + 26] - 26;
            }
            else if (cardNumber[cardIndex + 26] >= 39 && cardNumber[cardIndex + 26] <= 51)
            {
                picComputer.Image = picSpade.Image;
                computerNumber = cardNumber[cardIndex + 26] - 39;
            }
            // Display computer card's value
            switch (computerNumber)
            {
                case 9:
                    lblComputer.Text = "J";
                    break;
                case 10:
                    lblComputer.Text = "Q";
                    break;
                case 11:
                    lblComputer.Text = "K";
                    break;
                case 12:
                    lblComputer.Text = "A";
                    break;
                default:
                    lblComputer.Text = Convert.ToString(computerNumber + 2) + " ";
                    break;
            }
            // Compare displayed cards
            if (yourNumber > computerNumber)
            {
                // You win
                txtYouScore.Text = Convert.ToString(Convert.ToInt32(txtYouScore.Text) + 2);
            }
            else if (computerNumber > yourNumber)
            {
                // Computer win
                txtCompScore.Text = Convert.ToString(Convert.ToInt32(txtCompScore.Text) + 2);
            }
            else
            {
                // a tie!
                txtYouScore.Text = Convert.ToString(Convert.ToInt32(txtYouScore.Text) + 1);
                txtCompScore.Text = Convert.ToString(Convert.ToInt32(txtCompScore.Text) + 1);
            }
            cardIndex++;
            // Check to see if all cards have been used
            if (cardIndex > 25)
            {
                // Game over
                txtOver.Visible = true;
                btnNew.Text = "New Game";
                btnExit.Text = "Exit";
            }
        }
    }
}