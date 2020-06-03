using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isDragging = false;
        Rectangle dropRect = new Rectangle(180, 180, 60, 60);

        private void myPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void myPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                myPictureBox.Top += (e.Y);
                myPictureBox.Left += (e.X);
            }
        }

        private void myPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.AntiqueWhite, dropRect);
            g.DrawString("Drag and drop the image here", new Font("Times New Roman ", 8), Brushes.Red, dropRect);
        }


    }
}