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

namespace CountingSwann
{
    public partial class FrmSwann : Form
    {
        public FrmSwann()
        {
            InitializeComponent();
        }

        private void BtnSwann_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\swann.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;
            int sample= 0;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    sample++;
                    TxtDisplay.Text += "Sample Number " + sample.ToString() +  Environment.NewLine;
                    TxtDisplay.Text += Counting(int.Parse(line)) + Environment.NewLine + Environment.NewLine; 
                    
                }
            }
        }

        private string Counting(int number)
        {
            string result = "";

            for (int i=1;i<=number;i++)
            {
                if (i%3==0) //remember % is used to determine remainders
                {
                    if (i%5==0)
                    {
                        result += "GoodMan" + Environment.NewLine;
                    }
                    else
                    {
                        result += "Good" + Environment.NewLine;
                    }
                }
                else if (i%5==0)
                {
                    result += "Man" + Environment.NewLine;
                }
                else
                {
                    result += i.ToString() + " ";
                }
            }

            return result;
        
        }
    }
}
