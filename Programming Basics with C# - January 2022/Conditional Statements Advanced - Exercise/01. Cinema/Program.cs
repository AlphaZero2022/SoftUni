using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Premiere")
            {
                price = 12.00;
            }

            else if (type == "Normal")
            {
                price = 7.50;
            }

            else
            {
                price = 5.00;
            }

            double income = r * c * price;

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
