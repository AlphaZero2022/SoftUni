using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double flowerPrice = 0.0;
            
            if (typeOfFlower == "Roses")

            {
                flowerPrice = numberOfFlowers * 5;

                if (numberOfFlowers > 80)
                {
                    flowerPrice *= 0.90;
                }
            }


            else if (typeOfFlower == "Dahlias")

            {
                flowerPrice = numberOfFlowers * 3.80;

                if (numberOfFlowers > 90)
                {
                    flowerPrice *= 0.85;
                }

            }

            else if (typeOfFlower == "Tulips")
            {
                flowerPrice = numberOfFlowers * 2.80;

                if (numberOfFlowers > 80)
                {
                    flowerPrice *= 0.85;
                }
            }


            else if (typeOfFlower == "Narcissus")
            {
                flowerPrice = numberOfFlowers * 3;

                if (numberOfFlowers < 120)
                {
                    flowerPrice *= 1.15;
                }
            }

            else if (typeOfFlower == "Gladiolus")
            {
                flowerPrice = numberOfFlowers * 2.50;

                if (numberOfFlowers < 80)
                {
                    flowerPrice *= 1.20;
                }

            }

            if (budget >= flowerPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {(budget - flowerPrice):f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {(flowerPrice - budget):f2} leva more.");
            }
        }



    }
}
