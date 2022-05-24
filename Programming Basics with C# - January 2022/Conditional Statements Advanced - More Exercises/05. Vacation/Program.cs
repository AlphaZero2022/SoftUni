using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accommodation = "";
            string location = "";

            if (budget <= 1000)
            {
                accommodation = "Camp";

                if (season == "Summer")
                {
                    budget *= 0.65;
                    location = "Alaska";
                }

                else
                {
                    budget *= 0.45;
                    location = "Morocco";
                }

            }

            else if (budget > 1000 && budget <= 3000)
            {
                accommodation = "Hut";

                if (season == "Summer")
                {
                    budget *= 0.80;
                    location = "Alaska";
                }

                else
                {
                    budget *= 0.60;
                    location = "Morocco";
                }
            }

            else
            {
                accommodation = "Hotel";


                if (season == "Summer")
                {
                    budget *= 0.90;
                    location = "Alaska";
                }

                else
                {
                    budget *= 0.90;
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {accommodation} - {budget:f2}");
        }
    }
}
