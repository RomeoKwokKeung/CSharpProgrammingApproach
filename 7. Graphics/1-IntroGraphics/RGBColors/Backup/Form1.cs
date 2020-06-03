#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace RGBColors
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.FromArgb((int) nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }
    }
}