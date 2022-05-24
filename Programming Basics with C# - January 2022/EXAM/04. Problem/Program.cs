using System;

namespace _04._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allRakia = 0;
            double allDegrees = 0;

            for (int i = 1; i <= days; i++)
            {
                double rakiaPerDay = double.Parse(Console.ReadLine());
                double degreesPerDay = double.Parse(Console.ReadLine());

                allRakia += rakiaPerDay;
                allDegrees += degreesPerDay* rakiaPerDay;

            }

            double averageDegrees = allDegrees / allRakia*1.0;

            Console.WriteLine($"Liter: {allRakia:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");

            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }

            else if (averageDegrees >= 38 && averageDegrees <=42)
            {
                Console.WriteLine("Super!");
            }

            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
            
        }
    }
}
