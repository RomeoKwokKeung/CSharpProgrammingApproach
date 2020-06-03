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

namespace Fowl
{
    public partial class FrmFowl : Form
    {
        public FrmFowl()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnFowl_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\fowl.txt";

            int a;
            int b;
            int c;
            string hit = "";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            

            int n = int.Parse(r.ReadLine());

            for (int i=1;i<=n;i++)
            {
                WholeLine = r.ReadLine();

                lines = WholeLine.Split(' ');

                a = int.Parse(lines[0]);
                b = int.Parse(lines[1]);
                c = int.Parse(lines[2]);

                bool status = FowlStatus(a, b, c);

                if (status)
                {
                    hit = "YES"; 
                }
                else
                {
                    hit = "NO";
                }

                TxtDisplay.Text += "TARGET # " +  i.ToString() + " " + hit + Environment.NewLine;                                

            }

            r.Close();
        }

        private bool FowlStatus(int x, int y, int z)
        {
            bool st = false;

            //checking for hypotenuse since numbers can be in any order
            if (x >= y && x >= z)
            {
                if (x * x == y * y + z * z)
                {
                    st = true;
                }
                else
                {
                    st = false;
                }
            }
            else if (y >= x && y >= z)
            {
                if (y * y == x * x + z * z)
                {
                    st = true;
                }
                else
                {
                    st = false;
                }
            }
            else
            {
                if (z * z >= x * x && z * z >= y * y)
                {
                    if (z * z == x * x + y * y)
                    {
                        st = true;
                    }
                    else
                    {
                        st = false;
                    }
                }
            }

            return st;
                
           
        }
    }
}
