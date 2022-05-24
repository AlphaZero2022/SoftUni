using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            double profit = (vegetablePrice * vegetablesKg + fruitPrice * fruitsKg) / 1.94;
            Console.WriteLine("{0:f2}", profit);
        }
    }
}
