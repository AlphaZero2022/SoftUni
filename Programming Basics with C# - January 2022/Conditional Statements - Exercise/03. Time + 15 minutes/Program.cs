using System;

namespace _03._Time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int timeInMinutes = m + h * 60;
            timeInMinutes += 15;

            h = timeInMinutes / 60;
            m = timeInMinutes % 60;

            if (h >= 24)
            {
                h -=24;
            }

            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
        
            else
            {
                Console.WriteLine($"{h}:{m}");
            }





        }
    }
}
