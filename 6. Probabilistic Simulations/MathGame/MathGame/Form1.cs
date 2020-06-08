using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        Random randomNo = new Random();
        int no1;
        int no2;
        string problemType = "+";

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            StartGame.Visible = false;
            CheckAnswer.Visible = true;
            Question.Visible = true;
            Answer.Visible = true;
            NextQuestion.Visible = true;
            Feedback.Text = "";
            Feedback.Visible = true;
            Gen_Question();
        }

        private void Gen_Question()
        {
            no1 = randomNo.Next(100);
            no2 = randomNo.Next(100);

            if (radioButton1.Checked)
            {
                problemType = "+";
            }
            else if (radioButton2.Checked)
            {
                problemType = "-";
            }
            else if (radioButton3.Checked)
            {
                problemType = "*";
            }

            Question.Text = no1 + problemType + no2 + "=";
        }

        private void CheckAnswer_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (problemType == "+")
            {
                result = no1 + no2;
            }
            else if (problemType == "-")
            {
                result = no1 - no2;
            }
            else if (problemType == "*")
            {
                result = no1 * no2;
            }

            if (Answer.Text == result.ToString())
            {
                Feedback.Text = "Correct";
            }
            else
            {
                Feedback.Text = "Incorrect";
            }

        }

        private void NextQuestion_Click(object sender, EventArgs e)
        {
            Gen_Question();
            Answer.Text = "";
            Feedback.Text = "";
        }

    }
}