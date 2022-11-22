using System;

namespace Figures
{
    public class Triangle
    {
        double x, y, z;
        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool IsTriangleRectangular()
        {
            if(Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2))
            {
                return true;
            }

            return false;
        }
        public double GetTriangleArea()
        {
            double p = (x + y + z) / 2;

            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            return S;
        }
    }
}
