using System;

namespace _05._Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double extraClothingPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double extrasTotalClothingPrice = extrasCount * extraClothingPrice;

            if (extrasCount > 150)
            {
                extrasTotalClothingPrice = extrasTotalClothingPrice - extrasTotalClothingPrice * 0.10;
            }

            if (decor + extrasTotalClothingPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {decor + extrasTotalClothingPrice - budget:F2} leva more.");
            }

            else 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - decor - extrasTotalClothingPrice:F2} leva left.");
            }
        }
    }
}
