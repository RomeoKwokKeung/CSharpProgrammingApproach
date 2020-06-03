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

namespace iProfit
{
    public partial class FrmProfit : Form
    {
        public FrmProfit()
        {
            InitializeComponent();
        }

        private void BtnProfit_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\profit.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            int copies;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    copies = Profit(int.Parse(line));
                    {
                        TxtDisplay.Text += copies.ToString()+  Environment.NewLine;
                    }
                }
            }
        }

        private int Profit(int p)
        {
            int numberCopies = 0;

            //Background Math Prep (where c is copies to be sold and p is desired profit)
            //c*.99 - c*.99*.3 = p
            //c*.99(1-.3)=p
            //c=p/.99*.7
            double c = p / (.99 * .7);

            //Now we have to figure out how to round up to the next 1000
            //Math.Ceiling 
            //Rounds up to the next full integer.This means that any number over 1 but under 2 would be rounded to 2.
            //This is not the same result from rounding a number.

            numberCopies = (int)(Math.Ceiling((c - 0.00001) / 1000) * 1000);
            
            return numberCopies;
        }
    }
}
