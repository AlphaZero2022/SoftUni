using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordtime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1m = double.Parse(Console.ReadLine());

            double timeForWholeDistance = distance * timeFor1m;
                       
            double delayPer1m = Math.Floor(distance / 15) ;
            double delay = delayPer1m * 12.5;
            double totalTime = timeForWholeDistance + delay;
            
            if (totalTime < worldRecordtime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecordtime:F2} seconds slower.");
            }
        }
    }
}
