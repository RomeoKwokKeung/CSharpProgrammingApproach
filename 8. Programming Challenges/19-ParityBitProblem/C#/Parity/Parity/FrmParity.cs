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

namespace Parity
{
    public partial class FrmParity : Form
    {
        public FrmParity()
        {
            InitializeComponent();
        }

        private void BtnParity_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\parity.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    string p = DetermineParity(line);
                    TxtDisplay.Text += line + " " + p +  Environment.NewLine;
                    
                }
            }
        }

        private string DetermineParity(string n)
        {
            string c="";
            int counter = 0;

            //the command below is the easy way to convert a number to a required base
            //eg binary 2 hexadecimal 16
            //string binary = Convert.ToString(int.Parse(n), 2);

            //Lets do it ourselves and learn something!
            string binary = DecimalToBinary(n);

            //count the number of 1 bits
            for (int j=0;j<binary.Length;j++)
            {
                if (binary.Substring(j,1)=="1")
                {
                    counter++;
                }
            }

            //check if the number of 1 bits is even or odd
            //if its even ... no worries
            //if its odd ... need to ADD 1 to make it even parity
            if (counter%2==0)
            {
                c = "0";
            }
            else
            {
                c = "1";
            }
            
            return c;
        }

        private string DecimalToBinary(string n)
        {
            int decimalNumber = int.Parse(n);

            int remainder;
            string result = "";

            //keep going through the decimal to binary process until
            //the number to divide by 2 is 0

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;         //this remainder calculation is one bit (0 or 1) of the final created binary number 
                decimalNumber /= 2;                    //this is the next number we will find the remainder of when we go to top of the loop
                result = remainder.ToString() + result; // notice how we concatenate the previous result to the end and not the beginning
            }                                           // to correctly form the binary number   
            return result;
        }
    }
}
