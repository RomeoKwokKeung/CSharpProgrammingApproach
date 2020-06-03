using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CanDoBetter
{
    public partial class FrmDoBetter : Form
    {
        public FrmDoBetter()
        {
            InitializeComponent();
        }

        private void BtnDoBetter_Click(object sender, EventArgs e)
        {
            string word;
           
            bool finished = false;

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\better.txt";

            StreamReader r = new StreamReader(f);

            int count = int.Parse(r.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                word = r.ReadLine();
                
                TxtDisplay.Text += Better(word) + Environment.NewLine;
            }


            r.Close(); 
        }

        private string Better(string w)
        {
            string b = "";
            int wlength = w.Length;

            if (wlength >= 2)
            {
                if ((w.Substring(wlength - 2, 1) == "e") && (w.Substring(wlength - 1, 1) == "r"))
                {
                    b = w.Substring(0, wlength - 1) + "st";
                }
                else if (w.Substring(wlength-1,1)=="e")
                {
                    b = w + "r";
                }
                else
                {
                    b=w + "er";
                }
            }
            else
            {
                b = w + "er";
            }

            return b;
        }
    }
}
