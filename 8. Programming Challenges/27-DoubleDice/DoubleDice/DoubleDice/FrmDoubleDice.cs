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

namespace DoubleDice
{
    public partial class FrmDoubleDice : Form
    {
        public FrmDoubleDice()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\double.txt";

            StreamReader read = new StreamReader(f);

            int antonia = 100;
            int david = 100;

            int a;
            int d;

            //read in number of rounds played
            int n = int.Parse(read.ReadLine());
            
            for (int round = 1; round <= n; round++)
            {

                string WholeLine;

                //reads in the entire line both rolls
                WholeLine = read.ReadLine();

                //this pulls apart each roll based on the blank separator
                lines = WholeLine.Split(' ');

                //a is Antonia's roll and d is David's roll
                a = int.Parse(lines[0]);
                d = int.Parse(lines[1]);

                //If Antonia's roll is less than Davids
                //David wins and Antonia loses the value of David's roll

                //If David's roll is less than Antonia's
                //Antonia wins and David loses the value of Antonia's roll

                if (a<d)
                {
                    antonia = antonia - d;
                }
                else if (d<a)
                {
                    david = david - a;
                }
              
                
            }

            TxtDisplay.Text += "Antonia " + antonia.ToString() +  Environment.NewLine;
            TxtDisplay.Text += "David " + david.ToString();
        }
    }
}
