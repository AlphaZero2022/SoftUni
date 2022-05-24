using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());
            double wage = 0;
            double moneyEarned = 0;

            if (kilometersPerMonth <= 5000)
            {
                if (season == "Summer")
                {
                    wage = 0.90;
                }

                else if (season == "Winter")
                {
                    wage = 1.05;
                }

                else
                {
                    wage = 0.75;
                }
            }

            else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
            {
                if (season == "Summer")
                {
                    wage = 1.10;
                }

                else if (season == "Winter")
                {
                    wage = 1.25;
                }

                else
                {
                    wage = 0.95;
                }
            }

            else
            {
                if (season == "Summer")
                {
                    wage = 1.45;
                }

                else if (season == "Winter")
                {
                    wage = 1.45;
                }

                else
                {
                    wage = 1.45;
                }
            }

            moneyEarned = 4 * kilometersPerMonth * wage * 0.90;
            Console.WriteLine("{0:f2}", moneyEarned);
        }
    }
}
