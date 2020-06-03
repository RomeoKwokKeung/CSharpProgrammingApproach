using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AddTimes
{
    public partial class FrmAddTimes : Form
    {
        public FrmAddTimes()
        {
            InitializeComponent();
        }

        private void BtnAddTimes_Click(object sender, EventArgs e)
        {

            int firstDays;
            int firstHours;
            int firstMinutes;
            int secondDays;
            int secondHours;
            int secondMinutes;
            
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\times.txt";

            StreamReader r = new StreamReader(f);

            //read in number of add times to be processed
            int numTimes = int.Parse(r.ReadLine());

            for (int i = 1; i <= numTimes; i++)
            {

                firstDays = int.Parse(r.ReadLine());
                firstHours = int.Parse(r.ReadLine());
                firstMinutes = int.Parse(r.ReadLine());
                secondDays = int.Parse(r.ReadLine());
                secondHours = int.Parse(r.ReadLine());
                secondMinutes = int.Parse(r.ReadLine());

                TxtDisplay.Text += firstDays.ToString() + " days " + firstHours.ToString() + " hours " + firstMinutes.ToString() + " minutes  + " +  secondDays.ToString() + " days " + secondHours.ToString() + " hours " + secondMinutes.ToString() + " minutes " + Environment.NewLine;
                TxtDisplay.Text += "equals" + Environment.NewLine;
                TxtDisplay.Text += AddTimes(firstDays, firstHours, firstMinutes, secondDays, secondHours, secondMinutes) + Environment.NewLine;
            }


        }

        private string AddTimes(int fd, int fh, int fm, int sd, int sh, int sm)
        {
            string answer = "";
            
            const int MinutesInHour = 60;
            const int HoursInDay = 24;

            int totalcarryoverM = 0;
            int DisplayMinutes = 0;

            int totalcarryoverH = 0;
            int DisplayHours = 0;
                       
            int DisplayDays = 0;

            
            DisplayMinutes = (fm + sm) % MinutesInHour;
            totalcarryoverM = fm + sm;
            
            DisplayHours = (fh + sh + (totalcarryoverM) / MinutesInHour) % HoursInDay;
            totalcarryoverH = fh + sh + (totalcarryoverM) / MinutesInHour; 

            DisplayDays = (fd + sd) + (totalcarryoverH) / HoursInDay;

            answer += DisplayDays.ToString() + " days " + DisplayHours.ToString() + " hours " + DisplayMinutes.ToString() + " minutes" + Environment.NewLine;

            return answer;
        }
    }
}
