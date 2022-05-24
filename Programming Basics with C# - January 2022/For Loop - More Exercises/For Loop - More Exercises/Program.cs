using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double poorStudents = 0;
            double fairStudents = 0;
            double averageStudents = 0;
            double topStudents = 0;
            double allGradesSum = 0;

            for (int i = 1; i <= number; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2.00 && grade <= 2.99)
                {
                    poorStudents++;
                    allGradesSum += grade;
                }

                else if (grade >= 3.00 && grade <= 3.99)
                {
                    fairStudents++;
                    allGradesSum += grade;
                }

                else if (grade >= 4.00 && grade <= 4.99)
                {
                    averageStudents++;
                    allGradesSum += grade;
                }

                else
                {
                    topStudents++;
                    allGradesSum += grade;
                }
            }

            Console.WriteLine("Top students: {0:f2}%", (topStudents / number) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (averageStudents / number) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (fairStudents / number) * 100);
            Console.WriteLine("Fail: {0:f2}%", (poorStudents / number) * 100);
            Console.WriteLine("Average: {0:f2}", allGradesSum / number);

        }
    }
}
