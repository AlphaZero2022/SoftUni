using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double requiredMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCount = 0;
            int daysSpending = 0;

            while (availableMoney < requiredMoney)
            {
                
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCount++;

                if (input == "save")
                {
                    availableMoney += money;
                    daysSpending = 0;
                }

                else
                {
                    availableMoney -= money;
                    daysSpending++;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                    if (daysSpending >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount++);
                        break;
                    }    
                }
            }

            if (availableMoney >=requiredMoney )
            {
                Console.WriteLine($"You saved the money for {daysCount++} days.");
            }    
        }
    }
}
