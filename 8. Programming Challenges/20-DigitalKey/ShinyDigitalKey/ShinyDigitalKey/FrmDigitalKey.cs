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

namespace ShinyDigitalKey
{
    public partial class FrmDigitalKey : Form
    {
        public FrmDigitalKey()
        {
            InitializeComponent();
        }

        private void BtnDigitalKey_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\digitalkey.txt";

            StreamReader r = new StreamReader(f);

            string line;
            int teeth;
            

            for (int i=1;i<=2;i++)
            {
                for (int j=1;j<=7;j++)
                {
                    line = r.ReadLine();
                    teeth = CountTeeth(line);                                   
                    TxtDisplay.Text += teeth ; 
                }

                TxtDisplay.Text += Environment.NewLine;

                line = r.ReadLine();
                
                
            }
        }

        private int CountTeeth(string s)
        {
            int c = 0;

            //count teeth ... look for #
            for (int i=0;i<s.Length;i++)
            {
                if (s.Substring(i,1)=="#")
                {
                    c++;
                }
            }

            return c;            
        }
    }
}
