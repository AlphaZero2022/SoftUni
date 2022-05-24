using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double microbusPrice = 0;
            double microbusTonage = 0;
            double truckPrice = 0;
            double truckTonage = 0;
            double trainPrice = 0;
            double trainTonage = 0;
           

            for (int i = 1; i <= number; i++)
            {
                int cargoTonage = int.Parse(Console.ReadLine());

                if (cargoTonage <= 3)
                {
                    
                    microbusTonage += cargoTonage;
                }

                else if (cargoTonage >= 4 && cargoTonage <=11)
                {
                    
                    truckTonage += cargoTonage;
                }

                else
                {
                   
                    trainTonage += cargoTonage;
                }
  
            }
            
            microbusPrice = microbusTonage * 200;
            truckPrice = truckTonage * 175;
            trainPrice = trainTonage * 120;
            double allTonage = microbusTonage + truckTonage + trainTonage;
            
            double percentMicrobus = microbusTonage / allTonage*100;
            double percentTruck = truckTonage / allTonage*100;
            double percentTrain = trainTonage / allTonage*100;

            double averagePrice = (microbusPrice + truckPrice + trainPrice) / allTonage;
            Console.WriteLine("{0:f2}", averagePrice);
            Console.WriteLine($"{percentMicrobus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");

        }
    }
}
