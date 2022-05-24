using System;

namespace ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine ();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int projectHours = 3;
            int sum = (numberOfProjects * 3);
            Console.WriteLine($"The architect {architectName} will need {sum} hours to complete {numberOfProjects} project/s.");
            
        }
    }
}
