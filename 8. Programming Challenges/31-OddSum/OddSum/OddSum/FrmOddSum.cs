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

namespace OddSum
{
    public partial class FrmOddSum : Form
    {
        public FrmOddSum()
        {
            InitializeComponent();
        }

        private void BtnOddSum_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\oddsum.txt";

            StreamReader r = new StreamReader(f);

            string line;
            int upper, lower;
           
            
            line = r.ReadLine();
            int n = int.Parse(line);

            for (int i=1;i<=n;i++)
            {
                lower = int.Parse(r.ReadLine());
                upper = int.Parse(r.ReadLine());

                TxtDisplay.Text += "Case " + i.ToString() + " " + Odd(lower, upper) + Environment.NewLine;
            }           
            
        }

        private int Odd(int l, int u)
        {
            int total = 0;

            //if lower number is even move up to next odd number 
            //to begin sum
            if (l%2==0)
            {
                l++;
            }
            for (int i=l;i<=u;i+=2)
            {
                total += i;
            }

            return total;
        }
    }
}
