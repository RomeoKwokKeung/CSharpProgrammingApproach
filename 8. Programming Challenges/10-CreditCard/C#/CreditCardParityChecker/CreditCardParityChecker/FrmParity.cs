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

namespace CreditCardParityChecker
{
    public partial class FrmParity : Form
    {
        public FrmParity()
        {
            InitializeComponent();
        }

        private void BtnParity_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\credit.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    if (Luhn(line))
                    {
                        TxtDisplay.Text += line + " IS CORRECT " + Environment.NewLine;
                    }
                    else
                    {
                        TxtDisplay.Text += line + " IS NOT CORRECT " + Environment.NewLine;
                    }
                }
            }
        }

        private bool Luhn(string creditnumber)
        {

            int[] num = new int[100];
            int digit;

            bool status = false;

            for (int i=0;i<creditnumber.Length;i++)
            {
                num[i] = int.Parse(creditnumber.Substring(i, 1));
            }

           
            for (int i=creditnumber.Length-1;i>=0;i--)
            {
                digit = num[i];
                if (i%2==0)
                {
                    digit = digit * 2;
                }
                if (digit/10>=1)
                {
                    digit = digit / 10 + digit % 10;
                }

                num[i] = digit;

            }

            int total = 0;
            for (int i=0;i<creditnumber.Length;i++)
            {
                total += num[i];
            }

            if (total%10==0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }
    }
}
