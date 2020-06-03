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

namespace WordCount
{
    public partial class FrmWordCount : Form
    {
        public FrmWordCount()
        {
            InitializeComponent();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\word.txt";

            StreamReader r = new StreamReader(f);

            string word,sentence;
            string cmpWord;
                       
            int n= int.Parse(r.ReadLine());

            //The tricky part of this problem is the case insensitive matching, 
            //you can convert the input word and sentence to both upper or lower case 
            //although you must save a copy of the original word because it is required in the output

            for (int i=1;i<=n;i++)
            {

                word = r.ReadLine();
                sentence = r.ReadLine().ToLower();
                cmpWord = word.ToLower();

                int count = 0;
                int index = sentence.IndexOf(cmpWord);

                while(index!=-1)
                {
                    count++;
                    index = sentence.IndexOf(cmpWord, index + 1);
                }

                TxtDisplay.Text += "Line " + i + ": " + word +   " occured " + count + " times in the sentence -> " + sentence + Environment.NewLine;
            }                                       
                    
         }
   
    }
}
