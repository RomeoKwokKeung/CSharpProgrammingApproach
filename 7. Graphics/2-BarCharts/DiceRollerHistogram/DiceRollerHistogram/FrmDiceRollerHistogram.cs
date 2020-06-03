using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiceRollerHistogram
{
    public partial class FrmDiceRollerHistogram : Form
    {
        public FrmDiceRollerHistogram()
        {
            InitializeComponent();
        }

        Graphics g;

        private void FrmDiceRollerHistogram_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDiceRollerHistogram_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

        private void BarGraph(int [] dc)
        {
            Random r = new Random();

            double sf = Scaling(dc, 12);     //find scaling factor

            //g.Clear(Color.White);
            g.Clear(panel1.BackColor);

            //Create a Font
            Font font = new Font("Verdana", 8);

            //Create a Brush
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Draw the String
            g.DrawString("Dice Roller Histogram", font, brush, panel1.Width / 2 - 30, 10);

            g.DrawString("Roll", font, brush, 10, 45+30);
            g.DrawString("Frequency", font, brush, 50, 45+30);

            for (int i = 2; i <= 12; i++)
            {

                g.DrawString(i.ToString(), font, brush, 10, 48 + i * 30);
                g.DrawString(dc[i].ToString(), font, brush, 50, 48 + i * 30);

                int x = (int)(dc[i] / sf + .5);    //scale data

                Color myRandom = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

                SolidBrush solidbrush = new SolidBrush(myRandom);
                g.FillRectangle(solidbrush, 120, 50 + i * 30, x, 10);

            }
        }


        private double Scaling(int [] d, int u)
        {
            double big = -1000;
            double scalingfactor = 0;

            for (int i = 1; i <= u; i++)
            {
                if (d[i] > big)
                    big = d[i];
            }

            scalingfactor = big / (panel1.Width - 200);

            return scalingfactor;
        }

        private void VerticalBarGraph(int [] dc)
        {
            Random r = new Random();

            double sf = VerticalScaling(dc,12);     //find scaling factor

            //g.Clear(Color.White);
            g.Clear(panel1.BackColor);

            //Create a Font
            Font font = new Font("Verdana", 8);

            //Create a Brush
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Draw the String
            g.DrawString("Dice Roller Histogram", font, brush, panel1.Width / 2 - 30, 10);

            for (int i = 2; i <= 12; i++)
            {

                g.DrawString(i.ToString(), font, brush,  i * 50, panel1.Height - 50);

                int yheight = (int)(dc[i] / sf + .5);    //scale data

                Color myRandom = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

                SolidBrush solidbrush = new SolidBrush(myRandom);
                g.FillRectangle(solidbrush,  i * 50, panel1.Height - 50 - yheight, 10, yheight);

                g.DrawString(dc[i].ToString(), font, brush, i * 50 - 5, panel1.Height - 50 - yheight - 20);

            }
        }

        private void BtnHorizontal_Click(object sender, EventArgs e)
        {
            int [] dCounter = new int[13];

            DiceRoll(dCounter, 1000);
            BarGraph(dCounter);
        }

        private void DiceRoll(int[] dc, int u)
        {
            Random r = new Random();

            for (int i = 1; i <= 12; i++)
            {
                dc[i] = 0;
            }

            for (int toss = 1; toss <= u; toss++)
            {
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);

                dc[roll1 + roll2]++;
            }
        }

        private double VerticalScaling(int[] d,int u)
        {
            double big = -1000;
            double scalingfactor = 0;

            for (int i = 1; i <= u; i++)
            {
                if (d[i] > big)
                    big = d[i];
            }

            scalingfactor = big / (panel1.Height - 200);

            return scalingfactor;
        }

        private void BtnVertical_Click(object sender, EventArgs e)
        {
            int[] dCounter = new int[13];

            DiceRoll(dCounter, 1000);
            VerticalBarGraph(dCounter);
        }
    }
}