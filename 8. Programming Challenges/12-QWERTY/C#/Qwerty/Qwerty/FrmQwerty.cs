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

namespace Qwerty
{
    public partial class FrmQwerty : Form
    {
        public FrmQwerty()
        {
            InitializeComponent();
        }

        //match Dvorak and QWERTY keyboard keys

        string dr = "[]',.pyfgcrl/=aoeuidhtns-;qjkxbmwvz";
        string qr = "-=qwertyuiop[]asdfghjkl;'zxcvbnm,./";

        string ds = "{}\"<>PYFGCRL?+AOEUIDHTNS_:QJKXBMWVZ";
        string qs = "_+QWERTYUIOP{}ASDFGHJKL:\"ZXCVBNM<>?";
        

        private void BtnQWERTY_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\qwerty.txt";

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
                    TxtDisplay.Text += Convert(line) + Environment.NewLine;                    
                }
            }
        }

        private string Convert(string w)
        {
            string c = "";

            
            for (int i = 0; i < w.Length; i++)
            {
                string letter = w.Substring(i,  1);
                int idr = dr.IndexOf(letter);
                if (idr != -1)
                {
                    c += qr.Substring(idr, 1);
                }
                else
                {
                    int ids = ds.IndexOf(letter);
                    if (ids != -1)
                    {
                        c += qs.Substring(ids,  1);
                    }
                    else
                    {
                        c += letter;
                    }
                }
            }

            return c;

        }
    }
}
