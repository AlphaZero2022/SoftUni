using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double change = 100*double.Parse(Console.ReadLine());

            while (change > 0)
            {
                if (change >= 200)
                {
                    change -= 200;
                    count++;
                }

                else if (change >= 100)
                {
                    change -= 100;
                    count++;
                }

                else if (change >= 50)
                {
                    change -= 50;
                    count++;
                }

                else if (change >= 20)
                {
                    change -= 20;
                    count++;
                }

                else if (change >= 10)
                {
                    change -= 10;
                    count++;
                }

                else if (change >= 5)
                {
                    change -= 5;
                    count++;
                }

                else if (change >= 2)
                {
                    change -= 2;
                    count++;
                }

                else if (change >=1)
                {
                    change -= 1;
                    count++;
                }

                else
                {
                    change = 0;
                }

            }

            Console.WriteLine(count);

        }
    }
}
