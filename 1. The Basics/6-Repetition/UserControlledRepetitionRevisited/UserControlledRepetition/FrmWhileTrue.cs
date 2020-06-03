using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserControlledRepetition
{
    public partial class FrmWhileTrue : Form
    {
        public FrmWhileTrue()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double mark;
            int count = 0;
            double total = 0;
            double average;
            string response="";

            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("do you wish to continue y/n", "Averages", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;

                UserInput input = new UserInput();

                if (input.ShowDialog() == DialogResult.OK)
                {
                    if (input.StudentMark != "")
                    {
                        mark = Convert.ToInt32(input.StudentMark);

                        if (mark < 0 || mark > 100)
                        {
                            MessageBox.Show("Invalid mark");
                        }
                        else
                        {
                            count++;
                            total += mark;
                        }
                    }
                }
            }

                if (count != 0)
                {
                    average = total / count;
                    MessageBox.Show("The average is " + average.ToString("n2"));
                }
                else
                {
                    MessageBox.Show("No marks entered");
                }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}