using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; //needed for datafile

namespace Animation1
{
    public partial class FrmHighScores : Form
    {
        public FrmHighScores()
        {
            InitializeComponent();
        }

        string[] PlayerNames = new string[100]; //array of names
        int[] PlayerScores = new int[100]; // array of scores
        int counter = 0; //counter for datafile 

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            DataFile(PlayerNames, PlayerScores, ref counter); // calls datafile
            BubbleSort(PlayerNames, PlayerScores, counter); //calls bubblesort
            Display(PlayerNames, PlayerScores, counter); // display

        }

        private void DataFile(string[] d, int[] t, ref int c)
        {

            string StartUpPath = Application.StartupPath; // load in textfile
            string f = StartUpPath + @"\highscores.txt";

            StreamReader r = new StreamReader(f);

            string line1, line2; //used to read datafile
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();
                line2 = r.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true; // read until lines are null
                }
                else
                {
                    c++;
                    d[c] = line1;
                    t[c] = Convert.ToInt32(line2);
                }

            }


            r.Close(); // close datafile

        }


        private void DataWrite(string[] d, int[] t, ref int c)
        {

            string StartUpPath = Application.StartupPath; // open datafile
            string f = StartUpPath + @"\highscores.txt";

            StreamWriter r = new StreamWriter(f);


                r.WriteLine(PlayerNames[1]); //write name to datafile
                r.WriteLine(PlayerScores[1].ToString()); //write score to datafile

            r.Close(); //close datafile

        }

        private void Display(string[] n, int[] m, int u)
        {
            LstDisplay.Items.Clear(); //clear display
            LstDisplay.Items.Add("Player Name" + "\t\t" + "Score");
            for (int i = 1; i <= 5; i++)
            {
                LstDisplay.Items.Add(n[i] + "\t\t\t" + m[i].ToString()); //display 10 highest scores
            }
        }

        private void BubbleSort(string[] m, int[] n, int u)
        {
            //use bubblesort to sort

            string flag;
            int temp;
            string temp2;
            do
            {
                flag = "yes";
                for (int k = 1; k <= u - 1; k++)
                {
                    if (n[k] < n[k + 1])
                    {
                        temp = n[k];
                        n[k] = n[k + 1];
                        n[k + 1] = temp;
                        temp2 = m[k];
                        m[k] = m[k + 1];
                        m[k + 1] = temp2;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");
        }
    }
}