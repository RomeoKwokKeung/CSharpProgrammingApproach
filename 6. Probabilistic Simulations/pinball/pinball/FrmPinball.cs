using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pinball
{
    public partial class FrmPinball : Form
    {
        public FrmPinball()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPinball_Click(object sender, EventArgs e)
        {
            int [] pocketCount = new int [8];

            Initialize(pocketCount, 7);
            Simulate(pocketCount);
            Display(pocketCount);
        }

        private void Initialize(int [] p, int u)
        {
            for (int i = 1; i <= u; i++)
            {
                p[i] = 0;
            }
        }

        private void Simulate(int [] p)
        {
            Random r = new Random();
            double pocket;
            
            for(int ball=1;ball<=100;ball++)
            {
                pocket=4.0;
            
                for (int level=1;level<=6;level++)
                {
                    //right or left side
                    int rNumber=r.Next(1,3);
                    if (rNumber==1)
                    {
                        pocket+=.5;
                    }
                    else
                    {
                        pocket-=.5;
                    }
                }

                //array argument must be an integer
                //so we must cast it to an integer
                int c = (int)pocket;

                p[c]= p[c]+1;
            }    
        }

        private void Display(int [] p)
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("Pocket" + "\t" + "Frequency");

            for (int i = 1; i <= 7; i++)
            {
                LstDisplay.Items.Add(Convert.ToString(i) + "\t" + Convert.ToString(p[i]));
            }
        }
    

    }
}