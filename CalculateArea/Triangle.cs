using System;

namespace CalculateArea
{
    public class Triangle : IShape
    {
        private double[] sides;
        private Triangle(double side1, double side2, double side3)
        {
            sides = new double[3] { side1, side2, side3 };
            Array.Sort(sides);
        }

        public static Triangle CreateTriangle(double side1, double side2, double side3)
        {
            var arr = new double[3] { side1, side2, side3 };
            Array.Sort(arr);
            if (arr[0] <= 0 || arr[0] + arr[1] <= arr[2])
                return null;

            return new Triangle(side1, side2, side3);
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public double GetArea()
        {
            var p = (double)(sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }
    }
}
