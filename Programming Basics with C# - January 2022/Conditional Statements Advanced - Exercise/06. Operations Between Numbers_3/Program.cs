using System;

namespace _06._Operations_Between_Numbers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double result = 0.0;

            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                string evenOrOdd = "odd";

                if (symbol == '+')
                {

                    result = N1 + N2;

                }

                else if (symbol == '-')
                {

                    result = N1 - N2;

                }

                else

                {
                    result = N1 * N2;

                }

                if (result % 2 == 0)

                {
                    evenOrOdd = "even";

                }

                Console.WriteLine($"{N1} {symbol} {N2} = {result} - {evenOrOdd}");
            }

            else
            {
                if (N2 == 0)
                {

                    Console.WriteLine($"Cannot divide {N1} by zero");

                }

                else if (symbol == '/')
                {
                    result =  (double)N1 / (double)N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {result:f2}");

                }

                else

                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {result}");

                }
            }


        }
     
    }

    }

            

