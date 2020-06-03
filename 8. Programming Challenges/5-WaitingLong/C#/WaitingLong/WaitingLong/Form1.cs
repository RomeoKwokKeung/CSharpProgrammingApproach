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

namespace WaitingLong
{
    public partial class FrmWaitingLong : Form
    {
        public FrmWaitingLong()
        {
            InitializeComponent();
        }

        int wait = 0;

        int hr1 = 0;
        int displayhr1 = 0;
        int min1 = 0;

        int hr2 = 0;
        int displayhr2 = 0;
        int min2 = 0;

        private void BtnWait_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\wait.txt";

            StreamReader r = new StreamReader(f);

            string time1;
            string time2;            

            bool finished = false;

            while (!finished)
            {
                time1 = r.ReadLine();

                if (int.Parse(time1) == 0)
                {
                    finished = true;
                }
                else
                {
                    time2 = r.ReadLine();

                    WaitTime(time1, time2);

                    TxtDisplay.Text += "From " + displayhr1.ToString() + ":" + min1.ToString() + " to " +  displayhr2.ToString() + ":" + min2.ToString() + " is " + wait.ToString() + " minutes"; 

                    TxtDisplay.Text += Environment.NewLine;
                }
            }
            r.Close();
        }

        private void WaitTime(string f,string s)
        {
            int t1 = int.Parse(f);
            int t2 = int.Parse(s);

            hr1 = t1 / 100;
            min1 = t1 % 100;
            displayhr1 = hr1;
            

            hr2 = t2 / 100;
            min2 = t2 % 100;
            displayhr2 = hr2;
            
            if (t2<t1)
            {
                hr2 = hr2 + 24;
            }

            t1 = hr1 * 60 + min1;
            t2 = hr2 * 60 + min2;

            wait = t2 - t1;

        }
    }
}
