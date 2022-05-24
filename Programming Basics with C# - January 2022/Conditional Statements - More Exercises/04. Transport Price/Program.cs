using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double dailyTaxiPrice = 0.70 + 0.79 * n;
            double nightTaxiPrice = 0.70 + 0.90 * n;
            double busPrice = 0.09 * n;
            double trainPrice = 0.06 * n;

            if (n < 20)
            {
                if (input == "day")
                {
                    Console.WriteLine($"{dailyTaxiPrice:f2}");
                }

                else
                {
                    Console.WriteLine($"{nightTaxiPrice:f2}");
                }
            }

            else if (n>=20 && n < 100)
            {
                Console.WriteLine($"{busPrice:f2}");
            }

            else
            {
                Console.WriteLine($"{trainPrice:f2}");
            }
        }
    }
}
