using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Good
{
    public partial class FrmGood : Form
    {
        public FrmGood()
        {
            InitializeComponent();
        }

        
        private void BtnGood_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\good.txt";

            StreamReader read = new StreamReader(f);

            int cases = int.Parse(read.ReadLine());

            for (int i = 1; i <= cases; i++)
            {
                string[] lines;
                string WholeLine;

                WholeLine = read.ReadLine();    //This reads the first line of data

                lines = WholeLine.Split(' ');

                int x1 = int.Parse(lines[0]);
                int y1 = int.Parse(lines[1]);
                int x2 = int.Parse(lines[2]);
                int y2 = int.Parse(lines[3]);
                              

                TxtDisplay.Text += FixOrGood(x1,y1,x2,y2) + Environment.NewLine;

            }
        }

        private string FixOrGood(int a1, int b1, int a2, int b2)
        {
            string status = "";

            if ((a1 == a2) || (b1 == b2))
            {
                status = "It's all good";
            }
            else
            {
                status = "We need to fix this";
            }

            return status;

        }
    }
}
