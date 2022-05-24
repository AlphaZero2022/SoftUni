using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int presentationCount = 0;
            double sumOfGrades;
            double sumOfAllAverageGrades = 0;
            

            while (presentation != "Finish")
            {
                sumOfGrades = 0; //при всяка итерация на цикъла се нулира сумата на всички оценки на съответната презентация, за да може да се изчислява за следващата

                for (int i = 1; i <= juryCount; i++)
                {
                    sumOfGrades += double.Parse(Console.ReadLine());
                }

                double averageGrade = sumOfGrades / juryCount; //стойността е различна при всяка итерация на while цикъла, тъй като при всяка итерация е различна и стойността на sumOfGrades 
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");

                sumOfAllAverageGrades += averageGrade; //запазва се нова стойност при всяка итерация на външния while цикъл;
                presentationCount++; //запазва се нова стойност при всяка итерация на външния while цикъл;

                presentation = Console.ReadLine();
            }

            double finalAverageGrade = sumOfAllAverageGrades / presentationCount;
            Console.WriteLine($"Student's final assessment is {finalAverageGrade:f2}.");

        }
    }
}
