using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int teddybearCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double totalPrice = puzzleCount * 2.60 + dollsCount * 3 + teddybearCount * 4.10 + minionsCount * 8.20 + trucksCount * 2;
            int totalQuantity = puzzleCount + dollsCount + teddybearCount + minionsCount + trucksCount;

            if (totalQuantity >= 50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            totalPrice = totalPrice - (totalPrice * 0.1);

            if (totalPrice >= trip)
            {
                Console.WriteLine($"Yes! {totalPrice - trip:F2} lv left.");
            }

            else if (trip > totalPrice)
            {
                Console.WriteLine($"Not enough money! {trip - totalPrice:F2} lv needed.");
            }
        }
    }
}
