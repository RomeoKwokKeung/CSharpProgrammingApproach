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
            DataFile(stock, 3, 4);
            Display(stock, 3, 4);
            TxtDisplay.Text += "Table Total:  " + Convert.ToString(TableTotal(stock, 3, 4));

        }

        private void DataFile(int[,] s, int rows, int cols)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\stock.txt";

            StreamReader read = new StreamReader(f);
                       
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    s[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            read.Close();
        }

        private void Display(int[,] s, int rows, int cols)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Stock Table" + Environment.NewLine;

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(s[r, c]) + "\t" ;
                }
                TxtDisplay.Text += Environment.NewLine;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLoadDisplayNew_Click(object sender, EventArgs e)
        {
            int[,] stock = { {  3, 18, 20, 2 }, {  7, 48, 30, 98 }, { 50, 91, 83, 220 } };
            DisplayZeroBased(stock, 3, 4);
            TxtDisplay.Text += "Table Total:  " + Convert.ToString(TableTotalZeroBased(stock, 3, 4));

        }

        private void DisplayZeroBased(int[,] s, int rows, int cols)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Stock Table" + Environment.NewLine;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(s[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }
        }

        private int TableTotal(int[,] s, int rows, int cols)
        {
            int total = 0;

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    total += s[r, c];
                }
            }
            return total;
        }

        private int TableTotalZeroBased(int[,] s, int rows, int cols)
        {
            int total = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    total += s[r, c];
                }
            }
            return total;
        }

    }
}