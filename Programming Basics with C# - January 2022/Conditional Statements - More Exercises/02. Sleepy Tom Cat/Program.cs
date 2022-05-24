using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int nonWorkingDays = int.Parse(Console.ReadLine());
            int WorkingDays = 365 - nonWorkingDays;
            int playTime = nonWorkingDays * 127 + WorkingDays * 63;
            int difference = Math.Abs(playTime - 30000);
            int hours = difference / 60;
            int minutes = difference % 60;
            
            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play") ;

            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

        }
    }
}
