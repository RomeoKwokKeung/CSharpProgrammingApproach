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


namespace Palidromes
{
    public partial class FrmPalidromes : Form
    {
        public FrmPalidromes()
        {
            InitializeComponent();
        }

        private void BtnPalidromes_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\palindromes.txt";

            StreamReader r = new StreamReader(f);

            string line;
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
                    if (IsPalindrome(line))
                    {
                        TxtDisplay.Text += line + "  is a palindrome " + Environment.NewLine;
                    }
                    else
                    {
                        TxtDisplay.Text += line + "  is not a palindrome " + Environment.NewLine;
                    }
                }
            }
        }

        private bool IsPalindrome(string str)
        {           

            //try matching character by character reading from both sides at once
            for (int i = 0; i < str.Length / 2; i++)
            {
               if (str.Substring(i, 1) != ReverseChar(str.Substring(str.Length - 1 - i, 1)))
               {
                    return false;
               }
            }
            
            // Special Case ... strings of odd length
            // the central character cannot be a reversible character
            if (str.Length%2==1)
            { 
              if (str.Substring(str.Length / 2, 1) != ReverseChar(str.Substring(str.Length / 2, 1)))
              {
                    return false;
              }
            }                   
               
            return true;           

        }

        private string ReverseChar(string c)
        {
            switch (c)
            {
                case "(": return ")";
                case ")": return "(";
                case "{": return "}";
                case "}": return "{";
                case "[": return "]";
                case "]": return "[";
                case "<": return ">";
                case ">": return "<";
                default: return c;
            }

        }
    }
}
