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

namespace _24HourClock
{
    public partial class FrmClock : Form
    {
        public FrmClock()
        {
            InitializeComponent();
        }

        private void BtnClock_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\clock.txt";

            StreamReader r = new StreamReader(f);

            string current;
            bool finished = false;

            while (!finished)
            {
                current = r.ReadLine();

                if (current == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += current + "\t" + Convert(current) + Environment.NewLine;

                }
            }
        }

        private string Convert(string c)
        {
            string hours, minutes;
            string converted = "";

            hours = c.Substring(0, 2);
            minutes = c.Substring(3);

            int nhours = int.Parse(hours);

            //We need to consider 3 cases
            if (nhours<12)
            {
                converted = hours + ":" + minutes + " " + "AM";
            }
            else if (nhours==12)
            {
                converted = hours + ":" + minutes + " " + "PM";
            }
            else if (nhours > 12)
            {
                converted = (nhours - 12).ToString() + ":" + minutes + " " + "PM";
            }

            return converted;
        }
    }
}
