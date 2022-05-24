using System;

namespace Everest
{
    class Everest
    {
        static void Main(string[] args)
        {
            string input = "";
            int distance = 5364;
            int meters = 0;
            int days = 1;

            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "Yes")
                {
                    days++;
                    meters = int.Parse(Console.ReadLine());
                    distance += meters;
                }
                else if (input == "No")
                {
                    meters = int.Parse(Console.ReadLine());
                    distance += meters;
                }
                if (days > 5) break;
                if (distance >= 8848) break;
            }
            if (distance >= 8848 && days <= 5)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(distance);
            }
        }
    }
}