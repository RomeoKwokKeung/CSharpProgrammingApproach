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

namespace Parking
{
    public partial class FrmParking : Form
    {
        public FrmParking()
        {
            InitializeComponent();
        }

        private void BtnParking_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\parking.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            int lot = 0;

            string today;
            string yesterday;

            while(!finished)
            {


                int occupiedtwodays = 0;

                yesterday = r.ReadLine();

                if(yesterday==null)
                {
                    finished = true;
                }
                else
                {
                    today = r.ReadLine();

                    lot++;

                    occupiedtwodays = DetectParking(yesterday, today);
                    TxtDisplay.Text += "For Lot # " + lot.ToString() + "  " + occupiedtwodays + " spot(s) were(was) occupied yesterday and today" + Environment.NewLine;
                }              


            }
                        
        }

        private int DetectParking(string y,string t)
        {
            int count = 0;

            for (int i=0;i<y.Length;i++)
            {
                if (y.Substring(i,1)=="C" && t.Substring(i,1)=="C")
                {
                    count++;
                }
            }

            return count;

        }
    }
}
