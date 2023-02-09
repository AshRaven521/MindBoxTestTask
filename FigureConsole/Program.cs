using System;
using FigureLibrary;

namespace FigureConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle
            {
                Radius = 5.0
            };
            Console.WriteLine($"Circle {circle} has area: {circle.Area()}");

            Triangle triangle = new Triangle
            {
                A = 60.0,
                B = 91.0,
                C = 109.0
            };

            Console.WriteLine($"Triangle {triangle} has area: {triangle.Area()}");

            Triangle wrongTriangle = new Triangle
            {
                A = 10.0,
                B = 20.0,
                C = 40.0
            };

            wrongTriangle.Area();
        }
    }
}
