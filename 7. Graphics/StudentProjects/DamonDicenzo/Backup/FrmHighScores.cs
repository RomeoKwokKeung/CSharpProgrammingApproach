using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //Added for double buffering
using System.IO;

namespace GuitarHeroClone
{
    public partial class FrmHighScores : Form
    {
        public FrmHighScores()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // enables doublebuffer
        }

        //*************************************************************//
        //                    VARIABLE DICTIONARY                      //
        //                                                             //
        // background - form background image                          //
        // expertnames - array for names in expert high scores list    //
        // expertscores - array for scores in expert high scores list  //
        // hardnames - array for names in hard high scores list        //
        // hardscores - array for scores in hard high scores list      //
        // mediumnames - array for names in medium high scores list    //
        // mediumscores - array for scores in medium high scores list  //
        // easynames - array for names in easy high scores list        //
        // easyscores - array for scores in easy high scores list      //
        // countex - counter for expert level                          //
        // countha - counter for hard level                            //
        // countme - counter for medium level                          //
        // countea - counter for easy level                           //
        // f - variable for FrmMain                                   //
        // exn - temp. array for names in expert scores list          //
        // exm - temp. array for scores in expert scores list         //
        // exc - temp. counter for expert scores list                 //
        // han - temp. array for names in hard scores list            //
        // ham - temp. array for scores in hard scores list           //
        // hac - temp. counter for hard scores list                   //
        // men - temp. array for names in medium scores list          //
        // mem - temp. array for scores in medium scores list         //
        // mec - temp. counter for medium scores list                 //
        // ean - temp. array for names in easy scores list            //
        // eam - temp. array for scores in easy scores list           //
        // eac - temp. counter for easy scores list                   //
        // flag - yes/no for whether theres a score to read           //
        // temp - temp holder for scores                              //
        // temp2 - temp holder for names                              //
        // ead - temp array for reading names from easy list          //
        // eat - temp array for reading scores from easy list         //
        // had - temp array for reading names from hard list          //
        // hat - temp array for reading scores from hard list         //
        // med - temp array for reading names from medium list        //
        // met - temp array for reading scores from medium list       //
        // exd - temp array for reading names from expert list        //
        // ext - temp array for reading scores from expert list       //
        // c - counter                                                //
        //                                                            //
        //************************************************************//


        // loads in background image
        Image background = Image.FromFile(Application.StartupPath + @"\highscores.jpg");

        // sets arrays for each difficulty level's names and scores
        string[] expertnames = new string[100];
        int[] expertscores = new int[100];

        string[] hardnames = new string[100];
        int[] hardscores = new int[100];

        string[] mediumnames = new string[100];
        int[] mediumscores = new int[100];

        string[] easynames = new string[100];
        int[] easyscores = new int[100];

        // sets each difficulty level's counters
        int countex = 0;
        int countha = 0;
        int countme = 0;
        int countea = 0;

        private void Draw(Graphics g)
        {
            // draws background on form
            g.DrawImage(background, 0, 0, 807, 576);
        }

        private void FrmHighScores_Paint(object sender, PaintEventArgs e)
        {
            // draws graphics from Draw method
            Graphics g = e.Graphics;

            Draw(g);
        }

        private void PicReturnFromAbout_Click(object sender, EventArgs e)
        {
            // hides this form shows FrmMain
            Form f = new FrmMain();

            this.Hide();
            f.Show();
        }

        private void Display(string[] exn, int[] exm, string[] han, int[] ham, string[] men, int[] mem, string[] ean, int[] eam)
        {

            // Displays each difficulty level's scores and names in appropriate listbox.

            LstExpert.Items.Clear();
            LstExpert.Items.Add("Player Name" + "\t" + "Score");
            for (int i = 1; i <= 10; i++)
            {
                LstExpert.Items.Add(exn[i] + "\t\t" + exm[i].ToString());
            }


            LstHard.Items.Clear();
            LstHard.Items.Add("Player Name" + "\t" + "Score");
            for (int i = 1; i <= 10; i++)
            {
                LstHard.Items.Add(han[i] + "\t\t" + ham[i].ToString());
            }


            LstMedium.Items.Clear();
            LstMedium.Items.Add("Player Name" + "\t" + "Score");
            for (int i = 1; i <= 10; i++)
            {
                LstMedium.Items.Add(men[i] + "\t\t" + mem[i].ToString());
            }


            LstEasy.Items.Clear();
            LstEasy.Items.Add("Player Name" + "\t" + "Score");
            for (int i = 1; i <= 10; i++)
            {
                LstEasy.Items.Add(ean[i] + "\t\t" + eam[i].ToString());
            }
        }

        private void BubbleSort(string[] exm, int[] exn, int exc, string[] ham, int[] han, int hac, string[] mem, int[] men, int mec, string[] eam, int[] ean, int eac)
        {

            // sorts each difficulty level's scores by highest to lowest.

            string flag;
            int temp;
            string temp2;
            do
            {
                flag = "yes";
                for (int k = 1; k <= exc - 1; k++)
                {
                    if (exn[k] < exn[k + 1])
                    {
                        temp = exn[k];
                        exn[k] = exn[k + 1];
                        exn[k + 1] = temp;
                        temp2 = exm[k];
                        exm[k] = exm[k + 1];
                        exm[k + 1] = temp2;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");

            temp = 0;
            temp2 = "";
            do
            {
                flag = "yes";
                for (int k = 1; k <= hac - 1; k++)
                {
                    if (han[k] < han[k + 1])
                    {
                        temp = han[k];
                        han[k] = han[k + 1];
                        han[k + 1] = temp;
                        temp2 = ham[k];
                        ham[k] = ham[k + 1];
                        ham[k + 1] = temp2;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");


            temp = 0;
            temp2 = "";
            do
            {
                flag = "yes";
                for (int k = 1; k <= mec - 1; k++)
                {
                    if (men[k] < men[k + 1])
                    {
                        temp = men[k];
                        men[k] = men[k + 1];
                        men[k + 1] = temp;
                        temp2 = mem[k];
                        mem[k] = mem[k + 1];
                        mem[k + 1] = temp2;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");


            temp = 0;
            temp2 = "";
            do
            {
                flag = "yes";
                for (int k = 1; k <= eac - 1; k++)
                {
                    if (ean[k] < ean[k + 1])
                    {
                        temp = ean[k];
                        ean[k] = ean[k + 1];
                        ean[k + 1] = temp;
                        temp2 = eam[k];
                        eam[k] = eam[k + 1];
                        eam[k + 1] = temp2;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");
        }

        private void DataFileEasy(string[] ead, int[] eat, ref int c)
        {

            // loads in difficulty level's scores and names
            // into appropriate arrays for sorting and displaying.

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\scores\easyscores.txt";

            StreamReader a = new StreamReader(f);

            string line1, line2;
            bool finished = false;

            while (!finished)
            {
                line1 = a.ReadLine();
                line2 = a.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    c++;
                    ead[c] = line1;
                    eat[c] = Convert.ToInt32(line2);
                }
            }

            a.Close();
        }

        private void DataFileMedium(string[] med, int[] met, ref int c)
        {

            // loads in difficulty level's scores and names
            // into appropriate arrays for sorting and displaying.

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\scores\mediumscores.txt";

            StreamReader b = new StreamReader(f);

            string line1 = "";
            string line2 = "";
            bool finished = false;

            while (!finished)
            {
                line1 = b.ReadLine();
                line2 = b.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    c++;
                    med[c] = line1;
                    met[c] = Convert.ToInt32(line2);
                }
            }

            b.Close();
        }

        private void DataFileHard(string[] had, int[] hat, ref int c)
        {
            // loads in difficulty level's scores and names
            // into appropriate arrays for sorting and displaying.

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\scores\hardscores.txt";

            StreamReader p = new StreamReader(f);

            string line1 = "";
            string line2 = "";
            bool finished = false;

            while (!finished)
            {
                line1 = p.ReadLine();
                line2 = p.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    c++;
                    had[c] = line1;
                    hat[c] = Convert.ToInt32(line2);
                }
            }

            p.Close();
        }

        private void DataFileExpert(string[] exd, int[] ext, ref int c)
        {
            // loads in difficulty level's scores and names
            // into appropriate arrays for sorting and displaying.

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\scores\expertscores.txt";

            StreamReader d = new StreamReader(f);

            string line1 = "";
            string line2 = "";
            bool finished = false;

            while (!finished)
            {
                line1 = d.ReadLine();
                line2 = d.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    c++;
                    exd[c] = line1;
                    ext[c] = Convert.ToInt32(line2);
                }
            }

            d.Close();
        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            // calls all methods used
            DataFileEasy(easynames, easyscores, ref countea);
            DataFileMedium(mediumnames, mediumscores, ref countme);
            DataFileHard(hardnames, hardscores, ref countha);
            DataFileExpert(expertnames, expertscores, ref countex);
            BubbleSort(expertnames, expertscores, countex, hardnames, hardscores, countha, mediumnames, mediumscores, countme, easynames, easyscores, countea);
            Display(expertnames, expertscores, hardnames, hardscores, mediumnames, mediumscores, easynames, easyscores);
        }
    }
}