using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int pointsWon = 0;
            double percentWins = 0;
            double averagePoints = 0;

            for (int i = 1; i <= n; i++)
            {
                string level = Console.ReadLine ();

                if (level == "W")
                
                {
                    pointsWon += 2000;
                    percentWins += 1;
                }

                else if (level == "F")

                {
                    pointsWon += 1200;
                }  
                
                else
                {
                    pointsWon += 720;
                }

            }

            double finalPoints = startingPoints + pointsWon;
            percentWins = percentWins / n * 100;
            averagePoints = pointsWon / n;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentWins:f2}%");

        }
    }
}
