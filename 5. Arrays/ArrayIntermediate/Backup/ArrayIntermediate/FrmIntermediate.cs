using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArrayIntermediate
{
    public partial class FrmIntermediate : Form
    {
        public FrmIntermediate()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            string[] StudentNames = new string[100];
            int[] StudentMarks = new int[100];
            int counter = 0;

            //By default arrays are passed by Reference
            //That is, there original values can be changed
            //in a method
            //Regular variables are passed by Value
            //That is, when they return from a method they
            //return to their original value
            //To have regular variables keep its modified value
            //you must explicitly pass it by --- ref

            //Here we pass down two array and the counter
            //There are all initially empty.
            //When they return from the method they will all
            //have new values
            
            DataEntry(StudentNames, StudentMarks, ref counter);

            //Now that we have all the data we get call methods
            //to redisplay the data in any order and determine the 
            //highest mark

            Display(StudentNames, StudentMarks, counter);
            DisplayReverse(StudentNames, StudentMarks, counter);
            LstInfo.Items.Add(HighestMark(StudentNames, StudentMarks, counter));
        }

        private void DataEntry(string[] sn, int[] sm, ref int c)
        {
            string response = "";
            
            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have any entries y/n", "Arrays", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;

                string tempS = Microsoft.VisualBasic.Interaction.InputBox("Enter your name", "Arrays", "", 200, 200);
                int tempM = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your mark", "Arrays", "", 200, 200));

                if (tempM >= 0 && tempM <= 100)
                {
                    c++;

                    sn[c] = tempS;
                    sm[c] = tempM;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void Display(string[] n, int[] m, int u)
        {
            LstInfo.Items.Clear();
            LstInfo.Items.Add("Original List");
            for (int i = 1; i <= u; i++)
            {
                LstInfo.Items.Add(n[i] + "\t" + m[i].ToString());
            }
        }

        private void DisplayReverse(string[] n, int[] m, int u)
        {
            LstInfo.Items.Add("List in Reverse Order");
            for (int i = u; i >=1; i--)
            {
                LstInfo.Items.Add(n[i] + "\t" + m[i].ToString());
            }
        }

        private string HighestMark(string[] n, int[] m, int u)
        {
            int big = -1;
            int pos=0;
            string result = "";

            for (int i = 1; i <= u; i++)
            {
                if (m[i] > big)
                {
                    big = m[i];
                    pos = i;
                }
            }

            result = "highest mark " + big.ToString() + " obtained by " + n[pos];
            return result;
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            string[] Day = new string[8];
            int[] Temp = new int[8];
            int counter = 0;

            DataFile(Day, Temp, ref counter);
            Display(Day, Temp, counter);
            LstInfo.Items.Add("The averge temperature is " + Average(Temp,counter).ToString("n2"));
            LstInfo.Items.Add(LowestTemp(Day, Temp, counter));
        }

        private void DataFile(string[] d, int[] t, ref int c)
        {

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\temperatures.txt";

            StreamReader r = new StreamReader(f);

            string line1, line2;
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();
                line2 = r.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    c++;
                    d[c] = line1;
                    t[c] = Convert.ToInt32(line2);
                }

            }

            r.Close();

        }

        private double Average(int[] m, int u)
        {
            double total = 0;

            for (int i = 1; i <= u; i++)
            {
                total += m[i];
            }
            return total / u;
        }

        private string LowestTemp(string[] d, int[] t, int u)
        {
            int small = 1000;
            int pos = 0;
            string result = "";

            for (int i = 1; i <= u; i++)
            {
                if (t[i] < small)
                {
                    small = t[i];
                    pos = i;
                }
            }

            result = "Lowest temp was " + small.ToString() + " on " + d[pos];
            return result;
        }

    }
}