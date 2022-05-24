using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine ();
            double academyScore = double.Parse(Console.ReadLine());
            int appraisersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= appraisersCount; i++)
            {
                string apprasiersName = Console.ReadLine();
                double appraiserPoints = double.Parse(Console.ReadLine());
                
                academyScore += apprasiersName.Length * appraiserPoints/2;

                if (academyScore > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyScore:f1}!");
                    break;
                }    

            }

            if (academyScore < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5-academyScore):f1} more!");
            }
        }
    }
}
