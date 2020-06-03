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

namespace PennyLane
{
    public partial class FrmPenny : Form
    {
        public FrmPenny()
        {
            InitializeComponent();
        }

        string[,] units = { { "dollar", "dollars" }, { "half-dollar", "half-dollars" }, { "quarter", "quarters" }, { "dime", "dimes" }, { "nickel", "nickels" }, { "penny", "pennies" } };

        private void BtnPenny_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\penny.txt";

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

                    //locate where the decimal point is
                    int idx = line.IndexOf('.');
                    
                    //pull apart the dollars and the cents
                    int dol = int.Parse(line.Substring(1, idx-1));
                    int pen = int.Parse(line.Substring(idx + 1));

                    //convert the whole amount to cents (pennies)
                    int total = dol * 100 + pen;

                    TxtDisplay.Text += line + Environment.NewLine;

                    //now lets figure out the coins needed to produce the total above
                    //we call the reduce method and pass down the idx (for the 2d array) and the coin amount
                    total = reduce(total, 0, 100);
                    total = reduce(total, 1, 50);
                    total = reduce(total, 2, 25);
                    total = reduce(total, 3, 10);
                    total = reduce(total, 4, 5);
                    total = reduce(total, 5, 1);

                    TxtDisplay.Text += Environment.NewLine;
                    
                }
            }
        }

        private int reduce(int total, int idx,int unit)
        {
            //if dollar value or penny value 0 return zero
            if (total==0)
            {
                return total;
            }

            //if current coin ie. 100 (dollar), 50, etc is greater
            //than current total than just return current total back 
            if (unit > total )
            {
                return total;
            }

            int numUnits = 0;
            int plural = 0;//if it gets to 2 we need to add 's' or 'ies'

            while (total>=unit)
            {
                numUnits++;
                total -= unit;
                plural++;
            }

            if(plural>=2)
            {
                plural = 2;
            }

            //Access the 2d Array to produce the right coin wording
            TxtDisplay.Text += numUnits + " " + units[idx,plural-1] + Environment.NewLine;

            return total;
        }
    }
}
