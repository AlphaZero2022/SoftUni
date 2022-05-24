using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemum = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double chrysanthemumPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            int allFlowers = chrysanthemum + roses + tulips;
            double priceOfAllFlowers = 0;

            if (season == "Spring" || season == "Summer")
            {
                
                chrysanthemumPrice = chrysanthemum * 2.00;
                rosesPrice = roses * 4.10;
                tulipsPrice = tulips * 2.50;
                priceOfAllFlowers = (chrysanthemumPrice + rosesPrice + tulipsPrice);

                if (holiday == "Y")
                {
                    priceOfAllFlowers *=1.15;
                    
                }

                    if (season == "Spring" && tulips > 7)
                    {
                    priceOfAllFlowers *= 0.95;
                    }

                        if (allFlowers > 20)
                        {
                        priceOfAllFlowers *= 0.80;
                        
                        }
            }

            else
            {
                chrysanthemumPrice = chrysanthemum * 3.75;
                rosesPrice = roses * 4.50;
                tulipsPrice = tulips * 4.15;
                priceOfAllFlowers = (chrysanthemumPrice + rosesPrice + tulipsPrice);

                if (holiday == "Y")
                {
                    priceOfAllFlowers *= 1.15;
                }

                    if (season == "Winter" && roses >= 10)
                    {
                        priceOfAllFlowers *= 0.90;
                    }

                        if (allFlowers > 20)
                        {
                        priceOfAllFlowers *= 0.80;
                        }
            }

            priceOfAllFlowers += 2;
            Console.WriteLine("{0:f2}", priceOfAllFlowers);


        }


        
    }
}
