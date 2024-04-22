using System;
using System.ComponentModel.DataAnnotations;

namespace CalculateArea
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
