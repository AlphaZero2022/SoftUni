using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (n != "Stop")

            {
                int number = int.Parse(n);
                if (number < minNumber)
                {
                    minNumber = number;
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
