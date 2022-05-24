using System;

namespace ConcatenateData2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {surname}, a {age}-years old person from {city}.");
        }
    }
}
