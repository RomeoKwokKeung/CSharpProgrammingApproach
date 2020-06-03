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

namespace SingleDigit
{
    public partial class FrmSingleDigit : Form
    {
        public FrmSingleDigit()
        {
            InitializeComponent();
        }

        private void BtnSingleDigit_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\onedigit.txt";

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
                   
                    TxtDisplay.Text += "Sum of digits in " + line + " = " + One(line) +    Environment.NewLine;

                }
            }
        }

        private string One(string n)
        {
            int sumofdigits;
            string NewNumberString = n;

            
            while(true)
            {
                //when the current NUMBER is a single digit ... STOP
                if (NewNumberString.Length ==1)
                   break;

                sumofdigits = 0;

                //find the sum of the digits of the current NUMBER (as a string)
                for (int i=0;i<NewNumberString.Length;i++)
                {
                    sumofdigits += int.Parse(NewNumberString.Substring(i, 1));
                }

                //convert the current SUM back into a string 
                NewNumberString = sumofdigits.ToString();
            }

            return NewNumberString;
        }
    }
}
