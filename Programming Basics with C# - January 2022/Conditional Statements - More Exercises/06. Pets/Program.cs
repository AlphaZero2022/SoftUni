using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());
            
            double dogNeed = dogFoodPerDay * days;
            double catNeed = catFoodPerDay * days;
            double turtleNeed = turtleFoodPerDay * days*0.001;

            double allFood = dogNeed + catNeed + turtleNeed;

            if (allFood <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft- allFood)} kilos of food left.");

            }

            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood- foodLeft)} more kilos of food are needed.");
            }



        }
    }
}
