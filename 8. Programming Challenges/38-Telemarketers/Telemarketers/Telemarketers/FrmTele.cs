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

namespace Telemarketers
{
    public partial class FrmTele : Form
    {
        public FrmTele()
        {
            InitializeComponent();
        }

        private void BtnTele_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\tele.txt";

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
                    if (TeleCheck(line))
                    {
                        TxtDisplay.Text += line + "  ignore ... from telemarketer" + Environment.NewLine;
                    }
                    else
                    {
                        TxtDisplay.Text += line + "  answer ... not from telemarketer" + Environment.NewLine;
                    }
                }
            }
        }

        private bool TeleCheck(string s)
        {
            bool status = false;  //start by assuming call is not from telemarketer

            string first = s.Substring(6, 1);

            string last = s.Substring(9, 1);

            string middle1 = s.Substring(7, 1);
            string middle2 = s.Substring(8, 1);

            if (first == "8" || first == "9") //check the first digit of last 4 numbers
            {

                if (last == "8" || last == "9") // check the last digit of last 4 numbers

                {
                    if (middle1 == middle2)     // check the middle two of last 4 numbers
                    {
                        status = true;  //call IS from telemarketer
                    }
                }

            }

            return status;
        }
    }
}
