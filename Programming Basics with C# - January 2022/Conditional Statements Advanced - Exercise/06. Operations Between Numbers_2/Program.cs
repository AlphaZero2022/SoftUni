using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double result = 0.0;
            string evenOrodd = "odd";

            switch (symbol)

            {
                case '+':

                    result = N1 + N2;

                    if (result % 2 == 0)

                    {
                        evenOrodd = "even";
                    }

                    break;

                case '-':
                    result = N1 - N2;

                    if (result % 2 == 0)

                    {
                        evenOrodd = "even";
                    }

                    break;

                case '*':
                    result = N1 * N2;

                    if (result % 2 == 0)

                    {
                        evenOrodd = "even";
                    }

                    break;

                case '/':

                    if (N2 == 0)

                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }

                    else
                    {
                        result = (double)N1 / (double)N2;
                    }

                    break;

                case '%':

                    if (N2 == 0)

                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }

                    else
                    {
                        result = N1 % N2;
                        
                    }

                    break;

                default:
                    break;

            }

            switch (symbol)
            {
                case '+':
                case '-':
                case '*':
                     Console.WriteLine($"{N1} {symbol} {N2} = {result} - {evenOrodd}");
                    break;

                case '/' :
                case '%':
                    Console.WriteLine($"{N1} {symbol} {N2} = {result}");
                    break;
                
            }
            
        }
    }
}
