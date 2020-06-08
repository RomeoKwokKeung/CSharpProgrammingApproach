using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DartBoard
{
    public partial class FrmDartBoard : Form
    {
        public FrmDartBoard()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDartBoard_Click(object sender, EventArgs e)
        {
            int[] RegionPointValue = { 0, 7, 5, 3, 1 };
            int[] RegionHitCount = new int[5];

            int toss=0;
            int TotalPoints=0;
            int region;
            double rNumber;

            Rand.Init(Math.Pow(2, 7) + 3, Math.Pow(2,15), 1);

            while(true)
            {
                toss++;

                rNumber=Rand.RandomUniform();
                
                if (rNumber<=.1)
                {
                    region=1;
                }
                else if (rNumber<.4)
                {
                    region=2;
                }
                else if (rNumber<=.7)
                {
                    region=3;
                }
                else
                {
                    region=4;
                }

                RegionHitCount[region]++;
                TotalPoints+=RegionPointValue[region];
                    
                if (TotalPoints >=1000)
                    break;
            } 

            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("REGION" + "\t"+ "HITS" + "\t" + "POINTS");

            for (int r=1;r<=4;r++)
            {
                LstDisplay.Items.Add(r.ToString() + "\t" + Convert.ToString(RegionHitCount[r]) + "\t" + Convert.ToString(RegionHitCount[r]*RegionPointValue[r]));
            }           

            LstDisplay.Items.Add(" ");
            LstDisplay.Items.Add("TOTAL" + "\t" + TotalPoints.ToString());

        }
    }
}