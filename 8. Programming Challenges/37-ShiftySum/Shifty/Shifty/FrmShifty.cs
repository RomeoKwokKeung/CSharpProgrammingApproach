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

namespace Shifty
{
    public partial class FrmShifty : Form
    {
        public FrmShifty()
        {
            InitializeComponent();
        }

        private void BtnShifty_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\shifty.txt";

            StreamReader r = new StreamReader(f);

            string line1;
            string line2;

            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();

                if (line1 == null)
                {
                    finished = true;
                }
                else
                {
                    line2 = r.ReadLine();

                    int sum = shift(line1, line2);

                    TxtDisplay.Text += line1 + " shift " + line2 + " Shifted Sum = " + sum.ToString() +  Environment.NewLine;
                    
                }
            }
        }

        private int shift(string num, string shift)
        {
            string newnum = num;
            int shiftsum = 0;
            
            int s = int.Parse(shift);

            //add together all the newly created shifted numbers
            for (int i=1;i<=s;i++)
            {
                newnum += "0";
                shiftsum+=  int.Parse(newnum);
            }

            //add the original number to finish off the final sum
            shiftsum += int.Parse(num);
            
            return shiftsum;
        }
    }
}
