using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeHeight
{
    public partial class FrmAgeHeight : Form
    {
        public FrmAgeHeight()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            DialogResult response;
            UserInput input = new UserInput();
                       
            int c13, c14, c15, c16, c17, c18;
            int a13, a14, a15, a16, a17, a18;

            double av13, av14, av15, av16, av17, av18;

            c13 = 0;
            c14 = 0;
            c15 = 0;
            c16 = 0;
            c17 = 0;
            c18 = 0;

            a13 = 0;
            a14 = 0;
            a15 = 0;
            a16 = 0;
            a17 = 0;
            a18 = 0;

            while (true)
            {
                response = MessageBox.Show("Do you have any more entries", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.No)
                {
                    break;
                }
                else
                {
                    if (input.ShowDialog() == DialogResult.OK)
                    {

                        if (input.Age == "" && input.StudentHeight == "")
                        {
                            MessageBox.Show("Missing Age and Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (input.Age == "")
                        {
                            MessageBox.Show("Missing Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (input.StudentHeight == "")
                        {
                            MessageBox.Show("Missing Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (int.Parse(input.Age) < 13 || int.Parse(input.Age) > 18)
                        {
                            MessageBox.Show("Only ages between 13 and 18 please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (int.Parse(input.StudentHeight) <= 0)
                        {
                            MessageBox.Show("Positive heights only please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (int.Parse(input.Age) == 13)
                        {
                            c13++;
                            a13 += int.Parse(input.StudentHeight);
                        }
                        else if (int.Parse(input.Age) == 14)
                        {
                            c14++;
                            a14 += int.Parse(input.StudentHeight);
                        }
                        else if (int.Parse(input.Age) == 15)
                        {
                            c15++;
                            a15 += int.Parse(input.StudentHeight);
                        }
                        else if (int.Parse(input.Age) == 16)
                        {
                            c16++;
                            a16 += int.Parse(input.StudentHeight);
                        }
                        else if (int.Parse(input.Age) == 17)
                        {
                            c17++;
                            a17 += int.Parse(input.StudentHeight);
                        }
                        else if (int.Parse(input.Age) == 18)
                        {
                            c18++;
                            a18 += int.Parse(input.StudentHeight);
                        }
                    }
                }
            }

            if (c13 != 0)
            {
                av13 = (double) a13 / c13;
            }
            else
            {
                av13 = 0;
            }
            if (c14 != 0)
            {
                av14 = (double) a14 / c14;
            }
            else
            {
                av14 = 0;
            }
            if (c15 != 0)
            {
                av15 = (double) a15 / c15;
            }
            else
            {
                av15 = 0;
            }
            if (c16 != 0)
            {
                av16 = (double) a16 / c16;
            }
            else
            {
                av16 = 0;
            }
            if (c17 != 0)
            {
                av17 = (double) a17 / c17;
            }
            else
            {
                av17 = 0;
            }
            if (c18 != 0)
            {
                av18 = (double) a13 / c18;
            }
            else
            {
                av18 = 0;
            }

            TxtDisplay.Text = "Average Height Results " + Environment.NewLine + Environment.NewLine;
            TxtDisplay.Text += "Age" + "\t" + "Average Height" + Environment.NewLine;
            TxtDisplay.Text += "13" + "\t" + av13.ToString("n2")+ Environment.NewLine;
            TxtDisplay.Text += "14" + "\t" + av14.ToString("n2") + Environment.NewLine;
            TxtDisplay.Text += "15" + "\t" + av15.ToString("n2") + Environment.NewLine;
            TxtDisplay.Text += "16" + "\t" + av16.ToString("n2") + Environment.NewLine;
            TxtDisplay.Text += "17" + "\t" + av17.ToString("n2") + Environment.NewLine;
            TxtDisplay.Text += "18" + "\t" + av18.ToString("n2") + Environment.NewLine;

        }
    }
}