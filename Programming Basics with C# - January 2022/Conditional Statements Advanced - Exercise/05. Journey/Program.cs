using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfVacation = "";

            switch (budget)

            {
                case <= 100:
                    destination = "Bulgaria";
                    

                    if (season == "summer")
                    {
                        budget *= 0.30;
                        typeOfVacation = "Camp";
                    }

                    else if (season == "winter")
                    {
                        budget *= 0.70;
                        typeOfVacation = "Hotel";
                    }    
                    break;
                case <= 1000:
                    destination = "Balkans";

                    if (season == "summer")
                    {
                        budget *= 0.40;
                        typeOfVacation = "Camp";
                    }

                    else if (season == "winter")
                    {
                        budget *= 0.80;
                        typeOfVacation = "Hotel";
                    }
                    break;

                case > 1000:
                    destination = "Europe";
                    budget *= 0.90;

                    if (season == "summer")
                    {
                        typeOfVacation = "Camp";
                    }

                    else if (season == "winter")
                    {
                        typeOfVacation = "Hotel";
                    }
                    break;
                    
                default:
                    break;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} – {budget:f2}");

        }

    }
}
