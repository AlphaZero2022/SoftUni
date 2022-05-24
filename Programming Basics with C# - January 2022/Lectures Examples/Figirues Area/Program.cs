using System;

namespace Figirues_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(area);
            }

            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(area);

            }
        }
    }
}
