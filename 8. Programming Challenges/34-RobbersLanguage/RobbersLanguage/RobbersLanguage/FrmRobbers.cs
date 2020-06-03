using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RobbersLanguage
{
    public partial class FrmRobbers : Form
    {
        public FrmRobbers()
        {
            InitializeComponent();
        }

        private void BtnRobbers_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\robbers.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            string consonant =  "bcdfghjklmnpqrstvwxyz";
            
            //The two strings below will help us determine
            //the CLOSEST vowel to the consonant in the alphabet
            //and the NEXT consonant in the alphabet following the 
            //original consonant
            string closestVowel = "aaeeeiiiiooooouuuuuuu";
            string nextConsonant = "cdfghjklmnpqrstvwxyzz";

            string newword;
            string letter;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    newword = "";
                    for (int i=0;i<line.Length;i++)
                    {
                        letter = line.Substring(i, 1);
                        int j = consonant.IndexOf(letter);

                        //original letter is always copied over ... vowel or consonant
                        newword += letter;

                        if (j>-1)       //if it's not a vowel add closest vowel and next consonant 
                                        //forming new 3 letter Robber Language attachment
                        {
                            newword += closestVowel.Substring(j, 1) + nextConsonant.Substring(j, 1);
                        }

                    }
                    TxtDisplay.Text += newword + Environment.NewLine;
                }
            }
        }
    }
}
