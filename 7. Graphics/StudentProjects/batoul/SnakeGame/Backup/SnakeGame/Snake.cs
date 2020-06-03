using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SnakeGame
{
    public class Snake
    {
        //Variable Dictionary:
        //snakeRec: properties of snake, drawing it
        //x, y: location of snake
        //height, width: height and width of snake

        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }

        public Snake()
        {
            snakeRec = new Rectangle[3];

            brush = new SolidBrush(Color.Brown);

            //starting position, width and height
            //of snake
            x = 20;
            y = 20;
            width = 10;
            height = 10;

            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        public void drawSnake(Graphics g)
        {
            foreach (Rectangle rec in snakeRec)
            {
                g.FillRectangle(brush, rec);
            }
        }

        public void drawSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        public void moveDown()
        {
            //moves 10 down
            drawSnake();
            snakeRec[0].Y += 10;
        }
        public void moveUp()
        {
            //mover 10 up
            drawSnake();
            snakeRec[0].Y -= 10;
        }
        public void moveRight()
        {
            //moves 10 right
            drawSnake();
            snakeRec[0].X += 10;
        }
        public void moveLeft()
        {
            //moves 10 left
            drawSnake();
            snakeRec[0].X -= 10;
        }

        public void growSnake()
        {
            //another form of array, so that the snake is constantly
            //getting longer and longer
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }
    }
}
