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

namespace GreetingInABox
{
    public partial class FrmGreeting : Form
    {
        public FrmGreeting()
        {
            InitializeComponent();
        }

        private void BtnGreeting_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\greeting.txt";

            StreamReader r = new StreamReader(f);

            int indent = int.Parse(r.ReadLine());
            int padding = int.Parse(r.ReadLine());
            string box = r.ReadLine();
            string sname = r.ReadLine();

            BoxGreeting(indent,padding,box,sname);                   
           
        }

        private void BoxGreeting(int ind,int pad,string b,string n)
        {
            //Display ruler
            for (int i = 0; i < 7; i++)
            {
                TxtDisplay.Text+= "1234567890";
            }
            TxtDisplay.Text+= Environment.NewLine;

            string greeting = "Hello there, " + n + "!";
                       
            int boxwidth = greeting.Length + 2 + 2 * pad;
            int rows = 2 * pad + 2 + 1;

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= ind; c++)
                {
                    TxtDisplay.Text +=" ";
                }
                if (r == 1 || r == rows)         //if we are at the very top or bottom 
                {                                //display an entire row of symbols
                    for (int c = 1; c <= boxwidth; c++)
                    {
                        TxtDisplay.Text+=b;
                    }
                }
                else
                {
                    if (r != (rows + 1) / 2)
                    {
                        TxtDisplay.Text+= b;
                        for (int c = 2; c <= boxwidth - 1; c++)
                        {
                            TxtDisplay.Text+=" ";
                        }
                        TxtDisplay.Text+=b;
                    }
                    else
                    {
                        TxtDisplay.Text += b; 
                        for (int c = 1; c <= pad; c++)
                        {
                            TxtDisplay.Text+=" ";
                        }
                        TxtDisplay.Text+=greeting;
                        for (int rp = 1; rp <= pad; rp++)
                        {
                            TxtDisplay.Text+=" ";
                        }
                        TxtDisplay.Text+=b;
                    }
                }
                TxtDisplay.Text+=Environment.NewLine;
            }
        }
    }
}
