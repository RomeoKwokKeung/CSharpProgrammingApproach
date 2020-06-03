using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LetterCount
{
    public partial class FrmLetterCount : Form
    {
        public FrmLetterCount()
        {
            InitializeComponent();
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence; i++)
            {
                letter = sentence.Substring(i, 1);
                TxtResult.Text += letter + Environment.NewLine;
            }

        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int LengthOfSentence = sentence.Length;

            for (int i = LengthOfSentence-1; i >=0; i--)
            {
                letter = sentence.Substring(i, 1);
                TxtResult.Text += letter + Environment.NewLine;
            }

        }

        private void BtnLetterCount_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int counta=0;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence; i++)
            {
                letter = sentence.Substring(i, 1);
                if (letter == "a")
                {
                    counta++;
                }
            }

            MessageBox.Show("The number of letter a\'s in the sentence is " + counta.ToString());

        }

        
    }
}