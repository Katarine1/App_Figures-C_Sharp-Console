using System;
using App_Figures.Impl;

namespace App_Figures.Model
{
    public class Circle : IFigure
    {
        private double Radius { get; set; }

        public Circle()
        {           
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return "\n\t\tArea: " + Area().ToString("F2") + " | Perimeter: " + Perimeter().ToString("F2");
        }
    }
}
