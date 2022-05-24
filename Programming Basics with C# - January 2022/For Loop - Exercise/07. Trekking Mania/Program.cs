using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double percentMusala = 0;
            double percentMonblan = 0;
            double percentKilimandjaro = 0;
            double percentK2 = 0;
            double percentEverest = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)

            {
                int people = int.Parse(Console.ReadLine());
                sum += people;
                if (people <= 5)
                {
                    percentMusala += people;
                }
                else if (people <= 12)
                {
                    percentMonblan += people;
                }
                else if (people <= 25)
                {
                    percentKilimandjaro += people;
                }
                else if (people <= 40)
                {
                    percentK2 += people;
                }
                else
                {
                    percentEverest += people;
                }
            }

            percentMusala = percentMusala / sum * 100;
            percentMonblan = percentMonblan / sum * 100;
            percentKilimandjaro = percentKilimandjaro / sum * 100;
            percentK2 = percentK2 / sum * 100;
            percentEverest = percentEverest / sum * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
       

        }
    }
}
