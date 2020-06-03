using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestPartA
{
    public partial class FrmTestPartA : Form
    {
        public FrmTestPartA()
        {
            InitializeComponent();
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            
            //Declare variables
            int[,] sales = new int[5, 7];
            string[] salesperson = new string[5];
            string[] days = new string[7];
            double[] comrate = new double[7];

            TxtDisplay.Clear();
            TxtDisplay.Text = "Sales Analysis" + Environment.NewLine + Environment.NewLine;

            TxtDisplay.Text += "Original Data" + Environment.NewLine;

            
            //Read in data
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\salesdata.txt";

            StreamReader read = new StreamReader(f);

            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    sales[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            for (int r = 1; r <= 4; r++)
            {
                salesperson[r] = read.ReadLine();
            }

            for (int c = 1; c <= 6; c++)
            {
                days[c] = read.ReadLine();
            }

            for (int c = 1; c <= 6; c++)
            {
                comrate[c] = Convert.ToDouble(read.ReadLine());
            }

            read.Close();

            
            //Display original data
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "\t";

            for (int c = 1; c <= 6; c++)
            {
                TxtDisplay.Text += days[c] + "\t";
            }

            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= 4; r++)
            {
                TxtDisplay.Text += salesperson[r] + "\t";
                for (int c = 1; c <= 6; c++)
                {
                    TxtDisplay.Text += Convert.ToString(sales[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

            //change Franks sales for Thurs to 1500
            sales[3, 4] = 1500;

            //copy Lucy's sales for Wed into Karen's sales for Monday
            sales[4, 1] = sales[2, 3];

            //add 10 to all the sales
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    sales[r, c] += 10;
                }
            }

            //Display the names of all salespeople and dates
            //for which sales were below 1000

            TxtDisplay.Text += "Sales under 1000 " + Environment.NewLine;

            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (sales[r, c] < 1000)
                    {
                        TxtDisplay.Text += salesperson[r] + "\t" + days[c] + "\t" + sales[r, c].ToString() + Environment.NewLine;
                    }
                }
            }

            TxtDisplay.Text += Environment.NewLine;

            //Display largest sale amount
            int big = -1;
            int posname = 0;
            int posday = 0;

            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (sales[r, c] > big)
                    {
                        big = sales[r, c];
                        posname = r;
                        posday = c;
                    }

                }
            }

            TxtDisplay.Text += "The highest sales was " + big.ToString() + " it was obtained by " + salesperson[posname] + " on  " + days[posday] + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            //Determine weekly sales for each salesperson
            int[] weeklysales = new int[5];

            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    weeklysales[r] += sales[r, c];
                }
            }

            TxtDisplay.Text += "Sales People Totals:  " + Environment.NewLine;

            for (int r = 1; r <= 4; r++)
            {
                TxtDisplay.Text += salesperson[r] + "\t" + Convert.ToString(weeklysales[r]) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

            //Determine sales person with greatest weekly sales
            int bigsales = -1;
            int pos = 0;

            //Here we are using the array totals that were calculated in the previous 
            //method above

            for (int r = 1; r <= 4; r++)
            {
                if (weeklysales[r] > bigsales)
                {
                    bigsales = weeklysales[r];
                    pos = r;
                }

            }

            TxtDisplay.Text += "The highest mark total is " + bigsales.ToString() + " obtained by " + salesperson[pos] + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            //Determine pay for each sales person based on commission rates
            
            double[] pay = new double[5];

            //note that the commission array is written as comrate[c]
            //we use c because the commissions are BASED on the days of the week 
            //which are columns.

            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    pay[r] += sales[r, c] * comrate[c];
                }
            }

            TxtDisplay.Text += "Sales People Pay:  " + Environment.NewLine;

            for (int r = 1; r <= 4; r++)
            {
                TxtDisplay.Text += salesperson[r] + "\t" + pay[r].ToString("c") + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}