using System;
using System.Collections.Generic;
using System.Text;

namespace BoxExample
{
    class Box
    {

        //fields
        private double length;
        private double wid;
        private double heigh;

        public double Length
        {
            get{ return length;}
            set{ length=value;}
        }

        public double Wid
        {
            get { return wid; }
            set { wid = value; }
        }

        public double Heigh
        {
            get { return heigh; }
            set { heigh = value; }
        }


        //constructors
        public Box(double w, double h, double l)
        {
            wid = w;
            heigh = h;
            length = l;
        }

        public Box(double side)
        {
            wid = side;
            heigh = side;
            length = side;
        }

        //methods
        public double volume()
        {
            return wid * heigh * length;
        }

        public double area()
        {
            return 2 * (wid * heigh + wid * length + heigh * length);
        }


    }
}
