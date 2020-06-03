using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BeachBalls
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            frmGame x = new frmGame();
            x.ShowDialog();
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {
            frmInstructions x = new frmInstructions();
            x.ShowDialog();
        }
    }
}