using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
    public partial class FrmArrayIntro : Form
    {
        public FrmArrayIntro()
        {
            InitializeComponent();
        }        

        private void BtnAssignment_Click(object sender, EventArgs e)
        {
            string[] StudentName = new string[6];
            int[] StudentMark = new int[6];
            
            StudentName[1] = "Mary";
            StudentMark[1] = 80;
            StudentName[2] = "Jim";
            StudentMark[2] = 87;
            StudentName[3] = "Frank";
            StudentMark[3] = 68;
            StudentName[4] = "Karen";
            StudentMark[4] = 77;
            StudentName[5] = "Peter";
            StudentMark[5] = 45;

            LstInfo.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                LstInfo.Items.Add(StudentName[i] + "\t" + StudentMark[i].ToString());
            }          
                        
        }

        private void Display(string[] n, int[] m, int u)
        {
            LstInfo.Items.Clear();
            for (int i = 1; i <= u; i++)
            {
                LstInfo.Items.Add(n[i] + "\t" + m[i].ToString());
            }
        }

        private void BtnInstance_Click(object sender, EventArgs e)
        {
            string[] StudentName = { "", "Mary", "Jim", "Frank", "Karen", "Peter" };
            int[] StudentMark = { 0, 80, 87, 68, 77, 45 };

            LstInfo.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                LstInfo.Items.Add(StudentName[i] + "\t" + StudentMark[i].ToString());
            }   
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            string[] StudentName = new string[100];
            int[] StudentMark = new int[100];

            string response = "";
            int counter = 0;
            
            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have any entries y/n", "Arrays", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response=="n")
                    break;

                string tempS=Microsoft.VisualBasic.Interaction.InputBox("Enter your name","Arrays","",200,200);
                int tempM=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your mark","Arrays","",200,200));

                if (tempM >= 0 && tempM <= 100)
                {
                    counter++;

                    StudentName[counter] = tempS;
                    StudentMark[counter] = tempM;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);
                }               

            }

            LstInfo.Items.Clear();
            for (int i = 1; i <= counter; i++)
            {
                LstInfo.Items.Add(StudentName[i] + "\t" + StudentMark[i].ToString());
            }   
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            string[] StudentName = new string[100];
            int[] StudentMark = new int[100];
            int counter = 0;
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\students.txt";

            StreamReader r = new StreamReader(f);

            string line1,line2;
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();
                line2 = r.ReadLine();

                if (line1 == null || line2==null)
                {
                    finished = true;
                }
                else
                {
                    counter++;
                    StudentName[counter] = line1;
                    StudentMark[counter] = Convert.ToInt32(line2);
                }

            }

            r.Close();

            LstInfo.Items.Clear();
            for (int i = 1; i <= counter; i++)
            {
                LstInfo.Items.Add(StudentName[i] + "\t" + StudentMark[i].ToString());
            }   
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            string[] StudentName = new string[100];
            int[] StudentMark = new int[100];

            string response = "";
            int counter = 0;

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

                    StudentName[counter] = tempS;
                    StudentMark[counter] = tempM;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);
                }
            }

            //NOTE the use of methods with array parameters

            //Display is a void method which accepts two arrays and the counter 
            //to display the arrays in a text box
            
            //Average is a method that returns a value eg. the average mark. It accepts
            //one array and the counter
            
            Display(StudentName, StudentMark, counter);
            LstInfo.Items.Add("The Average Mark is " + Average(StudentMark,counter).ToString("n2"));
        }

        private double Average(int[] m, int u)
        {
            double total = 0;
            double avg = 0;

            for (int i = 1; i <= u; i++)
            {
                total += m[i];
            }

            avg = total / u;

            return avg;
        }
    }
}