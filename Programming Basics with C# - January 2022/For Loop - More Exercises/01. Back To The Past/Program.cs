using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int yearsLeft = year - 1800;
            double moneySpent = 0;
            

            for (int i = 0; i <= yearsLeft; i++)
            {
                if (i%2 == 0)
                {
                    moneySpent = 12000;
                }

                else
                
                {
                    moneySpent = 12000 + 50 * (18 + i);
                }

                inheritance -= moneySpent;
            }

            if (inheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:f2} dollars left.");
            }

            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritance):f2} dollars to survive.");
            }
        }
    }
}
