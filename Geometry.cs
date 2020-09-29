using System;
using System.Collections.Generic;
using System.Text;

namespace TEST1
{
    class Geometry2d
    {
        public static double GetVectorLength(double x, double y)
        {
            double aux;
            double length;
            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length;

        }
    }
}
