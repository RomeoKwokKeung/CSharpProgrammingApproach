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

namespace VowelPalindromes
{
    public partial class FrmVowels : Form
    {
        public FrmVowels()
        {
            InitializeComponent();
        }

        private void BtnVowels_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\vowels.txt";

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
                    //Here's where we extract every letter in the text
                    //Check if it's a vowel
                    //If it is we concatenate it to create a new string 
                    //just out of the vowels
                    //Lastly we then check if this newly created string is a palindrome
                    string vowels = "";
                    for (int i=0;i<line.Length;i++)
                    {
                        string c = line.Substring(i, 1);
                        if (isVowel(c))
                        {
                            vowels += c;
                        }
                    }  
                                        
                    TxtDisplay.Text += line+ "--" + vowels + "--" + "Is " +  palindrome(vowels) + Environment.NewLine + Environment.NewLine;
                    
                }
            }
        }

        private bool isVowel (string c)
        {
            string vow = "AEIUOY";
            int index = vow.IndexOf(c);

            //if we find the passed character (c) in the list of vowels
            //return true else return false
            if (index == -1)
                return false;
            else
                return true;
        }

        private string palindrome(string v)
        {
            string status = "";

            //This is the end position of the string
            //We will compare the character at that position
            //to the character at the front.
            //Then move a little in from the left and right

            int j = v.Length - 1;

            bool palindrome = true;

            //really only have to go half way
            //but this code avoids have to determine 
            //middle (even or odd length cases)
            for (int i=0;i<v.Length;i++)
            {
                if (v.Substring(i,1)!=v.Substring(j,1))
                {
                    palindrome = false;
                }

                j--;
            }
            if (!palindrome)
            {
                status = "Not A Palindrome";
            }
            else
            {
                status = "Palindrome";
            }

            return status;
        }
    }
}
