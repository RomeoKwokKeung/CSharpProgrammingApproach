using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FourInARow
{
    public partial class FrmFourInARow : Form
    {
        public FrmFourInARow()
        {
            InitializeComponent();
        }

        private void BtnFourInARow_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\four.txt";

            StreamReader r = new StreamReader(f);

            string number;
            bool finished = false;

            while (!finished)
            {
                number = r.ReadLine();
                if (number==null)
                {
                    finished=true;
                }
                else
                {
                    TxtDisplay.Text+= number + " " + Row(number) + " the sum of four consecutive integers " ;

                    if (Row(number)=="is")
                        DisplayNumbers(number);
                    else
                        TxtDisplay.Text +=Environment.NewLine;
                }
            }
            r.Close();
        }

        private string Row(string n)
        {
            string status = "";
            int num = int.Parse(n);

            if ((num - 6) % 4 == 0)
            {
                status = "is";
            }
            else
            {
                status = "is not";
            }

            return status;
        }

        private void DisplayNumbers(string n)
        {
            int num = int.Parse(n);
            int first = (num - 6) / 4;
            int last = first + 3;

            for (int i = first; i <= first + 2; i++)
            {
                TxtDisplay.Text += i.ToString() + "+";
            }

            TxtDisplay.Text += last.ToString() + Environment.NewLine;
        }
    }
}