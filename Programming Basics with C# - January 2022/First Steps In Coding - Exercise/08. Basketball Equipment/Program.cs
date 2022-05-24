using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double sneakers = yearTax - (yearTax * 0.40);
            double equipment = sneakers - (sneakers * 0.20);
            double ball = equipment * 0.25;
            double accessories = ball * 0.20;

            double sum = yearTax + sneakers + equipment + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}
