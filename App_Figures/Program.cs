using System;
using System.Globalization;
using App_Figures.Model;

namespace App_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("\t\t# --- Figures --- #\n");

                Console.Write("\t\tEnter Quantity: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("\t\tNumber " + (i + 1) + ":\n");

                    Console.WriteLine("\t\tS - Square");
                    Console.WriteLine("\t\tR - Rectangle");
                    Console.WriteLine("\t\tC - Circle\n");

                    Console.Write("\t\tEnter Letter: ");
                    char letter = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (letter == 'S' || letter == 's')
                    {
                        Console.Write("\t\tEnter the value of the hand: ");
                        string side = Console.ReadLine();
                        double L = double.Parse(side, CultureInfo.InvariantCulture);

                        Square s = new Square(L);
                        s.Area();
                        s.Perimeter();
                        Console.WriteLine(s);
                        Console.WriteLine("\n\n\t\t-------------------------------\n\n");
                    }
                    else if (letter == 'R' || letter == 'r')
                    {
                        Console.Write("\t\tEnter the base value: ");
                        string bases = Console.ReadLine();
                        double B = double.Parse(bases, CultureInfo.InvariantCulture);

                        Console.Write("\t\tEnter the height value: ");
                        string height = Console.ReadLine();
                        double H = double.Parse(height, CultureInfo.InvariantCulture);

                        Rectangle r = new Rectangle(B, H);
                        r.Area();
                        r.Perimeter();
                        Console.WriteLine(r);
                        Console.WriteLine("\n\n\t\t-------------------------------\n\n");
                    }
                    else if (letter == 'C' || letter == 'c')
                    {
                        Console.Write("\t\tEnter the value of the Radius: ");
                        string r = Console.ReadLine();
                        double radius = double.Parse(r, CultureInfo.InvariantCulture);

                        Circle c = new Circle(radius);
                        c.Area();
                        c.Perimeter();
                        Console.WriteLine(c);
                        Console.WriteLine("\n\n\t\t-------------------------------\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\t\tEnter a valid letter.\n\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n\t\tError: " + e.Message + "\n\n");
            }                    
        }
    }
}
