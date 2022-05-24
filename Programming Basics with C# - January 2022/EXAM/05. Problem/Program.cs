using System;

namespace _05._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int goalsScored = int.Parse(Console.ReadLine());
            string bestPlayer = "";
            int currentBestScore = 0;

            while (playerName != "END")
            {
                if (goalsScored > currentBestScore)
                {
                    bestPlayer = playerName;
                    currentBestScore = goalsScored;

                    if (currentBestScore >= 10)
                    {
                        break;
                    }

                }

                playerName = Console.ReadLine();

                if (playerName == "END")
                {
                    break;
                }

                goalsScored = int.Parse(Console.ReadLine());
            }

            if (currentBestScore >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {currentBestScore} goals and made a hat-trick !!!");
            }

            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {currentBestScore} goals.");
            }
        }
    }
}