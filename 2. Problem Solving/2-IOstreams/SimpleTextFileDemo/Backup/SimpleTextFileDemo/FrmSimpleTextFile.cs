using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;    //need this for StreamReader

namespace SimpleTextFileDemo
{
    public partial class FrmSimpleTextFile : Form
    {
        public FrmSimpleTextFile()
        {
            InitializeComponent();
        }

        private void BtnDisplayFriends_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\friends.txt";

            StreamReader r = new StreamReader(f);

            string line;
            string contents = "";
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
                    contents += line + Environment.NewLine;
                }

            }

            r.Close();

            TxtDisplay.Text = contents;
        }

        //public scope
        string studentname;
        string studentmark;

        double total ;
        int counter;
        double average ;

        string contents ;

        private void BtnMarks_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            contents = "";
            total = 0;
            counter = 0;
            average = 0;

            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\marks.txt";

            StreamReader r = new StreamReader(f);            
            
            bool finished = false;

            while (!finished)
            {
                ReadData(r);
                
                if (studentname==null ||studentmark == null)
                {
                    finished = true;
                }
                else
                {
                    Math();
                }

            }

            r.Close();

            average = total/counter;

            TxtDisplay.Text = contents + Environment.NewLine + "Overall Average is " + average.ToString("n2"); ;
        }

        private void Math()
        {
            counter++;
            total += Convert.ToInt32(studentmark);
            contents += studentname + " " + studentmark + Environment.NewLine;
        }

        private void ReadData(StreamReader r)
        {
            studentname = r.ReadLine();
            studentmark = r.ReadLine();
        }
    }
}