﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle : AbstractFigure
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
