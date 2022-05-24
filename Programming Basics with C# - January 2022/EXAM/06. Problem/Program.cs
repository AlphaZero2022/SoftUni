using System;

namespace _06._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            for (int a = 2; a <= num1; a += 2)
            {
                for (int b = 2; b <= num2; b++)
                {
                    for (int c = 2; c <= num3; c += 2)
                    {
                        if (b == 2 || b == 3 || b == 5 || b == 7)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }

                    }
                }

            }
        }
    }
}

