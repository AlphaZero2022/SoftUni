using System;

namespace _01._Sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third;
            int minutes = time / 60;
            int seconds = time % 60; 

            if (seconds<10)
            {
                Console.WriteLine(($"{minutes}:0{seconds}"));
            }    
            
            else
            {
                Console.WriteLine(($"{minutes}:{seconds}"));
            }
        }
    }
}
