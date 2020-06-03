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
            TxtDisplay.Text = "Quiz Score Analysis" + Environment.NewLine +Environment.NewLine;

            TxtDisplay.Text += "Original Data" + Environment.NewLine;
            
            //read in all the data 2d,1d
            DataFile(quiz, student, quizname,weights ,3, 4);
            Display(quiz, student, quizname, 3, 4);
            
            //Change a particular mark
            TxtDisplay.Text += "John's mark for quiz 3 changed to 97" + Environment.NewLine; 
            ChangeJohnQuiz3To97(quiz,2,3,97);
            Display(quiz, student, quizname, 3, 4);            

            //change all marks
            TxtDisplay.Text += "All marks reduced by 3" + Environment.NewLine;
            Subtract3FromAllMarks(quiz,3,4,3);
            Display(quiz, student, quizname, 3, 4);
            
            //check for a range of marks
            Over80(quiz,student,quizname,3,4);

            //find the largest overall mark on any given quiz
            HighestMark(quiz, student, quizname, 3, 4);
            
            //Total of marks for each student
            NameTotals(quiz, student,ntotal, 3, 4);
            HighestNameTotal(student,ntotal,3);
            
            //Total of quiz marks for each quiz
            QuizTotals(quiz, quizname,qtotal, 3, 4);
            AverageQuizMarks(quizname,qtotal,4);

            //highest mark per quiz , this is the hardest calculation
            HighestMarkPerQuiz(quiz, student, quizname, lowquiz, lowquizpos, 3, 4);
            
            //Final weighted average (each quiz is worth a different percentage overall)
            FinalMarks(quiz, student, weights, 3, 4);

        }
        private void DataFile(int[,] q,string [] s,string [] qn,double [] w, int rows, int cols)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\quiz.txt";

            StreamReader read = new StreamReader(f);

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    q[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            for (int r = 1; r <= rows; r++)
            {
                s[r] = read.ReadLine();
            }

            for (int c = 1; c <= cols; c++)
            {
                qn[c] = read.ReadLine();
            }

            for (int c = 1; c <= cols; c++)
            {
                w[c] = Convert.ToDouble(read.ReadLine());
            }
            
            read.Close();
        }

        private void Display(int[,] q, string[] s, string[] qn, int rows, int cols)
        {
            
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text+="\t";

            for (int c = 1; c <= cols; c++)
            {
                TxtDisplay.Text += qn[c] + "\t";
            }

            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= rows; r++)
            {
                TxtDisplay.Text += s[r] + "\t";
                for (int c = 1; c <= cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(q[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void ChangeJohnQuiz3To97(int [,] q,int row,int col,int newmark)
        {
            //Basically what we our doing is q[2,3]=97;
            //where 2 is the row where John is and 3 is the column where quiz 3 is

            q[row,col]=newmark;

        }

        private void Subtract3FromAllMarks(int[,] q, int rows, int cols, int markdown)
        {

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    q[r,c] -= markdown;
                }
            }
        }
        
        private void Over80(int[,] q, string[] s, string[] qn, int rows, int cols)
        {
            TxtDisplay.Text += "Results over 80% " + Environment.NewLine;
            
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    if (q[r,c] >= 80)
                    {
                        TxtDisplay.Text+= s[r] + "\t" + qn[c] + "\t" + q[r,c].ToString() + Environment.NewLine;
                    }
                }
            }

            TxtDisplay.Text += Environment.NewLine;
                
        }

        private void HighestMark(int[,] q, string[] s, string[] qn, int rows, int cols)
        {
            int big = -1;
            int posn = 0;
            int posc = 0;

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    if (q[r, c] > big)
                    {
                        big = q[r, c];
                        posn = r;
                        posc = c;
                    }

                }
            }

            TxtDisplay.Text += "The highest mark was " + big.ToString() + " it was obtained by " + s[posn] + " on  " + qn[posc] + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;
        }



        private void NameTotals(int[,] q, string[] s, int [] ntot ,int rows, int cols)
        {
            
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    ntot[r] += q[r, c];
                }
            }

            TxtDisplay.Text += "Student Totals:  " + Environment.NewLine;

            for (int r = 1; r <= rows; r++)
            {
                TxtDisplay.Text += s[r] + "\t" + Convert.ToString(ntot[r]  )+ Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

        }

        private void HighestNameTotal(string[] s, int [] ntot,int rows)
        {
            int big = -1;
            int pos = 0;

            //Here we are using the array totals that were calculated in the previous 
            //method above

            for (int r = 1; r <= rows;r++ )
            {
                if (ntot[r] > big)
                {
                    big = ntot[r];
                    pos = r;
                }

            }

            TxtDisplay.Text += "The highest mark total is " + big.ToString() + " obtained by " + s[pos] + Environment.NewLine;
            TxtDisplay.Text+=Environment.NewLine;
        }

        private void QuizTotals(int[,] q, string[] qn, int[] qtotal,int rows, int cols)
        {
            
            for (int c = 1; c <= cols; c++)
            {
                for (int r = 1; r <= rows; r++)
                {
                    qtotal[c] += q[r, c];
                }
            }

            TxtDisplay.Text += "Quiz Totals:  " + Environment.NewLine;

            for (int c = 1; c <= cols; c++)
            {
                TxtDisplay.Text += qn[c] + "\t" + Convert.ToString(qtotal[c]) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

        }

        private void AverageQuizMarks(string[] qn, int [] qt, int cols)
        {
            //Here we are going to use the column totals (quiz totals) that
            //were calculated in the previous method above
            
            double [] qaverage = new double[5];

            for (int c = 1; c <= cols; c++)
            {
                qaverage[c] = qt[c] / 3.0;
            }

            TxtDisplay.Text += "Overall Average marks for each Quiz" + Environment.NewLine;
            

            for (int c=1;c<=cols;c++)
            {
                TxtDisplay.Text+= qn[c] + " " + qaverage[c].ToString("n2") + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void HighestMarkPerQuiz(int[,] q, string[] s,string[] qn, int[] lq, int[] lqpos, int rows, int cols)
        {

            //Here we are working out the smallest not once but many times
            //so we are using an array of smalls lq [] AND 
            //an array of small positions lqpos[]
            
            for (int c = 1; c <= cols; c++)
            {
                lq[c] = 1000;

                for (int r = 1; r <= rows; r++)
                {
                    if (q[r, c] < lq[c])
                    {
                        lq[c] = q[r, c];
                        lqpos[c] = r;
                    }
                }
            }

            for (int c=1; c<=cols;c++)
            {
                TxtDisplay.Text += "For " + qn[c] + " the lowest mark was " + lq[c].ToString() + " it was obtained by " + s[lqpos[c]] + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;       
                        
        }

        private void FinalMarks(int[,] q, string[] s,double[] w, int rows, int cols)
        {
            double [] finalmark = new double[rows + 1];

            //note that the weight array is written as w[c]
            //we use c because the weights are BASED on the quizzes 
            //which are columns.
            
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    finalmark[r] += q[r, c]*w[c];
                }
            }

            TxtDisplay.Text += "Student Final Weighted Marks:  " + Environment.NewLine;

            for (int r = 1; r <= rows; r++)
            {
                TxtDisplay.Text += s[r] + "\t" + Convert.ToString(finalmark[r]) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}