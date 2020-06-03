using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TypeWriter
{
    public partial class FrmTypeWriter : Form
    {
        public FrmTypeWriter()
        {
            InitializeComponent();
        }

        private void BtnCost_Click(object sender, EventArgs e)
        {
            string message;

            bool finished = false;

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\typewriter.txt";

            StreamReader r = new StreamReader(f);

            while (!finished)
            {
                message = r.ReadLine();
                if (message == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += Cost(message).ToString() + Environment.NewLine;
                }

            }

            r.Close(); 

        }

        private int Cost(string m)
        {
            int c = 0;
            string last="q";

            for (int i = 0; i < m.Length; i++)
            {
                string current = m.Substring(i,1);
                c += Distance(last, current);
                last = current;

            }

            return c;
        }

        private int Distance(string a, string b)
        {

            return Math.Abs(Find(a) - Find(b));
        }

        private int Find(string a)
        {
            int pos = -1;
            
            string keyboard = "qwertyuiopasdfghjklzxcvbnm";

            pos = keyboard.IndexOf(a);

            return pos;

        }

    }
}
