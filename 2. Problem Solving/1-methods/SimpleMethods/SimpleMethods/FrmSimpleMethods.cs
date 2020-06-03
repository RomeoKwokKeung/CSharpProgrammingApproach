using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleMethods
{
    public partial class FrmSimpleMethods : Form
    {
        public FrmSimpleMethods()
        {
            InitializeComponent();
        }

        private void BtnMethodReturn_Click(object sender, EventArgs e)
        {
            int firstnumber;
            int secondnumber;

            firstnumber = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Sample","",200,200));
            secondnumber = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","Sample","",200,200));

            int result = Multiply(firstnumber,secondnumber);

            Display(firstnumber, secondnumber, result);            
            
        }

        private int Multiply(int x, int y)
        {
            return x * y;
        }

        private void Display(int f,int s,int answer)
        {
            MessageBox.Show(f.ToString() + " times " + s.ToString() + " equals " + answer.ToString());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}