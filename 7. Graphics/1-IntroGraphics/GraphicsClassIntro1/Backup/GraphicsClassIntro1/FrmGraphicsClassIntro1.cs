using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraphicsClassIntro1
{
    public partial class FrmGraphicsClassIntro1 : Form
    {
        public FrmGraphicsClassIntro1()
        {
            InitializeComponent();
        }

        private void GraphicsClassIntro1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Create a Font
            Font font = new Font("Verdana", 30);

            //Create a Brush
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Draw the String
            g.DrawString("C# Says Hello!", font, brush, 40, 40);
            g.DrawString("Hello C#", new Font("Times New Roman", 30), new SolidBrush(Color.Green), 80, 80);

            // arial, 8 pt bold
            FontStyle style = FontStyle.Bold;
            Font arial = new Font("Arial", 8, style);
            g.DrawString("Arial font in bold", arial, brush, 300, 250);

            // courier new, 10 pt bold and italic
            style = FontStyle.Bold | FontStyle.Italic;
            Font courierNew = new Font("Courier New", 16, style);
            g.DrawString("Courier New 10 pt bold and italic", courierNew, brush, 5, 200);

            //Create a Pen
            Pen pen = new Pen(Color.Red,4);
            Pen mypen = new Pen(Color.Brown,2);
            
            //Draw a Line (pen,x1,y1,x2,y2)
            g.DrawLine(pen, 60, 200, 300, 200);
           
            //Draw a Rectangle (pen,x,y,width,height)
            g.DrawRectangle(mypen, 5, 5, 350, 200);

            //The Brush class can also be used to fill shapes with a solid color
            SolidBrush solidbrush = new SolidBrush(Color.Purple);
            g.FillRectangle(solidbrush, 150, 150, 20, 20);

            //Draw an ellipse 
            Pen newpen = new Pen(Color.DarkBlue, 5);
            g.DrawEllipse(newpen, 10, 10, 20, 30);

            //Draw a filled in ellipse (circle)
            g.FillEllipse(Brushes.ForestGreen, 40, 10, 20, 20);

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\sjbspring.jpg";

            Image image = Image.FromFile( f );
            g.DrawImage(image, 370, 5, 50, 50);                       
                        
            //Dispose all objects
            font.Dispose();
            brush.Dispose();
            pen.Dispose();
            mypen.Dispose();
            newpen.Dispose();
            solidbrush.Dispose();

        }

        
    }
}