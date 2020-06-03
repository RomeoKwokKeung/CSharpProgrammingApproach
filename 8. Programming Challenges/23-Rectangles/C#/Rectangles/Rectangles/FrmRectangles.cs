using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Rectangles
{
    public partial class FrmRectangles : Form
    {
        public FrmRectangles()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnRectangles_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\rectangles.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            int top1, bottom1, left1, right1;
            int top2, bottom2, left2, right2;

            
            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    lines = line.Split(' ');

                    //get corner coordinates of rectangles

                    left1 = int.Parse(lines[0]);
                    bottom1 = int.Parse(lines[1]);
                    right1 = int.Parse(lines[2]);
                    top1 = int.Parse(lines[3]);

                    left2 = int.Parse(lines[4]);
                    bottom2 = int.Parse(lines[5]);
                    right2 = int.Parse(lines[6]);
                    top2 = int.Parse(lines[7]);

                    TxtDisplay.Text += left1 + "," + bottom1 + " *** " + right1 + "," + top1 +  Environment.NewLine;
                    TxtDisplay.Text += left2 + "," + bottom2 + " *** " + right2 + "," + top2 + Environment.NewLine;                    
                    TxtDisplay.Text += Solution(left1, bottom1, right1, top1, left2, bottom2, right2, top2) + Environment.NewLine;
                    TxtDisplay.Text += Environment.NewLine;

                }
            }

        }

        private string Solution(int l1,int b1,int r1,int t1,int l2,int b2,int r2,int t2)
        {
            string solution = "";

            //We look for 4 cases

            if (t1 <= b2 || t2 <= b1 || r1 <= l2 || r2 <= l1)
            {
                solution = "no overlap";
            }
            else
            {
                if (b1 <= b2 && t2 <= t1 && l1 <= l2 && r2 <= r1)
                {
                    solution = "first surrounds second";
                }
                else
                {
                    if (b2 <= b1 && t1 <= t2 && l2 <= l1 && r1 <= r2)
                    {
                        solution = "second surrounds first";
                    }
                    else
                    {
                        solution = "overlap";
                    }
                }
            }

            return solution;

        }
    }
}
