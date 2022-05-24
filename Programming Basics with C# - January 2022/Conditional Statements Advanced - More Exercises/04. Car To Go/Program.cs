using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string type = "";
            
            if (budget <= 100)
            {
                Console.WriteLine("Economy class");

                if (season == "Summer")
                {
                    budget *= 0.35;
                    type = "Cabrio";
                }

                else
                {
                    budget *= 0.65;
                    type = "Jeep";
                }

            }
            
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");

                if (season == "Summer")
                {
                    budget *= 0.45;
                    type = "Cabrio";
                }

                else
                {
                    budget *= 0.80;
                    type = "Jeep";
                }
            }

            else
            {
                Console.WriteLine("Luxury class");


                if (season == "Summer")
                {
                    budget *= 0.90;
                    type = "Jeep";
                }

                else
                {
                    budget *= 0.90;
                    type = "Jeep";
                }
            }

            Console.WriteLine($"{type} - {budget:f2}");
        }
    }
}
