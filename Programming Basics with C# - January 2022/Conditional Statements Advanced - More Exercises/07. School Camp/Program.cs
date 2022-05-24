using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int groupSize = int.Parse(Console.ReadLine());
            int daysStay = int.Parse(Console.ReadLine());
            string sportType = "";
            double price = 0;

            if (season == "Winter")
            {
                if (groupType == "mixed")
                {
                    price = 10.00;
                    sportType = "Ski";
                }

                else if (groupType == "boys")
                {
                    price = 9.60;
                    sportType = "Judo";
                }

                else
                {
                    price = 9.60;
                    sportType = "Gymnastics";
                }
            }

            else if (season == "Spring")
            {
                if (groupType == "mixed")
                {
                    price = 9.50;
                    sportType = "Cycling";
                }

                else if (groupType == "boys")
                {
                    price = 7.20;
                    sportType = "Tennis";
                }

                else
                {
                    price = 7.20;
                    sportType = "Athletics";
                }
            }

            else
            {
                if (groupType == "mixed")
                {
                    price = 20.00;
                    sportType = "Swimming";
                }

                else if (groupType == "boys")
                {
                    price = 15.00;
                    sportType = "Football";
                }

                else
                {
                    price = 15.00;
                    sportType = "Volleyball";
                }
            }

            price = price * daysStay* groupSize;

            if (groupSize >=10 && groupSize<20)
            {
                price *= 0.95;
            }

            else if (groupSize >= 20 && groupSize < 50)
            {
                price *= 0.85;
            }

            else if (groupSize >= 50)
            {
                price *= 0.50;
            }

            else //трябва да се съобрази, че при група по-малка от 10 няма отстъпка;
            {

            }

            Console.WriteLine($"{sportType} {price:f2} lv.");
        }
    }
}
