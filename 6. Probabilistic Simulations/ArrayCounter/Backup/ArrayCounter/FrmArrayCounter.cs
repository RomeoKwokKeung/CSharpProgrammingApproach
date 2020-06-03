using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArrayCounter
{
    public partial class FrmArrayCounter : Form
    {
        public FrmArrayCounter()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int [] mark = new int [101];
            int [] freq = new int [101];
            int numberOfmarks =0;

            DataEntry(mark,ref numberOfmarks);
            Display(mark,numberOfmarks);
            
            frequency(mark, freq, numberOfmarks);
            DisplayFrequency(freq);

        }

        private void DataEntry(int[] sm, ref int c)
        {
            string response = "";

            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have any entries y/n", "Arrays", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;

                
                int tempM = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your mark", "Arrays", "", 200, 200));

                if (tempM >= 0 && tempM <= 100)
                {
                    c++;
                    sm[c] = tempM;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void Display(int[] m, int u)
        {
            LstInfo.Items.Clear();
            LstInfo.Items.Add("Original List");
            for (int i = 1; i <= u; i++)
            {
                LstInfo.Items.Add( m[i].ToString());
            }
        }

        private void DisplayFrequency(int[] f)
        {
            LstFrequency.Items.Clear();
            LstFrequency.Items.Add("Frequency List");
            LstFrequency.Items.Add("Mark" + "\t" + "Frequency");
            
            for (int i = 0; i <= 100; i++)
            {
                if (f[i]!=0)
                    LstFrequency.Items.Add(i.ToString()+ "\t" + f[i].ToString());
            }
        }

        private void frequency(int[] m, int[] f, int u)
        {
            for (int i = 1; i <= u; i++)
            {
                f[m[i]] = f[m[i]] + 1;
            }
        }

    }
}