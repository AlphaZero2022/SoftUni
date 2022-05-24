using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int failedTimes = int.Parse(Console.ReadLine());
            double marksSum = 0;
            int marksCount = 0;
            string lastExercise = "";
            int failedCount = 0;
            string input = Console.ReadLine();

            while (input != "Enough")
            {
                lastExercise = input;
                int mark = int.Parse(Console.ReadLine());
                marksSum += mark;
                marksCount++;

                if (mark <= 4)
                {
                    failedCount++;
                    
                    if (failedCount >= failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }    
                }

                input = Console.ReadLine();
            }

            double average = marksSum / marksCount;

            if (failedCount < failedTimes)
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {marksCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
