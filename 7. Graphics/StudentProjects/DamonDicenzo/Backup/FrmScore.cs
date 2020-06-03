using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D; //Added for double buffering

namespace GuitarHeroClone
{
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }

        //****************************************************//
        //               VARIABLE DICTIONARY                  //
        //                                                    //
        // background - form background image                 //
        // names[100] - array for names from textfiles        //
        // scores[100] - array for scores from textfiles      //
        // score - holds score                                //
        // mode - holds difficulty level string               //
        // f - app path                                       //
        // counter - loop counter                             //
        // g - variable for graphics                          //
        // r - streamreader                                   //
        // line1 - temp holder for names from textfiles       //
        // line2 - temp holder for scores from textfiles      //
        // finished - true/false to determine end of textfile //
        // d - array for names                                //
        // t - array for scores                               //
        // c - counter                                        //
        //                                                    //
        //****************************************************//

        // loads in background image
        Image background = Image.FromFile(Application.StartupPath + @"\score.jpg");

        // names and scores arrays
        string[] names = new string[100];
        int[] scores = new int[100];

        // declares int to hold the score
        // and strings to hold difficulty level & app. path
        int score;
        string mode = "";
        string f = "";

        int counter = 0; // sets counter

        private void Draw(Graphics g)
        {
            g.DrawImage(background, 0, 0, 807, 576); // draws background
        }

        private void FrmScore_Paint(object sender, PaintEventArgs e)
        {
            // draws graphics from method
            Graphics g = e.Graphics;

            Draw(g);
        }

        public string ShowScore
        {
            // gets score from game form
            // sets into score variable
            get { return score.ToString(); }
            set { score = int.Parse(value); }
        }

        public string Mode
        {
            // gets mode from game form
            // sets into mode variable
            get { return mode; }
            set { mode = value; }
        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            // hides all stars
            PicStar1.Visible = false;
            PicStar2.Visible = false;
            PicStar3.Visible = false;
            PicStar4.Visible = false;
            PicStar5.Visible = false;

            // hides success label
            LblSuccess.Visible = false;

            counter = 0; // resets counter

            LblShowScore.Text = score.ToString(); // displays score

            // determines amount of stars to show based on score
            if (score < 0)
            {
                PicStar1.Visible = false;
                PicStar2.Visible = false;
                PicStar3.Visible = false;
                PicStar4.Visible = false;
                PicStar5.Visible = false;
            }
            else if (score > 0 && score < 2000)
            {
                PicStar1.Visible = true;
                PicStar2.Visible = false;
                PicStar3.Visible = false;
                PicStar4.Visible = false;
                PicStar5.Visible = false;
            }
            else if (score > 2000 && score < 5000)
            {
                PicStar1.Visible = true;
                PicStar2.Visible = true;
                PicStar3.Visible = false;
                PicStar4.Visible = false;
                PicStar5.Visible = false;
            }
            else if (score > 5000 && score < 9000)
            {
                PicStar1.Visible = true;
                PicStar2.Visible = true;
                PicStar3.Visible = true;
                PicStar4.Visible = false;
                PicStar5.Visible = false;
            }
            else if (score > 9000 && score < 13000)
            {
                PicStar1.Visible = true;
                PicStar2.Visible = true;
                PicStar3.Visible = true;
                PicStar4.Visible = true;
                PicStar5.Visible = false;
            }
            else if (score > 13000)
            {
                PicStar1.Visible = true;
                PicStar2.Visible = true;
                PicStar3.Visible = true;
                PicStar4.Visible = true;
                PicStar5.Visible = true;
            }
        }

        private void PicReplay_Click(object sender, EventArgs e)
        {
            // hides this form and shows main form
            this.Hide();

            Form f = new FrmMain();
            f.Show();
        }

        private void PicSubmit_Click(object sender, EventArgs e)
        {
            // calls datafile-related methods
            DataFile(names, scores, ref counter);
            DataWrite(names, scores, ref counter);

            // hides textbox and submit button
            // shows success label
            // repositions replay picture button
            TxtName.Visible = false;
            PicSubmit.Visible = false;
            PicReplay.Location = new System.Drawing.Point(362, 315);
            LblSuccess.Visible = true;
        }

        private void DataWrite(string[] d, int[] t, ref int c)
        {
            // writes to appropriate datafile

            string StartUpPath = Application.StartupPath;

            if (mode == "easy")
            {
                f = StartUpPath + @"\scores\easyscores.txt";
            }
            else if (mode == "medium")
            {
                f = StartUpPath + @"\scores\mediumscores.txt";
            }
            else if (mode == "hard")
            {
                f = StartUpPath + @"\scores\hardscores.txt";
            }
            else if (mode == "expert")
            {
                f = StartUpPath + @"\scores\expertscores.txt";
            }

            StreamWriter r = new StreamWriter(f);

            for (int i = 1; i <= c; i++)
            {
                r.WriteLine(names[i]);
                r.WriteLine(scores[i].ToString());
            }

            r.Close();
        }

        private void DataFile(string[] d, int[] t, ref int c)
        {
            // reads from appropriate datafile

            string StartUpPath = Application.StartupPath;

            if (mode == "easy")
            {
                f = StartUpPath + @"\scores\easyscores.txt";
            }
            else if (mode == "medium")
            {
                f = StartUpPath + @"\scores\mediumscores.txt";
            }
            else if (mode == "hard")
            {
                f = StartUpPath + @"\scores\hardscores.txt";
            }
            else if (mode == "expert")
            {
                f = StartUpPath + @"\scores\expertscores.txt";
            }

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

            c++;
            d[c] = TxtName.Text;
            t[c] = score;

            r.Close();

        }
    }
}