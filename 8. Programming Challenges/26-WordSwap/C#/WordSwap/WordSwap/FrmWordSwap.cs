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

namespace WordSwap
{
    public partial class FrmWordSwap : Form
    {
        public FrmWordSwap()
        {
            InitializeComponent();
        }

        //used in CostToSwap method below to determine numeric position of letters in alphabet 
        string alpha = "abcdefghijklmnopqrstuvwxyz";

        private void BtnWordSwap_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\words.txt";

            StreamReader r = new StreamReader(f);

            int num;
            string word1;
            string word2;
            
                    
            num = int.Parse(r.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                word1 = r.ReadLine();
                word2 = r.ReadLine();

                //We are assuming that the word lengths are exactly the same

                int cost = CostToSwap(word1, word2);

                TxtDisplay.Text += "Swapping letters to make " + word1 + " Look like " + word2;

                if (cost>0)
                {
                    TxtDisplay.Text += " earned "+  cost + " coins" + Environment.NewLine;
                }  
                else if (cost <0)
                {
                    TxtDisplay.Text += " cost " + (-1)*cost + " coins" + Environment.NewLine;
                }  
                else
                {
                    TxtDisplay.Text += " was FREE" + Environment.NewLine;
                }

                
                
            }
            
        }

        private int CostToSwap(string w1,string w2)
        {
            //Return the number of coins earned (positive number) or to be paid (negative number)
            //For example:
            //if w1="a" and w2="d" you owe (must pay) should return -3
            //if w1="d" and w2="a" you earned (get paid) should return 3

            int c = 0;

            for (int i=0;i<w1.Length;i++)
            {
                //pull apart each letter and compare
                c += alpha.IndexOf(w1.Substring(i, 1)) - alpha.IndexOf(w2.Substring(i, 1));
            }

            return c;

        }
    }
}
