#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace FormFun
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            // Shrink the form
            // Decrease the form height by 10 pixels
            this.Height = this.Height - 10;
            // Decrease the form width by 10 pixels
            this.Width = this.Width - 10;
        }

        private void btnGrow_Click(object sender, EventArgs e)
        {
            // Grow the form
            // Increase the form height by 10 pixels
            this.Height = this.Height + 10;
            // Increase the form width by 10 pixels
            this.Width = this.Width + 10;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            // Make form red
            this.BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            // Make form blue
            this.BackColor = Color.Blue;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            // Hide all buttons but btnShow
            btnGrow.Visible = false;
            btnShrink.Visible = false;
            btnHide.Visible = false;
            btnRed.Visible = false;
            btnBlue.Visible = false;
            // Show btnShow button
            btnShow.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Show all buttons but btnShow
            btnGrow.Visible = true;
            btnShrink.Visible = true;
            btnHide.Visible = true;
            btnRed.Visible = true;
            btnBlue.Visible = true;
            // Hide btnShow button
            btnShow.Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Grow the form
            // Increase the form height by 10 pixels
            this.Height = this.Height + 10;
            // Increase the form width by 10 pixels
            this.Width = this.Width + 10;
        }
    }
}