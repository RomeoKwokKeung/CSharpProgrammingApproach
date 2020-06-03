using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClassGraphics
{
    public partial class FrmClassGraphics : Form
    {
        public FrmClassGraphics()
        {
            InitializeComponent();
        }

        Graphics g;

        private void FrmClassGraphics_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

        }

        private void BtnFace_Click(object sender, EventArgs e)
        {
            Face face1 = new Face(10, 10, Color.Yellow, Color.Black);
            face1.Paint(g);

            Face face2 = new Face(140, 10, Color.Cyan, Color.Black);
            face2.Paint(g);

            Face face3 = new Face(270, 170, Color.Red, Color.Green);
            face3.Paint(g);
        }
    }
}