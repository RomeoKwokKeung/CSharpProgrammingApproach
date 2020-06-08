using System;
using System.Collections.Generic;
using System.Text;

namespace DartBoard
{
    class Rand
    {
        private static double j;
        private static double m;
        private static double l;         
        
        public Rand()
        {
        
        }

        public static void Init(double ij, double im,double il)
        {
            j = ij;
            m = im;
            l = il;
        }

        public static double RandomUniform()
        {
            l = j * l - m * (int) (j * l / m);
            return l / m;            
        }


    }
}
