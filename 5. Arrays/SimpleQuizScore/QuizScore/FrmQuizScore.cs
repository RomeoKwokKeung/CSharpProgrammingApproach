using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QuizScore
{
    public partial class FrmQuizScore : Form
    {
        public FrmQuizScore()
        {
            InitializeComponent();
        }

        private void BtnQuizAnalysis_Click(object sender, EventArgs e)
        {
            
            //the core set of 2d and 1d arrays needed 
            int[,] quiz = new int[4, 5];
            string[] student = new string[4];
            string[] quizname = new string[5];
            double[] weights = new double[5];

            //needed for row (names) and column (quiz) totals
            int[] ntotal = new int[4];
            int[] qtotal = new int[5];
            
            //needed for lowest mark for each quiz , calculations
            int [] lowquiz = new int [5];
            int [] lowquizpos = new int [5];

            TxtDisplay.Clear();
            //title
            TxtDisplay.Text = "Quiz Score Analysis" + Environment.NewLine +Environment.NewLine;

            TxtDisplay.Text += "Original Data" + Environment.NewLine;
            
            //read in all the data 2d,1d
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\quiz.txt";

            StreamReader read = new StreamReader(f);

            //read the information from the txt file
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    quiz[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            //name of students
            for (int r = 1; r <= 3; r++)
            {
                student[r] = read.ReadLine();
            }

            for (int c = 1; c <= 4; c++)
            {
                quizname[c] = read.ReadLine();
            }

            for (int c = 1; c <= 4; c++)
            {
                weights[c] = Convert.ToDouble(read.ReadLine());
            }

            read.Close();
            
            //Display the original table
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "\t";

            for (int c = 1; c <= 4; c++)
            {
                TxtDisplay.Text += quizname[c] + "\t";
            }

            //go down
            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                TxtDisplay.Text += student[r] + "\t";
                for (int c = 1; c <= 4; c++)
                {//print out the mark
                    TxtDisplay.Text += Convert.ToString(quiz[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
            
            //Change a particular mark
            quiz[2, 3] = 97;
                    

            //reduce all the marks by 3
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    quiz[r, c] -= 3;
                }
            }
           
            
            //check for a range of marks over 80
            TxtDisplay.Text += "Results over 80% " + Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    if (quiz[r, c] >= 80)
                    {
                        TxtDisplay.Text += student[r] + "\t" + quizname[c] + "\t" + quiz[r, c].ToString() + Environment.NewLine;
                    }
                }
            }

            TxtDisplay.Text += Environment.NewLine;

            //find the largest overall mark on any given quiz
            int big = -1;
            int posn = 0;
            int posc = 0;

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    if (quiz[r, c] > big)
                    {
                        big = quiz[r, c];
                        posn = r;
                        posc = c;
                    }

                }
            }

            TxtDisplay.Text += "The highest mark was " + big.ToString() + " it was obtained by " + student[posn] + " on  " + quizname[posc] + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;
            
            //Total of marks for each student
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    ntotal[r] += quiz[r, c];
                }
            }

            TxtDisplay.Text += "Student Totals:  " + Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                TxtDisplay.Text += student[r] + "\t" + Convert.ToString(ntotal[r]) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
            
            //Highest Total Mark and Name of student
            int bigname = -1;
            int pos = 0;

            //Here we are using the array totals that were calculated in the previous 
            //method above

            for (int r = 1; r <= 3; r++)
            {
                if (ntotal[r] > big)
                {
                    bigname = ntotal[r];
                    pos = r;
                }
            }

            TxtDisplay.Text += "The highest mark total is " + bigname.ToString() + " obtained by " + student[pos] + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;
            
            //Total of quiz marks for each quiz
            for (int c = 1; c <= 4; c++)
            {
                for (int r = 1; r <= 3; r++)
                {
                    qtotal[c] += quiz[r, c];
                }
            }

            TxtDisplay.Text += "Quiz Totals:  " + Environment.NewLine;

            for (int c = 1; c <= 4; c++)
            {
                TxtDisplay.Text += quizname[c] + "\t" + Convert.ToString(qtotal[c]) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

            //Average Quiz Marks
            //Here we are going to use the column totals (quiz totals) that
            //were calculated in the previous method above

            double[] qaverage = new double[5];

            for (int c = 1; c <= 4; c++)
            {
                qaverage[c] = qtotal[c] / 3.0;
            }

            TxtDisplay.Text += "Overall Average marks for each Quiz" + Environment.NewLine;


            for (int c = 1; c <= 4; c++)
            {
                TxtDisplay.Text += quizname[c] + " " + qaverage[c].ToString("n2") + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

            //highest mark per quiz , this is the hardest calculation
            //Here we are working out the smallest not once but many times
            //so we are using an array of smalls lowquiz [] AND 
            //an array of small positions lowquizpos[]

            for (int c = 1; c <= 4; c++)
            {
                lowquiz[c] = 1000;

                for (int r = 1; r <= 3; r++)
                {
                    if (quiz[r, c] < lowquiz[c])
                    {
                        lowquiz[c] = quiz[r, c];
                        lowquizpos[c] = r;
                    }
                }
            }

            for (int c = 1; c <= 4; c++)
            {
                TxtDisplay.Text += "For " + quizname[c] + " the lowest mark was " + lowquiz[c].ToString() + " it was obtained by " + student[lowquizpos[c]] + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;    
            
            //Final weighted average (each quiz is worth a different percentage overall)
            double[] finalmark = new double[4];

            //note that the weight array is written as weight[c]
            //we use c because the weights are BASED on the quizzes 
            //which are columns.

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    finalmark[r] += quiz[r, c] * weights[c];
                }
            }

            TxtDisplay.Text += "Student Final Weighted Marks:  " + Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                TxtDisplay.Text += student[r] + "\t" + Convert.ToString(finalmark[r]) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

        }
        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}