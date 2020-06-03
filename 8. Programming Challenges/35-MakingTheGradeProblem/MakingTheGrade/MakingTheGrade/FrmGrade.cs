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

namespace MakingTheGrade
{
    public partial class FrmGrade : Form
    {
        public FrmGrade()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\grade.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;

            int n = int.Parse(read.ReadLine());
                        
            for (int x = 1; x <= n; x++)
            {
                WholeLine = read.ReadLine();

                lines = WholeLine.Split(' ');

                int A = int.Parse(lines[0]);
                int B = int.Parse(lines[1]);
                int C = int.Parse(lines[2]);

                double MarkTo90 = MakeGrade(A, B, C);
                
                if (MarkTo90 >=0)
                {
                    TxtDisplay.Text += A.ToString() + "-" + B.ToString() + "-" + C.ToString() + " -----> YOU NEED A FINAL EXAM MARK OF AT LEAST " + MarkTo90.ToString ("n0") + Environment.NewLine;
                }
                else
                {
                    TxtDisplay.Text += A.ToString() + "-" + B.ToString() + "-" + C.ToString() + " ----->IT IS NOT POSSIBLE TO ACHIEVE A MARK OF 90% "  + Environment.NewLine;
                }
                
                
            }
        }

        private double  MakeGrade(int x,int y, int z)
        {

            //This problem is basically a math problem with a the programming being pretty straightforward
            //Here is my logic
            //Assuming the marks are x,y,z
            //Then we basically want x*.15+y*.20+z*.25 + MarkToGet90*.40 =90
            //After isolating the variable MarkToGet90*.40 = 90-(x*.15+y*.20+z*.25)
            //we finally divide by .40 ... and thats how I got the formula below
            double MarkToGet90 =  (90 - (x * .15 + y * .20 + z * .25)) / .40;

            //If the mark to get 90% overall is doable (0-100) then return that mark otherwise return a -1 to signal 
            //it will be impossible to get 90% overall
            if (MarkToGet90>=0 && MarkToGet90<=100)
            {
                return MarkToGet90;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
