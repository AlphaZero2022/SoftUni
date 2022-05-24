using System;

namespace Odd_or_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = number % 2;

            if (result == 0)
            {
                Console.WriteLine("even");

            }
            else 
            {
                Console.WriteLine("odd");
            }
        }

    }
}
