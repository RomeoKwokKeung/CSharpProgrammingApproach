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

namespace ShowMeTheMoney
{
    public partial class FrmMoney : Form
    {
        public FrmMoney()
        {
            InitializeComponent();
        }

        string [] lines = new string [5];
        int counter=0;
        bool live;

        private void BtnMoney_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\money.txt";

            StreamReader r = new StreamReader(f);           

            for (int i=0;i<5;i++)
            {
                live = true;

                lines[i] = r.ReadLine();

                for (int j=0;j<lines[i].Length;j++)
                {
                    if (lines[i].Substring(j,1) == "+")
                    {
                        counter++;
                    }
                    else if (lines[i].Substring(j,1)=="-")
                    {
                        counter--;
                    }
                    //reset counter if running total drops below 0
                    if (counter<0)
                    {
                        counter = 0;
                        live = false;
                        break;
                    }
                }

                if (live)
                {
                    TxtDisplay.Text += " " + counter.ToString(); 
                }
                else
                {
                    TxtDisplay.Text+= "OH NOES!";
                }

                TxtDisplay.Text += Environment.NewLine;               
               
            }
        }
    }
}
