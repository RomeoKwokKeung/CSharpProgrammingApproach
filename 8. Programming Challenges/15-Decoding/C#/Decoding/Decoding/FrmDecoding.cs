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

namespace Decoding
{
    public partial class FrmDecoding : Form
    {
        public FrmDecoding()
        {
            InitializeComponent();
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            //Look up array for decoding
            string[] letters = { "a", "b", "d", "e", "h", "l", "o", "r", "w" };

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\decode.txt";

            StreamReader r = new StreamReader(f);

            int count = int.Parse(r.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string s = r.ReadLine();
                int x = 0;

                while(true)
                {

                    //search binary code for location of 1 then extract character from lookup array at position x
                    x = s.IndexOf('1');
                    if (x == -1)
                        break;

                    TxtDisplay.Text += letters[x];

                    //this covers the case where the code is a single  1 bit
                    if (s == "1")
                        break;

                    s = s.Substring(x + 1);
                    //at the end of the code when there is nothing left to take s will equal ""
                    //so when we go up to the top of the while loop  and look for a 1 it will return -1 and exit

                }

                TxtDisplay.Text += Environment.NewLine;
                
            }


            r.Close();
        }
    }
}
