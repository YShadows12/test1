namespace TEST1
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = x * x + y * y;
            double length = System.Math.Sqrt(aux);
            return length;

        }
        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux = x * x + y * y + z * z;
            double length = System.Math.Sqrt(aux);
            return length;
        }
    }
}
