using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class FrmMouseMove : Form
    {
        public FrmMouseMove()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen mypen;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            mypen = new Pen(Color.Red, 1);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            g.DrawEllipse(mypen, e.X, e.Y, 15, 15);
        }
    }
}