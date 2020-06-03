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

namespace TimeClock
{
    public partial class FrmTimeClock : Form
    {
        public FrmTimeClock()
        {
            InitializeComponent();
        }

        private void BtnTimeClock_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\clock.txt";

            StreamReader r = new StreamReader(f);

            string time1;
            string time2;
            string totaltime;

            bool finished = false;

            while (!finished)
            {
                time1 = r.ReadLine();

                if (time1 == null)
                {
                    finished = true;
                }
                else
                {
                    time2 = r.ReadLine();
                    //TxtDisplay.Text += time1 + Environment.NewLine;
                    //TxtDisplay.Text += time2 + Environment.NewLine;

                    totaltime = WorkTime(time1, time2);

                    TxtDisplay.Text += totaltime + Environment.NewLine;
                }
            }
        }

        private string WorkTime(string t1,string t2)
        {

            string WTime = "";

            //convert the start and end times to minutes
            int start = int.Parse(t1.Substring(0, 2)) * 60 + int.Parse(t1.Substring(3, 2));
            int end = int.Parse(t2.Substring(0, 2)) * 60 + int.Parse(t2.Substring(3, 2));

            if (end < start) // for instance 09:00 to 02:00 ... nine in the morning to 2 in the afternoon
            {
                end = end + 12 * 60;
            }

            int ElapsedMinutes = end - start;
            
            if (ElapsedMinutes >480)
            {
                ElapsedMinutes = 480;
            }

            int hrs = ElapsedMinutes / 60;

            if (hrs <10)
            {
                WTime = "0";
            }
            WTime += hrs.ToString();
            WTime += ":";

            int minutes = ElapsedMinutes % 60;
            
            if (minutes <10)
            {
                WTime += "0";
            }
            WTime += minutes.ToString();

            return WTime;

        }
    }
}
