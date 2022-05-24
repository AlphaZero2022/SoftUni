using System;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            double firstFood = first * days;
            double secondFood = second * days;
            double thirdFood = third * days;
            double allFoodRequired = firstFood + secondFood + thirdFood;
            double difference = Math.Abs(food - allFoodRequired);

            if (food >= allFoodRequired)
            {
                Console.WriteLine($"{Math.Floor (difference)} kilos of food left.");
            }

            else
            {
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
                
            }
        }
    }
}
