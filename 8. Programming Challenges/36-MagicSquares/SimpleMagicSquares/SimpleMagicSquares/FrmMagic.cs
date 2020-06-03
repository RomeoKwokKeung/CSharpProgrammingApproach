using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleMagicSquares
{
    public partial class FrmMagic : Form
    {
        public FrmMagic()
        {
            InitializeComponent();
        }

        int[,] grid = new int[4, 4];
        string[] lines;

        private void BtnMagic_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\magic.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;
            
            TxtDisplay.Clear();

            //loop through two sets of data
            for (int i = 1; i <= 2; i++)
            {

                for (int x = 0; x < 4; x++)
                {
                    //read in entire line then split apart each number and
                    //store it into a 2d array
                    WholeLine = read.ReadLine();

                    lines = WholeLine.Split(' ');

                    for (int y = 0; y < 4; y++)
                    {
                        grid[x, y] = int.Parse(lines[y]);
                    }
                }

                //print out the original table
                Display(grid, 4, 4);

                string status = DetermineMagic(grid, 4);

                TxtDisplay.Text += status + Environment.NewLine;
                TxtDisplay.Text += Environment.NewLine;
            }


            read.Close();
        }

        private void Display(int[,] m, int rows, int cols)
        {

            TxtDisplay.Text += Environment.NewLine;

            //print out the 2d array table
            for (int r = 0; r < rows; r++)
            {

                for (int c = 0; c < cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            //TxtDisplay.Text += Environment.NewLine;

        }

        private string DetermineMagic(int[,] g, int rows)
        {
            //initialize the return value to MAGIC 
            //but if even one row or column case does not match
            //set it to NOT MAGIC
            string st = "MAGIC";

            //get total for first column as a base starting point
            int total = 0;
            for (int i = 0; i < rows; i++)
            {
                total += g[i, 0];//using column 0 (first column) and work through all the rows
            }                    //top to bottom

            //process board: ROWS
            for (int r = 0; r < rows; r++)
            {
                int sum = 0;
                for (int c = 0; c < rows; c++)
                {
                    sum += g[r, c];
                }

                if (sum != total)
                {
                    st = "NOT MAGIC";
                }
            }

            //process board:COLUMNS
            for (int c = 0; c < rows; c++)
            {
                int sum = 0;
                for (int r = 0; r < rows; r++)
                {
                    sum += g[r, c];
                }

                if (sum != total)
                {
                    st = "NOT MAGIC";
                }
            }
                        

            return st;

        }
    }
}
