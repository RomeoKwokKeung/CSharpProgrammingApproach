using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; //using text files

namespace Mario_Game
{
    public partial class FrmScores : Form
    {
        public FrmScores()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmStart x = new FrmStart();
            x.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\Scores.txt";

            StreamReader r = new StreamReader(f);

            string line;
            string contents = "";
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();
                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    contents += line + Environment.NewLine;
                }
            }
            r.Close();
            LstScores.Items.Add(contents);
        }
    }
}