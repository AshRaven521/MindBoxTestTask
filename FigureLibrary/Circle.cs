using System;

namespace FigureLibrary
{
    public class Circle : AbstractFigure
    {
        public double Radius { get; set; }
        public override double Area()
        {
            if (Radius < 0)
            {
                throw new Exception("Radius can not be less than 0!");
            }
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"( {Radius} )";
        }
    }
}
