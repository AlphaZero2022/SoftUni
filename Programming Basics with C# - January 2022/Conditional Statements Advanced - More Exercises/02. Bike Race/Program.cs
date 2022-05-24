using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string race = Console.ReadLine();
            double juniorsMoney = 0;
            double seniorsMoney = 0;

            if (race == "trail")
            {
                juniorsMoney = juniors * 5.50;
                seniorsMoney = seniors * 7.0;

            }

            else if (race == "cross-country")
            {
                juniorsMoney = juniors * 8.0;
                seniorsMoney = seniors * 9.50;

                if (juniors + seniors >= 50)
                {
                    juniorsMoney = juniors * 8.0 * 0.75;
                    seniorsMoney = seniors * 9.50 * 0.75;
                }
            }

            else if (race == "downhill")
            {
                juniorsMoney = juniors * 12.25;
                seniorsMoney = seniors * 13.75;
               
            }

            else
            {
                juniorsMoney = juniors * 20.0;
                seniorsMoney = seniors * 21.50;

            }

            double sum = (juniorsMoney + seniorsMoney) * 0.95;
            Console.WriteLine("{0:f2}", sum);     
        }
    }
}
