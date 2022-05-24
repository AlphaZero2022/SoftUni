using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontAndBackSide = (x * x * 2) + (x * y * 2) - (1.2 * 2) - (2 * 1.5 * 1.5);
            double roof = (2 * x * y) + (x * h);

            double greenPaintRequired = frontAndBackSide/3.4;
            double redPaintRequired = roof/4.3;

            Console.WriteLine($"{ greenPaintRequired:f2}");
            Console.WriteLine($"{ redPaintRequired:f2}");
        }
    }
}
