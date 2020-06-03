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

            for (int i = LengthOfSentence - 1; i >= 0; i--)
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

            int counta = 0;

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

        //count the a,e,i,o,u in a sentence
        private void btnProblem1_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int countvowels = 0;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence; i++)
            {
                letter = sentence.Substring(i, 1);
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    countvowels++;
                }
            }

            MessageBox.Show("The number of letter a\'s in the sentence is " + countvowels.ToString());
        }

        //count the "the" in a sentence
        private void btnProblem2_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int countthe = 0;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence - 4; i++)
            {
                letter = sentence.Substring(i, 5);
                if (letter == " the ")
                {
                    countthe++;
                }
            }

            MessageBox.Show("The number of letter a\'s in the sentence is " + countthe.ToString());
        }

        private void btnProblem3_Click(object sender, EventArgs e)
        {
            string sentence;

            do
            {
                sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);
            }
            // have to enter an odd sentence
            while (sentence.Length % 2 == 0);

            int MiddleLetter;
            string MiddlePosition;

            int LengthOfSentence = sentence.Length;

            MiddleLetter = (LengthOfSentence + 1) / 2 - 1;
            MiddlePosition = sentence.Substring(MiddleLetter, 1);

            MessageBox.Show("The middle letter is " + MiddlePosition.ToString());
        }
    }
}