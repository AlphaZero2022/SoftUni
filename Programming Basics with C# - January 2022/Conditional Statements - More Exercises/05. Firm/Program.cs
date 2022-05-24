using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredHours = int.Parse(Console.ReadLine());
            int daysForWork = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double realDays = daysForWork * 0.90;
            double realhours = realDays * 8;
            int extraHours = workers * daysForWork * 2;
            double allHours = Math.Floor(realhours + extraHours);

            if (allHours >= requiredHours)
            {
                Console.WriteLine($"Yes!{allHours - requiredHours} hours left.");

            }

            else
            {
                Console.WriteLine($"Not enough time!{requiredHours- allHours} hours needed.");
            }
        }
    }
}
