using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class FrmSlotMachine : Form
    {
        public FrmSlotMachine()
        {
            InitializeComponent();
        }

        Image[] images = new Image[4];
        Random r = new Random();

        int slot1, slot2,slot3;
        int nSpins;
        int spinCounter;

        int BankRoll;
        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ended up with " + BankRoll.ToString("c") + "\n" + "Game Over");
            this.Close();
        }

        private void FrmSlotMachine_Load(object sender, EventArgs e)
        {
            images[0] = PicOne.Image;
            images[1] = PicTwo.Image;
            images[2] = PicThree.Image;
            images[3] = PicFour.Image;

            BankRoll = 100;

            TxtBankRoll.Text = BankRoll.ToString("c");
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (BankRoll==0)
            {
                MessageBox.Show("Out of Cash " + "\n" + "Game Over");
                this.Close();
            }
            else
            {
                BankRoll--;
                TxtBankRoll.Text=BankRoll.ToString("c");
                spinCounter=0;
                nSpins=r.Next(10,50);
                timer1.Enabled=true;
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spinCounter++;
            
            slot1 = r.Next(4);
            PicSlot1.Image = images[slot1];

            slot2 = r.Next(4);
            PicSlot2.Image = images[slot2];

            slot3 = r.Next(4);
            PicSlot3.Image = images[slot3];
                                                           
            if (spinCounter==nSpins)
            {
                timer1.Enabled=false;
                DetermineWinnings();
            }
            
        }

        private void DetermineWinnings()
        {
            int winnings = 0;

            if (slot1 == slot2 && slot2 == slot3)
            {
                MessageBox.Show("Three in a Row !!! $10");
                winnings = 10;
            }
            else if (slot1 == slot2 || slot2 == slot3)
            {
                MessageBox.Show("Two Consecutive $5");
                winnings = 5;
            }
            else if (slot1 == slot3)
            {
                MessageBox.Show("Two Non-Consecutive $2");
                winnings = 2;
            }
            else
            {
                MessageBox.Show("Sorry you lose ");
            }

            BankRoll += winnings;

            TxtBankRoll.Text = BankRoll.ToString("c");
            
            
        }


        
    }
}