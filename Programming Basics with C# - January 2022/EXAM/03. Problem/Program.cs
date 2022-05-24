using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string accomodation = Console.ReadLine();
            string assessment = Console.ReadLine();

            int stay = days - 1;
            double totalPrice = 0;

            if (accomodation == "room for one person")

            {
                totalPrice = 18.00 * stay;

            }

            else if (accomodation == "apartment")

            {
                totalPrice = 25.00 * stay;
                {
                    if (days < 10)
                    {
                        totalPrice *= 0.70;
                    }

                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice *= 0.65;
                    }

                    else
                    {
                        totalPrice *= 0.50;
                    }

                }
            }

            else
            {
                totalPrice = 35.00 * stay;
                {
                    if (days < 10)
                    {
                        totalPrice *= 0.90;
                    }

                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice *= 0.85;
                    }

                    else
                    {
                        totalPrice *= 0.80;

                    }
                }
            }

            if (assessment == "positive")

            {
                totalPrice *= 1.25;
            }

            else
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
