using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoreRandomNumbers
{
    public partial class FrmMoreRandomNumbers : Form
    {
        public FrmMoreRandomNumbers()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCointToss_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();

            int ThreeHeads = 0;
            int coin;

            for (int exp=1;exp<=50;exp++)
            {
                int h=0;
                int t=0;
                string result="";

                for(int toss=1;toss<=4;toss++)
                {
                    coin=r.Next(1,3);

                    if (coin==1)
                    {
                        h++;
                        result+="h";
                    }
                    else
                    {
                        t++;
                        result+="t";
                    }
                }

                if (h==3)
                {
                    ThreeHeads++;
                    result+="*";
                }

                LstDisplay.Items.Add(result);
            }
            LstDisplay.Items.Add("There were 3 heads in 50 toss " + Convert.ToString(ThreeHeads) + " times");


        }

        private void BtnDiceSum_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("roll 1" + "\t"+ "roll 2" + "\t" + "sum");
            
            string[] dicewords = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

            Random r = new Random();

            for (int roll=1;roll<=20;roll++)
            {
                int dice1 = r.Next(1, 7);
                int dice2=r.Next(1,7);
                int sum=dice1+dice2;

                LstDisplay.Items.Add(dicewords[dice1]+ "\t" + dicewords[dice2]+ "\t" + dicewords[sum]);
            }
        }

        private void BtnDieCounter_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("Dice roll" + "\t" + "Frequency");

            int[] frequency = new int[7];
            int roll;

            Random r = new Random();

            for (int i = 1; i <= 100; i++)
            {
                roll = r.Next(1, 7);
                frequency[roll]++;
            }

            for (int i = 1; i <= 6; i++)
            {
                LstDisplay.Items.Add(Convert.ToString(i) + "\t" + Convert.ToString(frequency[i]));
            }

        }


    }
}