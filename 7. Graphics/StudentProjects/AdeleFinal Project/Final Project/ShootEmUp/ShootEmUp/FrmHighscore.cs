using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Shooter
{
    public partial class FrmHighscore : Form
    {
        /*****************************Variable Dictionary*********************
         * scorename: a string to temporarily store a name until it is transferred into an array
         * scored: a string to temporarily store a score until it is transferred into an array
         * score: an int that stores the player's score from the last game
         * names: a string array for storing all the names that achieved highscores
         * scores: an int array for storing all of the highscores
         * startuppath & f: both strings to make loading in the txt file easier
         * finished: a bool that identifies whether the txt file has any entries left in it
         * flag: a string used in bubble sorting, it keeps a do while loop running until all values are sorted.
         * temp & tempString: an int and a string used in bubble sorting to temporarily store each variable as it is being switched around
         * low: an int that stores the lowest highscore. If the player's score is higher, then they get to add their name and score to the highscores txt file
         * spot: an int to remember the position in the array of the score that should be replaced
         * */
        public FrmHighscore()
        {
            InitializeComponent();            
        }

        string scorename;
        string scored;


        int score = GlobalClass.GlobalVar;

        
        int counter;
       
        string[] names=new string[1001];
        int[] scores = new int[1001];

        private void FrmHighscore_Load(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            for(int x=1;x<=1000;x++)
            {
                names[x] = "";
                scores[x] = 0;
                // this sets all spots in the arrays to start at zero or null, ready to be filled
            }
            
            counter = 0;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\NewScore.txt";

            StreamReader r = new StreamReader(f);

            bool finished = false;

            while (!finished)
            {
                ReadData(r);

                if (scorename == "" || scored == "" ||scorename==null||scored==null)
                {
                    finished = true;
                }
                else
                {
                    Math();
                }

            }

            r.Close();
            AddName(scores, counter, names);
            BubbleSort(scores, counter,names);
            Display(names, scores,counter);
            

        }
        private void Math()
        {
            counter++;
            
            names[counter] = scorename;
            scores[counter] = int.Parse(scored);

        }

        private void ReadData(StreamReader r)
        {
            scorename = r.ReadLine();
            scored = r.ReadLine();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BubbleSort(int[] n, int u,string[] s)
        {
            string flag;
            int temp;
            string tempString;
            do
            {
                flag = "yes";
                for (int k = 1; k <= u - 1; k++)
                {
                    if (n[k] < n[k + 1])
                    {
                        temp = n[k];
                        tempString=s[k];
                        n[k] = n[k + 1];
                        s[k]= s[k+1];
                        n[k + 1] = temp;
                        s[k+1]=tempString;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");
        }

        private void Display(string[] t, int[] h,int c)
        {
            txtDisplay.Text = "Name" + "\t" + "Score" + Environment.NewLine;
            for (int a = 1; a <= c; a++)
            {
                txtDisplay.Text += t[a] + "\t" + h[a].ToString() + Environment.NewLine;
            }

        }

        private void AddName(int[] n, int u,string[] s)
        {
            int low = 10000000;//used to determine the lowest high score, to see if the player's score is higher than it.
            //if so, the score will be added to the list of high scores, replacing the lowest score.
            int spot = 0;//this saves the spot of the lowest score, so that it will know which one to be replaced
            for (int a = 1; a <= u; a++)
            {
                if (n[a] < low)
                {
                    low = n[a];
                    spot = a;
                }
                
            }


            if (score >= low)
            {
                string studentname = Microsoft.VisualBasic.Interaction.InputBox("Please enter your name", "Hi Score", "", 200, 200);
                if (studentname != "")
                {
                    n[spot] = score;
                    s[spot] = studentname;
                    string StartUpPath = Application.StartupPath;
                    string f = StartUpPath + @"\NewScore.txt";

                    StreamWriter w = new StreamWriter(f, true);

                    w.WriteLine(s[spot]);
                    w.WriteLine(n[spot].ToString());
                    w.Close();
                }
            }
            else 
            {
                MessageBox.Show("Sorry, you did not get a high score. Better luck next time!");
            }       
            
                       
            
        }

        
        
    }
}
