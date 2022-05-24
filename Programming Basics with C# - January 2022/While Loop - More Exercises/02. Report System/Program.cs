using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyRequired = int.Parse(Console.ReadLine());
            string productPrice = Console.ReadLine();
            double cashPayments = 0;
            int cashPaymentsCount = 0;
            double CreditCardPayments = 0;
            int CreditCardPaymentsCount = 0;
            double moneyCollected = 0;
            int counter = 0;
            int payment = 0;

            while (productPrice != "End")
            {
                counter++;
                payment = int.Parse(productPrice);

                if (counter % 2 != 0) //в брой
                {
                    if (payment > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                    else
                    {
                        cashPayments += payment;
                        cashPaymentsCount++;
                        Console.WriteLine("Product sold!");
                    }
                }

                else //с кредитна карта
                {
                    if (payment < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                    else
                    {
                        CreditCardPayments += payment;
                        CreditCardPaymentsCount++;
                        Console.WriteLine("Product sold!");
                    }

                    moneyCollected = cashPayments + CreditCardPayments;
                
                if (moneyCollected >= moneyRequired)
                    {
                        Console.WriteLine($"Average CS: {cashPayments/cashPaymentsCount:f2}");
                        Console.WriteLine($"Average CC: {CreditCardPayments/ CreditCardPaymentsCount:f2}");

                        break;
                    }

                }

                productPrice = Console.ReadLine();

            }
            
            if (moneyCollected < moneyRequired)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
