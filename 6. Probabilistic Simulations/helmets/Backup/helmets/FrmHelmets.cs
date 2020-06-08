using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helmets
{
    public partial class FrmHelmets : Form
    {
        public FrmHelmets()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHelmets_Click(object sender, EventArgs e)
        {
            double MoneySpentThisSim;
            double TotalMoneySpentForAllSim=0.0;
            double Average;
            int hPicked;

            int [] HelmetFlag = new int[29];

            Random r = new Random();
                        
            LstDisplay.Items.Clear();

            for (int simulation=1;simulation<=1000;simulation++)
            {
                for (int h=1;h<=28;h++)
                {
                    HelmetFlag[h]=0;
                }                       
    
                MoneySpentThisSim = 0;
    
                
                for (int UniqueHelmet = 1;UniqueHelmet<=28;UniqueHelmet++)
                {
                    do
                    {
                        MoneySpentThisSim+=0.25;
                        hPicked = r.Next(1,29);
                    }
                    while(HelmetFlag[hPicked]==1);

                    HelmetFlag[hPicked]=1;
                }
                LstDisplay.Items.Add("Simulation " + Convert.ToString(simulation) + "-> " + MoneySpentThisSim.ToString("c2"));
                TotalMoneySpentForAllSim+= MoneySpentThisSim;
            }

            Average = TotalMoneySpentForAllSim / 1000;
            MessageBox.Show("The average total spent to get all 28 Helmets was " + Average.ToString("c2"));
        }

        
               
    }
}