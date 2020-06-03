using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TwoDIntro
{
    public partial class FrmTwoDIntro : Form
    {
        public FrmTwoDIntro()
        {
            InitializeComponent();
        }

        private void BtnLoadDisplay_Click(object sender, EventArgs e)
        {
            int[,] stock = new int[4, 5];

            //Read in the data file
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\stock.txt";

            StreamReader read = new StreamReader(f);

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    stock[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            read.Close();

            //Display the 2d table
            
            TxtDisplay.Clear();
            TxtDisplay.Text = "Stock Table" + Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    TxtDisplay.Text += Convert.ToString(stock[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            //add up all the numbes in the 2d array

            int total = 0;

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    total += stock[r, c];
                }
            }
            
            TxtDisplay.Text += "Table Total:  " + total.ToString();

        }

        

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        

    }
}