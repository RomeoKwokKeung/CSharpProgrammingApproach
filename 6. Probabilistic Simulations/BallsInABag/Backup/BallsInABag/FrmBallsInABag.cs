using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BallsInABag
{
    public partial class FrmBallsInABag : Form
    {
        public FrmBallsInABag()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBalls_Click(object sender, EventArgs e)
        {
            int white,black,red;
            int ball;
            string ballstring;
            int total = 0;

            Random r = new Random();

            LstDisplay.Items.Clear();
            
            for (int s=1;s<=1000;s++)
            {
                white = 0;
                black = 0;
                red = 0;
                ballstring = "";
            
                for (int draw = 1;draw<=4;draw++)
                {
                    ball = r.Next(1,19);
        
                    if (ball <=5)
                    {
                        white++;
                        ballstring+="w";
                    }
                    else if (ball<=15)
                    {
                        black++;
                        ballstring+="b";
                    }
                    else
                    {
                        red++;
                        ballstring+="r";
                    }
                }
                if (white==1 && red==1 && black==2)
                {
                    total++;
                    ballstring+="***";
                }   
    
                LstDisplay.Items.Add(ballstring);
            }
            MessageBox.Show("The number of occurences of 1 white, 1 red and 2 black balls " + "\n"+ " in 1000 four ball draws with replacement is " + total.ToString());
        }
    }
}