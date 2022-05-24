using System;

namespace Homework_08._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeteres = double.Parse(Console.ReadLine());
            double inches = centimeteres * 2.54;
            Console.WriteLine(inches);
        }
    }
}
