using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            
            if (month == "May" || month == "October")

            {

                priceStudio = 50 * days;
                priceApartment = 65 * days;

                if (days > 7 && days <=14)

                {
                    priceStudio *= 0.95;
                }

                else if (days > 14)

                {
                    priceStudio *= 0.70;
                    priceApartment *= 0.90;
                }

            }

            else if (month == "June" || month == "September")

            {

                priceStudio = 75.20 * days;
                priceApartment = 68.70 * days;

                if (days > 14)

                {
                    priceStudio *= 0.80;
                    priceApartment *= 0.90;
                }

            }

            else 

            {

                priceStudio = 76 * days;
                priceApartment = 77 * days;

                if (days > 14)

                {
                    priceApartment *= 0.90;
                }

            }

            Console.WriteLine($"Apartment: {priceApartment:f2} lv.\nStudio: {priceStudio:f2} lv.");

               


            }
        }
    }
