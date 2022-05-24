using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegeterianMenus = int.Parse(Console.ReadLine());
            double deliveryCost = 2.50;

            double chickenPrice = chickenMenus * 10.35;
            double fishPrice = fishMenus * 12.40;
            double vegeterianPrice = vegeterianMenus * 8.15;
            double dessertPrice = (chickenPrice + fishPrice + vegeterianPrice) * 0.20;

            double sum = chickenPrice + fishPrice + vegeterianPrice + dessertPrice + deliveryCost;
            Console.WriteLine(sum);
        }
    }
}
