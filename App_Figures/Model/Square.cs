using App_Figures.Impl;

namespace App_Figures.Model
{
    public class Square : IFigure
    {
        private double L { get; set; }

        public Square()
        {           
        }
        public Square(double l)
        {
            this.L = l;
        }

        public double Area()
        {
            return L * L;
        }

        public double Perimeter()
        {
            return 4 * L;
        }

        public override string ToString()
        {
            return "\n\t\tArea: " + Area().ToString("F2") + " | Perimeter: " + Perimeter().ToString("F2");
        }
    }
}
