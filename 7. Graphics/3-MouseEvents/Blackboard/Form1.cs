#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Blackboard
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool mousePress;
        int xLast;
        int yLast;
        Graphics myGraphics;
        Pen myPen;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create graphics and pen objects
            myGraphics = pnlBlackboard.CreateGraphics();
            myPen = new Pen(Color.Gray, 1);
            // Initialize the eight radio button colors 
            rdoGray.BackColor = Color.Gray;
            rdoBlue.BackColor = Color.Blue;
            rdoGreen.BackColor = Color.LightGreen;
            rdoCyan.BackColor = Color.Cyan;
            rdoRed.BackColor = Color.Red;
            rdoMagenta.BackColor = Color.Magenta;
            rdoYellow.BackColor = Color.Yellow;
            rdoWhite.BackColor = Color.White;
            // Set initial color
            rdoGray.Checked = true;
            mousePress = false;
        }

        private void rdoGray_CheckedChanged(object sender, EventArgs e)
        {
            // Gray 
            myPen.Color = rdoGray.BackColor;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            // Blue 
            myPen.Color = rdoBlue.BackColor;
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            // Green 
            myPen.Color = rdoGreen.BackColor;
        }

        private void rdoCyan_CheckedChanged(object sender, EventArgs e)
        {
            // Cyan
            myPen.Color = rdoCyan.BackColor;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            // Red 
            myPen.Color = rdoRed.BackColor;
        }

        private void rdoMagenta_CheckedChanged(object sender, EventArgs e)
        {
            // Magenta
            myPen.Color = rdoMagenta.BackColor;
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            // Yellow
            myPen.Color = rdoYellow.BackColor;
        }

        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {
            // White
            myPen.Color = rdoWhite.BackColor;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // Clear the blackboard
            myGraphics.Clear(pnlBlackboard.BackColor);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBlackboard_MouseDown(object sender, MouseEventArgs e)
        {
            // Start drawing if left click
            if (e.Button == MouseButtons.Left)
            {
                mousePress = true;
                xLast = e.X;
                yLast = e.Y;
            }
        }

        private void pnlBlackboard_MouseMove(object sender, MouseEventArgs e)
        {
            // Draw a line if drawing
            if (mousePress)
            {
                myGraphics.DrawLine(myPen, xLast, yLast, e.X, e.Y);
                xLast = e.X;
                yLast = e.Y;
            }
        }

        private void pnlBlackboard_MouseUp(object sender, MouseEventArgs e)
        {
            // Finish line
            if (e.Button == MouseButtons.Left)
            {
                myGraphics.DrawLine(myPen, xLast, yLast, e.X, e.Y);
                mousePress = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();
            myPen.Dispose();
        }
    }
}