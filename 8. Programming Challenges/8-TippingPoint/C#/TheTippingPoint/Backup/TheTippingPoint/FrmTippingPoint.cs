using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TheTippingPoint
{
    public partial class FrmTippingPoint : Form
    {
        public FrmTippingPoint()
        {
            InitializeComponent();
        }

        int[] sides = { 0,1,2,3,6,5,4 };//0 not used,top,front,right,bottom,back,left
        int top = 1;
        int front = 2;
        int right = 3;
        int bottom = 4;
        int back = 5;
        int left = 6;

        private void BtnDetermine_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\tipping.txt";

            StreamReader r = new StreamReader(f);

            string command;
            bool finished = false;

            while (!finished)
            {
                command = r.ReadLine();
                if (command == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += command + Environment.NewLine;
                    tip(command);
                }
            }

            r.Close();

            TxtDisplay.Text += Environment.NewLine + "Final Top Face Value is " + sides[1].ToString();

        }

        private void tip(string c)
        {

            int oldtop = sides[1];

            if (c == "LEFT")
            {
                sides[top] = sides[right];
                sides[right] = sides[bottom];
                sides[bottom] = sides[left];
                sides[left] = oldtop;
            }
            else if (c == "RIGHT")
            {
                sides[top] = sides[left];
                sides[left] = sides[bottom];
                sides[bottom] = sides[right];
                sides[right] = oldtop;
            }
            else if (c == "AWAY")
            {
                sides[top]=sides[front];
                sides[front]=sides[bottom];
                sides[bottom]=sides[back];
                sides[back]=oldtop;
            }
            else if (c=="TOWARD")
            {
                sides[top]=sides[back];
                sides[back]=sides[bottom];
                sides[bottom]=sides[front];
                sides[front]=oldtop;
            }


        }
    }
}
