using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    class Food
    {
        //Variable Dictionary:
        //x, y: location of food
        //height, width: height and width of food
        //foodRec: properties of food, drawing it

        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;

        public Food(Random randFood)
        {
            //change location of food to random spots
            x = randFood.Next(0, 29) * 9;
            y = randFood.Next(0, 29) * 9;

            brush = new SolidBrush(Color.Red);

            //height and width of food
            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);
        }

        public void foodLocation(Random randFood)
        {
            //change location of food to random spots
            x = randFood.Next(0, 29) * 9;
            y = randFood.Next(0, 29) * 9;
        }

        public void drawFood(Graphics g)
        {
            //draw food, position x and y
            foodRec.X = x;
            foodRec.Y = y;
            g.FillRectangle(brush, foodRec);
        }
    }
}
