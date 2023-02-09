using System;

namespace FigureLibrary
{
    public class Circle : AbstractFigure
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"( {Radius} )";
        }
    }
}
