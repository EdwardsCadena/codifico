using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    class Shape
    {
        private int ya;
        private int xa;
        public Shape(int x, int y)
        {
            xa = x;
            ya = y ;
        }

        public double area()
        {
            double result;
            result = xa * ya;
            return result;
        }
    }
}
