using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergentliters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double detergentPrice = detergentliters * 1.20;

            double sum = pensPrice + markersPrice + detergentPrice;
            double priceDiscount = sum * discount / 100;

            double finalPrice = sum - priceDiscount;

            Console.WriteLine(finalPrice);


        }
    }
}
