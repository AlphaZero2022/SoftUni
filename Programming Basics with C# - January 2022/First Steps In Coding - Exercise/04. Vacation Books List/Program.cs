using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hoursForFullReading = bookPages / pagesReadPerHour;
            int pagesPerDay = hoursForFullReading / days;
            Console.WriteLine(pagesPerDay);


        }
    }
}
