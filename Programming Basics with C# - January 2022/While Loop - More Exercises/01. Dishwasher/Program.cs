using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            double detergentAvailable = int.Parse(Console.ReadLine()) * 750;
            string input = Console.ReadLine();
            int dishwasherTurn = 1;
            int dishes = 0;
            int pots = 0;
            int detergentUsed = 0;


            while (detergentAvailable >= 0)
            {
                if (input == "End")
                {
                    break;
                }

                if (dishwasherTurn % 3 == 0)
                {
                    detergentUsed = int.Parse(input) * 15;
                    pots += int.Parse(input);
                    detergentAvailable -= detergentUsed;
                }

                else
                {
                    detergentUsed = int.Parse(input) * 5;
                    dishes += int.Parse(input);
                    detergentAvailable -= detergentUsed;
                }

                dishwasherTurn++;
                
                input = Console.ReadLine();
            }

            if (detergentAvailable < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergentAvailable)} ml. more necessary!");
            }

            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentAvailable} ml.");
            }

           

        }
    }
}
