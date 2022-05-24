using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapesPerSqMeter = double.Parse(Console.ReadLine());
            int requiredWine = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double grapesTotal = vineyard * grapesPerSqMeter;
            double wine = 0.40 * grapesTotal / 2.5;
            double difference = requiredWine - wine;
            double winePerWorker = Math.Abs(difference) / numberOfWorkers;

            if (wine < requiredWine) 
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }

            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine-requiredWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }
        }
    }
}
