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
            Console.WriteLine($"Circle area: {circle.Area()}");

            Triangle triangle = new Triangle
            {
                A = 60.0,
                B = 91.0,
                C = 109.0
            };

            Console.WriteLine($"Triangle area: {triangle.Area()}");
        }
    }
}
