// Drop the Block, see if you can catch it.
// This demo app demonstrates dynamic graphics with double buffering in VisStudio 
// It is easy to make a form DoubleBuffered using the property editor, but here we 
// demonstrate how to make a Panel doublebuffered.  Panels dont have the DoubleBuffer property
// visible because its Protected.  Hence we must subclass Panel by creating a MyPanel class
// to control the DoubleBuffered property.
// This app also demonstrates simple animation using a Timer control.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynaGraphics
{
    public partial class Form1 : Form
    {
        Rectangle r = new Rectangle(10, 10, 75, 75);
        bool isDragging = false;
        Brush b = Brushes.Red;
        int deltax, deltay;
        float rate = 2;

        public Form1()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;   // useful for drawing graphics on form1
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawStuff(g);           
        }

        private void DrawStuff(Graphics g)
        {
            // some closely spaced diagonal lines:
            for (int i = 0; i < 500; i++)
                g.DrawLine(Pens.Blue, 0, i, i, 0);

            // the rectangle:
            g.FillRectangle(b, r);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Hit-testing to initiate the dragging:
            if (r.Contains(e.X, e.Y))
            {
                timer1.Enabled = false;  // stop animating while dragging
                isDragging = true;
                b = Brushes.Yellow;
                deltax = e.X - r.X;   //remember where is mouse within the rectangle
                deltay = e.Y - r.Y;
                panel1.Refresh();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // do the dragging:
            if (isDragging)
            {
                panel1.Invalidate(r);      // need to redraw where old rect is.
                r.X = e.X - deltax;
                r.Y = e.Y - deltay;
                panel1.Invalidate(r);   // need to redraw where new rect is.
                //panel1.Refresh();     // would refresh entire panel, a little slower than invalidate(r).
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // end the dragging:
            if (isDragging)
            {
                isDragging = false;
                b = Brushes.Red;
                panel1.Refresh();
                timer1.Enabled = true;  // start animating after we drop it
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate(r);     
            r.Y += (int)rate;  // move the rectangle position one notch down.
            rate *= 1.5F;      // make it accelerate as it drops
            if (r.Y >= panel1.Height - r.Height)
            {
                r.Y = panel1.Height - r.Height;
                timer1.Enabled = false;   // stop animating when reach bottom.
                rate = 2;
            }
            panel1.Invalidate(r);
            //panel1.Refresh();
        }
    }

    // A doubleBuffered Panel.  subclasses Panel and makes it double buffered.
    // since DoubleBuffered is a protected property, can only be set by Panel class or subclass.
    // MyPanel should appear in the Toolbox under App Components, and can be manipulated just like a normal Panel widget.
    public class MyPanel : Panel
    {
        public MyPanel() : base()
        {
            this.DoubleBuffered = true;
        }
    } 

}