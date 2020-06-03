using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraphicsClassIntro2
{
    public partial class FrmGraphicsClassIntro2 : Form
    {
        public FrmGraphicsClassIntro2()
        {
            InitializeComponent();
        }

        Graphics g;

        private void FrmGraphicsClassIntro2_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics(); 
            //note: just use this.CreateGraphics() if drawing
            //directly on the form
        }

        private void BtnGraphics_Click(object sender, EventArgs e)
        {
            //g.Clear(Color.White);
            g.Clear(panel1.BackColor);
            
            //Pens are C# built-in 1 pixel wide pens
            g.DrawLine(Pens.Red, 0, 0, panel1.Width, panel1.Height);

            Pen mypen = new Pen(Color.FromArgb(245, 202, 65), 10);
            g.DrawRectangle(mypen, 100, 50, 50, 100);
                 
        }

        private void FrmGraphicsClassIntro2_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

        private void BtnGraphicsTest2_Click(object sender, EventArgs e)
        {
            //g.Clear(Color.White);
            g.Clear(panel1.BackColor);

            Pen mypen = new Pen(Color.FromArgb(245, 202, 65), 10);
            g.DrawRectangle(mypen, 100, 50, 50, 100);


            SolidBrush solidbrush = new SolidBrush(Color.FromArgb(40, 90, 230));
            g.FillRectangle(solidbrush, 70, 50, 50, 120);

            //.FromArgb(alpha,r,g,b)
            SolidBrush transparentbrush = new SolidBrush(Color.FromArgb(100, 40, 90, 230));
            g.FillRectangle(transparentbrush, 120, 50, 50, 120);
        }
    }
}