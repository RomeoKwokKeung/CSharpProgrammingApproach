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

namespace HappySad
{
    public partial class FrmHappySad : Form
    {
        public FrmHappySad()
        {
            InitializeComponent();
        }

        private void BtnHappySad_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\textmessage.txt";

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
                    TxtDisplay.Text += Status(line) +  Environment.NewLine;
                    
                }
            }
        }

        private string Status(string s)
        {
            int happy = 0;
            int sad = 0;

            string st = "";

            for (int i = 0; i < s.Length-2; i++) //don't go to end because we are taking
            {                                    //three characters(letters) at a time
                
                if (s.Substring(i, 3) == ":-)")
                {
                    happy++;
                }
                else if (s.Substring(i, 3) == ":-(")
                {
                    sad++;
                }
            }

            if (happy == 0 && sad == 0)
            {
                st = "NONE";
            }
            else if (happy == sad)
            {
                st = "UNSURE";
            }
            else if (happy>sad)
            {
                st = "HAPPY";
            }
            else
            {
                st = "SAD";
            }

            return st;

        }
    }
}
