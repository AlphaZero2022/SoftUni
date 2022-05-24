using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double mPrice = m * 3.25;
            double zPrice = z * 4.0;
            double rPrice = r * 3.50;
            double cPrice = c * 8;
            double money = (mPrice + zPrice + rPrice + cPrice) * 0.95;

            if (money >= gift)
            {
                Console.WriteLine($"She is left with {Math.Floor(money-gift)} leva.");
            }

            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift-money)} leva.");
            }
        }
    }
}
