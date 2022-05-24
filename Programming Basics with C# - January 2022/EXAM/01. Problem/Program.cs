using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentFat = int.Parse(Console.ReadLine());
            int percentProteins = int.Parse(Console.ReadLine());
            int percentCarbohydrates = int.Parse(Console.ReadLine());
            int callories = int.Parse(Console.ReadLine());
            int percentWater = int.Parse(Console.ReadLine());

            double gramsFat = (percentFat * 1.0* callories / 100) / 9;
            double gramsProteins = (percentProteins * 1.0  * callories / 100) / 4;
            double gramsCarbohydrates = (percentCarbohydrates * 1.0  * callories / 100) / 4;

            double allFoodInGrams = gramsFat + gramsProteins + gramsCarbohydrates;
            double calloriesForOneGram = callories / allFoodInGrams;
            double finalCalories = calloriesForOneGram * (100 - percentWater) / 100;

            Console.WriteLine($"{finalCalories:f4}");
        }
    }
}
