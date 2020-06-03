using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BarChart
{
    public partial class FrmBarChart : Form
    {
        public FrmBarChart()
        {
            InitializeComponent();
        }

        Graphics g;

        private void BtnHorizontal_Click(object sender, EventArgs e)
        {
            string[] Year = new string[20];
            double [] Sales = new double[20];
            int counter = 0;

            DataFile(Year, Sales, ref counter);
            BarGraph(Year, Sales, counter);
        }

        private void DataFile(string[] y, double[] s, ref int c)
        {

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\sales.txt";

            StreamReader r = new StreamReader(f);

            string line1, line2;
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();
                line2 = r.ReadLine();

                if (line1 == null || line2 == null)
                {
                    finished = true;
                }
                else
                {
                    c++;
                    y[c] = line1;
                    s[c] = Convert.ToInt32(line2);
                }

            }

            r.Close();

        }

        private void BarGraph(string[] y, double [] s, int c)
        {
            Random r = new Random();
            
            double sf = Scaling(s, c);     //find scaling factor

            //g.Clear(Color.White);
            g.Clear(panel1.BackColor);

            //Create a Font
            Font font = new Font("Verdana", 8);

            //Create a Brush
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Draw the String
            g.DrawString("Bar Graph Program", font, brush,panel1.Width/2-30 , 10);
            
            g.DrawString("Year",font,brush, 10, 45);
            g.DrawString("Sales",font,brush, 50, 45);
            
            for (int i = 1; i <= c; i++)
            {

                g.DrawString(y[i].ToString(),font,brush,10,48+i*30);
                g.DrawString(s[i].ToString("c"),font,brush,50,48 +i*30);           
                
                int x = (int)(s[i] / sf + .5);    //scale data

                Color myRandom = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                
                SolidBrush solidbrush = new SolidBrush(myRandom);
                g.FillRectangle(solidbrush, 120, 50+i*30,x,10);
                                
            }
        }

        private double Scaling(double[] y, int u)
        {
            double big = -1000;
            double scalingfactor = 0;

            for (int i = 1; i <= u; i++)
            {
                if (y[i] > big)
                    big = y[i];
            }

            scalingfactor = big / (panel1.Width - 200);

            return scalingfactor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

        private void BtnVertical_Click(object sender, EventArgs e)
        {
            string[] Year = new string[20];
            double[] Sales = new double[20];
            int counter = 0;

            DataFile(Year, Sales, ref counter);
            VerticalBarGraph(Year, Sales, counter);
        }

        private void VerticalBarGraph(string[] y, double[] s, int c)
        {
            Random r = new Random();

            double sf = VerticalScaling(s, c);     //find scaling factor

            //g.Clear(Color.White);
            g.Clear(panel1.BackColor);

            //Create a Font
            Font font = new Font("Verdana", 8);

            //Create a Brush
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Draw the String
            g.DrawString("Bar Graph Program", font, brush, panel1.Width / 2 -30, 10);
                        
            for (int i = 1; i <= c; i++)
            {

                g.DrawString(y[i].ToString(), font, brush, 10 + i*50 , panel1.Height-50);
                
                int yheight = (int)(s[i] / sf + .5);    //scale data

                Color myRandom = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

                SolidBrush solidbrush = new SolidBrush(myRandom);
                g.FillRectangle(solidbrush, 20+i*50, panel1.Height-50-yheight, 10, yheight);
                
                g.DrawString(s[i].ToString("c"), font, brush, i*50-5, panel1.Height-50-yheight-20);

            }
        }

        private double VerticalScaling(double[] y, int u)
        {
            double big = -1000;
            double scalingfactor = 0;

            for (int i = 1; i <= u; i++)
            {
                if (y[i] > big)
                    big = y[i];
            }

            scalingfactor = big / (panel1.Height - 200);

            return scalingfactor;
        }


        
    }
}