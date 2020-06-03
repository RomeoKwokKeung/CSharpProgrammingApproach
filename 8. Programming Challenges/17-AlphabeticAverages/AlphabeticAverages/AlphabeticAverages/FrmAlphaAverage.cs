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

namespace AlphabeticAverages
{
    public partial class FrmAlphaAverage : Form
    {
        public FrmAlphaAverage()
        {
            InitializeComponent();
        }

        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void BtnAlphaAverage_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\alpha.txt";

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
                    string word = line.ToUpper();

                    int count = 0;

                    //IndexOf returns position of letter in alpha string
                    //above but first postion is actually 0 
                    //so we need to add 1 to all the calculations
                    for (int i=0;i<word.Length;i++)
                    {
                        count += alpha.IndexOf(word.Substring(i, 1)) + 1;
                    }

                    //Here is a way to do the rounding up or down
                    double av1 = (count * 1.0) / word.Length;
                    int av2 = (int)av1;

                    if (av1 - av2 >= 0.5)
                        av2++;

                    //remember again here to offset answer to pull out correct string position
                    string middle = alpha.Substring(av2 - 1, 1);
                                        
                    TxtDisplay.Text += line + "-" + middle + Environment.NewLine;
                    
                }
            }
        }
    }
}
