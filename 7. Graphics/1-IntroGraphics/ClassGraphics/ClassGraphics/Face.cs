using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;   //necessary for graphics

namespace ClassGraphics
{
    class Face
    {

        private int x;
        private int y;
        private Color faceCol;
        private Color smilCol;

        public Face(int xPos, int yPos, Color faceColor,Color smileColor)
        {
            x = xPos;
            y = yPos;
            faceCol = faceColor;
            smilCol = smileColor;        
        }

        //Properties to modify display locations and colors

        public Color FaceColor
        {
            get { return faceCol; }
            set { faceCol = value; }

        }

        public Color SmileColor
        {
            get { return smilCol; }
            set { smilCol = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Paint(Graphics gr)
        {
            SolidBrush yBrush = new SolidBrush(faceCol);
            SolidBrush bBrush = new SolidBrush(smilCol);
            Pen bPen = new Pen(smilCol, 2);

            gr.FillEllipse(yBrush, x, y, 80, 80);           //head
            gr.DrawEllipse(bPen, x + 20, y + 30, 15, 7);    //eyes
            gr.DrawEllipse(bPen, x + 45, y + 30, 15, 7);
            gr.FillEllipse(bBrush, x + 25, y + 31, 5, 5);   //pupils
            gr.FillEllipse(bBrush, x + 50, y + 31, 5, 5);
            gr.DrawArc(bPen, x + 20, y + 50, 40, 15, 0, 180);//mouth
        }

    }
}
