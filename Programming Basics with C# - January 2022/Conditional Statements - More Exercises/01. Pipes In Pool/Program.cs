using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int pipe1DebitPerHour = int.Parse(Console.ReadLine());
            int pipe2DebitPerHour = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1 = hours * pipe1DebitPerHour;
            double pipe2 = hours * pipe2DebitPerHour;
            double allWater = pipe1 + pipe2;
            double pipe1Percent = pipe1 / allWater * 100;
            double pipe2Percent = pipe2 / allWater * 100;
            double allWaterPerCent = allWater / v*100;
            double overflow = allWater - v;

            if (allWater <= v)
            {
                Console.WriteLine($"The pool is {allWaterPerCent:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }

            else
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");   
            }
        }
    }
}
