using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string discount = Console.ReadLine();
            double price = 0;

            if (fuelType == "Gas")
            {
                price = 0.93 * liters;

                if (discount == "Yes")
                {
                    price -= 0.08 * liters;
                }

            }

            else if (fuelType == "Gasoline")
            {
                price = 2.22 * liters;

                if (discount == "Yes")
                {
                    price -= 0.18 * liters;
                }
            }

            else if (fuelType == "Diesel")
            {
                price = 2.33 * liters;

                if (discount == "Yes")
                {
                    price -= 0.12 * liters;
                }
            }

            if (liters >= 20 && liters <= 25)
            {
                price *= 0.92;
            }

            else if (liters > 25)
            {
                price *= 0.90;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
