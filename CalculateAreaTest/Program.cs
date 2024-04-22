using System;
using CalculateArea;
namespace CalculateAreaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //triangle test
            IShape shape = Triangle.CreateTriangle(1, 2, 3);
            Console.WriteLine("Is triangle correct:" + (shape != null));

            shape = Triangle.CreateTriangle(3, 4, 5);
            Console.WriteLine("Is triangle correct:" + (shape != null));

            var res = Calculate.GetArea(shape);
            Console.WriteLine("Triangle area:" + res);

            bool isRightTriangle = (shape as Triangle).IsRightTriangle();
            Console.WriteLine("Is triangle right:" + isRightTriangle);

            //circle test
            shape = new Circle(10);
            res = Calculate.GetArea(shape);
            Console.WriteLine("Circle area:" + res);
        }
    }
}
