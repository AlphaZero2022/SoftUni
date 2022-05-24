using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int numberOfPieces = length * height;
            int piecesTaken = 0;
            int piecesLeft = 0;
            string input = "";


            while (true)
            {
                
                input = Console.ReadLine();

                if (input != "STOP")
                {
                piecesTaken += int.Parse(input);
                piecesLeft = numberOfPieces - piecesTaken;

                    if (piecesLeft <= 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(piecesLeft)} pieces more.");
                        break;
                    }
                }    
              
                else if (input == "STOP" && piecesLeft > 0)
                {
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    break;
                }

                
            }

        }
    }
}
