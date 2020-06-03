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

namespace SquareTheWord
{
    public partial class FrmSquare : Form
    {
        public FrmSquare()
        {
            InitializeComponent();
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\square.txt";

            StreamReader r = new StreamReader(f);

            string word;
            bool finished = false;

            while (!finished)
            {
                word = r.ReadLine();
                if (word == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += SquareTheWord(word);
                     
                    TxtDisplay.Text += Environment.NewLine;
                }
            }
            r.Close();
        }

        private string SquareTheWord(string w)
        {
            string SquareString = w + Environment.NewLine;

            for (int r = 1; r < w.Length - 1; r++)
            {
                SquareString += w.Substring(r,1);

                for (int c = 1; c < w.Length - 1; c++)
                {
                    SquareString += " ";
                }

                SquareString += w.Substring(w.Length - r - 1,1) + Environment.NewLine;

            }

            for (int r = w.Length - 1; r >= 0; r--)
            {
                SquareString += w.Substring(r,1);
            }

            SquareString += Environment.NewLine;


            return SquareString;
        }
    }
}
