using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiceRollProblem
{
    public partial class FrmDiceRollProblem : Form
    {
        public FrmDiceRollProblem()
        {
            InitializeComponent();
        }

        Random rNum = new Random();
        
        private void BtnDiceRoll_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(FrmDiceRollProblem.DefaultBackColor);
            
            int die1 = rNum.Next(6) + 1;
            string d1 = Application.StartupPath + "\\Dice" + die1.ToString() + ".gif";
            Image image1 = Image.FromFile(d1);
            g.DrawImage(image1, 16, 24, 96, 96);

            int die2 = rNum.Next(6) + 1;
            string d2 = Application.StartupPath + "\\Dice" + die2.ToString() + ".gif";
            Image image2 = Image.FromFile(d2);
            g.DrawImage(image2, 144, 24, 96, 96);

            int sum = die1 + die2;
            
            //Create a Font
            Font font = new Font("Verdana", 10);

            //Create a Brush
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Draw the String
            g.DrawString("You rolled " + sum.ToString(), font, brush, 80, 140);

            g.Dispose();
        }
    }
}