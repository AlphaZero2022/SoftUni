using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShowName = Console.ReadLine ();
            int showDuration = int.Parse(Console.ReadLine()); //по условие е дадено като цяло число, но може да се използва и double
            int pause = int.Parse(Console.ReadLine()); //по условие е дадено като цяло число, но може да се използва и double

            double freeTime = pause * 5.0 / 8; //дели се на 5.0, защото ако няма 0 ще стане целочислено деление и може част от данните да изчезнат

            if (freeTime >= showDuration)
            {
                Console.WriteLine($"You have enough time to watch {tvShowName} and left with {Math.Ceiling(freeTime - showDuration)} minutes free time.");
            }

            else 
            {
                Console.WriteLine($"You don't have enough time to watch {tvShowName}, you need {Math.Ceiling(showDuration- freeTime)} more minutes.");
            }
        }
    }
}
