using App_Figures.Impl;

namespace App_Figures.Model
{
    public class Rectangle : IFigure
    {
        private double B { get; set; }
        private double H { get; set; }

        public Rectangle()
        {            
        }

        public Rectangle(double b, double h)
        {
            this.B = b;
            this.H = h;
        }

        public double Area()
        {
            return B * H;
        }

        public double Perimeter()
        {
            return 2 * (B + H);
        }

        public override string ToString()
        {
            return "\n\t\tArea: " + Area().ToString("F2") + " | Perimeter: " + Perimeter().ToString("F2");
        }
    }
}
