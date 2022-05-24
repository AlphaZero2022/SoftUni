using System;

namespace _02._Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;


            }
        }
    }
}
