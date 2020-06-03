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

        //declare all arrays and counter variables
        string[] StudentNames = new string[100];
        int[] StudentMarks = new int[100];

        //counter will be used to determine the number of entries made
        //then all loops (for) will go from 1 to counter
        int counter = 0;        

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            
            DataEntry();

            //Now that we have all the data we call methods
            //to redisplay the data in any order and determine the 
            //highest mark

            Display();
            DisplayReverse();

            //HighestMark is a method that returns a 
            //string answer (a concatentation of words and a numeric value)
            LstInfo.Items.Add(HighestMark());
        }

        private void DataEntry()
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
                    counter++;

                    StudentNames[counter] = tempS;
                    StudentMarks[counter] = tempM;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void Display()
        {
            LstInfo.Items.Clear();
            LstInfo.Items.Add("Original List");
            for (int i = 1; i <= counter; i++)
            {
                LstInfo.Items.Add(StudentNames[i] + "\t" + StudentMarks[i].ToString());
            }
        }

        private void DisplayTemperatures()
        {
            LstInfo.Items.Clear();
            LstInfo.Items.Add("Original List");
            for (int i = 1; i <= tempcounter; i++)
            {
                LstInfo.Items.Add(Day[i] + "\t" + Temp[i].ToString());
            }
        }


        private void DisplayReverse()
        {
            LstInfo.Items.Add("List in Reverse Order");
            for (int i = counter; i >=1; i--)
            {
                LstInfo.Items.Add(StudentNames[i] + "\t" + StudentMarks[i].ToString());
            }
        }

        private string HighestMark()
        {
            int big = -1;
            int pos=0;
            string result = "";

            for (int i = 1; i <= counter; i++)
            {
                if (StudentMarks[i] > big)
                {
                    big = StudentMarks[i];
                    pos = i;
                }
            }

            result = "highest mark " + big.ToString() + " obtained by " + StudentNames[pos];
            return result;
        }

        //declare all arrays and counter variables
        string[] Day = new string[8];
        int[] Temp = new int[8];

        //tempcounter will be used to determine the number of entries made
        //then all loops (for) will go from 1 to tempcounter
        int tempcounter = 0;

        private void BtnTemp_Click(object sender, EventArgs e)
        {            

            DataFile();
            DisplayTemperatures();
            LstInfo.Items.Add("The averge temperature is " + Average().ToString("n2"));

            //LowestTemp is a method that returns a 
            //string answer (a concatentation of words and a numeric value)
            LstInfo.Items.Add(LowestTemp());
        }

        private void DataFile()
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
                    tempcounter++;
                    Day[tempcounter] = line1;
                    Temp[tempcounter] = Convert.ToInt32(line2);
                }

            }

            r.Close();

        }

        private double Average()
        {
            double total = 0;

            for (int i = 1; i <= tempcounter; i++)
            {
                total += Temp[i];
            }
            return total / tempcounter;
        }

        private string LowestTemp()
        {
            int small = 1000;
            int pos = 0;
            string result = "";

            for (int i = 1; i <= tempcounter; i++)
            {
                if (Temp[i] < small)
                {
                    small = Temp[i];
                    pos = i;
                }
            }

            result = "Lowest temp was " + small.ToString() + " on " + Day[pos];
            return result;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}