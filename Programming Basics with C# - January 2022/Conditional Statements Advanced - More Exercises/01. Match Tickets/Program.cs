using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string price = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            

            if (people >= 1 && people <= 4)
            {
                budget *= 0.25;

                if (price == "VIP")
                {
                    ticketPrice = people * 499.99;
                }

                else 
                {
                    ticketPrice = people * 249.99;
                }
            }

            else if (people >= 5 && people <= 9)
            {
                budget *= 0.40;

                if (price == "VIP")
                {
                    ticketPrice = people * 499.99;
                }

                else
                {
                    ticketPrice = people * 249.99;
                }
            }

            else if (people >= 10 && people <= 24)
            {
                budget *= 0.50;

                if (price == "VIP")
                {
                    ticketPrice = people * 499.99;
                }

                else
                {
                    ticketPrice = people * 249.99;
                }
            }

            else if (people >= 25 && people <= 49)
            {
                budget *= 0.60;

                if (price == "VIP")
                {
                    ticketPrice = people * 499.99;
                }

                else
                {
                    ticketPrice = people * 249.99;
                }

            }

            else if (people >= 50)
            {
                budget *= 0.75;

                if (price == "VIP")
                {
                    ticketPrice = people * 499.99;
                }

                else
                {
                    ticketPrice = people * 249.99;
                }
            }

            if (budget >= ticketPrice)
            {
                Console.WriteLine($"Yes! You have {budget-ticketPrice:f2} leva left.");
            }

            else

            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(ticketPrice-budget):f2} leva.");
            }
        }
    }
}
