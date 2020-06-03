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

namespace Title
{
    public partial class FrmTitle : Form
    {
        public FrmTitle()
        {
            InitializeComponent();
        }

        string[] lines;
        string UpdatedLine;

        private void BtnTitle_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\title.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            bool finished = false;
            int count = 1;

            while (!finished)
            {
                UpdatedLine = "";
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    //The command (WholeLine.Split) is key 
                    //it pulls apart all the words in the line and stores them into an array... lines[0]...lines[1].....
                    lines = WholeLine.Split(' ');
                    int u = lines.Length;

                    //calling a method to do the dirty work... makes mainline  a little less cluttered
                    UpdatedLine = CreatNewLine(lines, u);
                                        
                    TxtDisplay.Text += "#" + count.ToString() + ": "  + UpdatedLine + Environment.NewLine;
                    count++;
                    
                }
            }
        }

        private string CreatNewLine(string [] s,int u)
        {
            string NewS = "";

            //loop through all the words 
            for (int j=0;j<u;j++)
            {
                //if we are at the beginning of the sentence then capitalize
                if (j==0)
                {
                    NewS += Capitalize(s[j]);
                }
                //Capitalize everything else EXCEPT the words below
                else if (s[j]!="a" && s[j]!="an" && s[j]!="and" && s[j] != "the" && s[j] != "or" && s[j] != "for" && s[j] != "on" && s[j] != "is" && s[j] != "of")
                {
                    NewS += Capitalize(s[j]);
                }
                //Last case ... must be one of the special words above... just leave as is
                else
                {
                    NewS += s[j];
                }

                //Not at the end yet ... so add a blank otherwise add a period to finish the sentence.
                if (j < u - 1)
                    NewS += " ";
                else
                    NewS += ".";
            }

            return NewS;
        }

        private string Capitalize(string str)
        {
            if (str.Length == 0)
                return str;
            //Capitalize first letter and concatenate (attach) it to the remainder of the word 
            //Remember when the second parameter is not indicated we take from position 1 in this case to the ... end! 
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}

