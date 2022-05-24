using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int space = w * l * h;
            int spaceLeft = 0;
            int spaceTaken = 0;
            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input != "Done")
                {
                    spaceTaken += int.Parse(input);
                    spaceLeft = space - spaceTaken;

                    if (spaceLeft <=0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(spaceLeft)} Cubic meters more.");
                        break;
                    }    
                } 
                
                else if (input == "Done" && spaceLeft > 0)
                {
                    Console.WriteLine($"{spaceLeft} Cubic meters left.");
                    break;
                }    
            }    

        }
    }
}
