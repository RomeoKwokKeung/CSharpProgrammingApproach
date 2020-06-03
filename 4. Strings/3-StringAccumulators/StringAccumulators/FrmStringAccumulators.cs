using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringAccumulators
{
    public partial class FrmStringAccumulators : Form
    {
        public FrmStringAccumulators()
        {
            InitializeComponent();
        }

        private void BtnConcat_Click(object sender, EventArgs e)
        {
            string word;
            string reverse = "";

            word = Microsoft.VisualBasic.Interaction.InputBox("Enter a Word", "String Accumulators", "", 200, 200);

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse = reverse + word.Substring(i, 1);
            }

            MessageBox.Show("Word Reversed is " + reverse);

        }

        private void BtnApplication_Click(object sender, EventArgs e)
        {
            string number;
            string reverse = "";

            number = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverse += number.Substring(i, 1);
            }

            long total = int.Parse(number) + int.Parse(reverse);

            //display the original number, reversed number and total number
            TxtResult.Text = number + Environment.NewLine + reverse + Environment.NewLine + total.ToString();

        }

        private void btnProblem2_Click(object sender, EventArgs e)
        {
            string number1;
            string number2;
            string reverse1 = "";
            string reverse2 = "";

            number1 = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);
            number2 = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);

            for (int i = 1; i <= 5; i += 2)
            {
                reverse1 = reverse1 + number1.Substring(i, 1);
            }

            for (int i = 1; i <= 5; i += 2)
            {
                reverse2 = reverse2 + number2.Substring(i, 1);
            }

            long total = int.Parse(reverse1) + int.Parse(reverse2);

            TxtResult.Text = reverse1 + Environment.NewLine + reverse2 + Environment.NewLine + total.ToString();
        }

        private void btnProblem3_Click(object sender, EventArgs e)
        {
            string reg;
            int total = 0;

            reg = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);

            for (int i = 0; i < reg.Length; i++)
            {
                total = total + int.Parse(reg.Substring(i, 1));
            }

            //no remain
            if(total % 7 == 0)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}