using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle : AbstractFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public override double Area()
        {
            if (A + B <= C || A + C <= B || B + C <= A)
            {
                throw new Exception("This is not a triangle!");
            }

            if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
            {
                Console.WriteLine("This is right triangle!");
            }

            double semiPerimeter = (A + B + C) / 2.0;
            double square = Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));

            return square;
        }
    }
}
