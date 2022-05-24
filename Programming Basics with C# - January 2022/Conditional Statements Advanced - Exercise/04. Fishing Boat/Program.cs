using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double money = 0;

            switch (season)
            {
                case "Spring":

                    if (fishermen <= 6)
                    {
                        money = 3000 * 0.90;
                    }

                    else if (fishermen <= 11)
                    {
                        money = 3000 * 0.85;
                    }

                    else 
                    {
                        money = 3000 * 0.75;
                    }    


                    break;
                case "Summer":
                case "Autumn":

                    if (fishermen <= 6)
                    {
                        money = 4200 * 0.90;
                    }

                    else if ( fishermen <= 11)
                    {
                        money = 4200 * 0.85;
                    }

                    else  
                    {
                        money = 4200 * 0.75;
                    }
                    break;

                case "Winter":
                    if (fishermen <= 6)
                    {
                        money = 2600 * 0.90;
                    }

                    else if (fishermen <= 11)
                    {
                        money = 2600 * 0.85;
                    }

                    else
                    {
                        money = 2600 * 0.75;
                    }
                    break;
                    
                default:
                    break;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                money *= 0.95;
            }

            if (budget >= money)

            {
                Console.WriteLine($"Yes! You have {(budget - money):f2} leva left.");
            }

            else if (money > budget)

            {
                Console.WriteLine($"Not enough money! You need {(money - budget):f2} leva.");
            }
        }

    }
}
