using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videocardsPrice = videocards * 250;
            double processorsPricePerUnit = videocardsPrice * 0.35;
            double processorsPriceTotal = processorsPricePerUnit * processors;
            double ramPricePerUnit = videocardsPrice * 0.10;
            double ramPriceTotal = ramPricePerUnit * ram;

            double totalPrice = videocardsPrice + processorsPriceTotal + ramPriceTotal;

            if (videocards > processors)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }    

            if (budget >= totalPrice)

            {
                Console.WriteLine ($"You have {budget - totalPrice:F2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need { totalPrice - budget:F2} leva more!");
            }


        }
    }
}
