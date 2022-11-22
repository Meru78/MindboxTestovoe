using System;

namespace Figures
{
    public class Circle
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetСircleArea()
        {
            double S = Math.PI * Math.Pow(this.radius, 2);
            return S;
        }
    }
}
