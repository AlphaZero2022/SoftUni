using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double averageMark = 0.0;
            int excluded = 0;
            int grade = 1;

            while (grade <= 12)
            {
                double yearlyMark = double.Parse(Console.ReadLine());

                if (yearlyMark < 4.00)
                {
                    excluded++;

                    if (excluded < 2)
                    {
                        continue;
                    }

                    else
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }

                }

                grade++;
                averageMark += yearlyMark;
                
            }

            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageMark / 12:f2}");
            }

            
        }
    }
}
