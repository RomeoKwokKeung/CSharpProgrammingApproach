using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CrashingWords
{
    public partial class FrmCrashWords : Form
    {
        public FrmCrashWords()
        {
            InitializeComponent();
        }

        string word1, word2;
        int crashpos;

        private void BtnCrashWords_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            
            TxtDisplay.Text = "Crashing Words Results" + Environment.NewLine + Environment.NewLine;

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\words.txt";

            StreamReader r = new StreamReader(f);

            bool finished = false;

            while (!finished)
            {
                ReadCreditData(r);

                if (word1 == null)
                {
                    finished = true;
                }
                else
                {
                    CheckOrder();
                    bool crash = CheckCrash();
                    if (crash == true)
                    {
                        DisplayCrash();
                    }
                    else
                    {
                        TxtDisplay.Text += "These words do not crash " + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            r.Close();

            
        }

        private void ReadCreditData(StreamReader r)
        {
            word1 = r.ReadLine();
            word2 = r.ReadLine();            
        }

        private void CheckOrder()
        {
            string temp="";

            if (word1.CompareTo(word2) > 0)
            {
                temp = word1;
                word1 = word2;
                word2 = temp;
            }

        }

        private bool CheckCrash()
        {
            bool status = false;
            crashpos = -1;

            int c = 0;

            while (c < word1.Length)
            {
                if (word1.Substring(c, 1) == word2.Substring(c, 1))
                {
                    status = true;
                    crashpos = c;
                    break;
                }

                c++;
            }
            
            return status;

        }

        private void DisplayCrash()
        {
            string Spaces = "                                                 ";
            string RequiredSpaces = Spaces.Substring(0, crashpos);

            for (int ch = 0; ch < crashpos; ch++)
            {
                TxtDisplay.Text += RequiredSpaces + word1.Substring(ch, 1)+ Environment.NewLine;
            }

            TxtDisplay.Text += word2 + Environment.NewLine;

            for (int ch = crashpos + 1; ch < word1.Length; ch++)
            {
                TxtDisplay.Text += RequiredSpaces + word1.Substring(ch, 1) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine ;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}