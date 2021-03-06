using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            

            for (int i = 1; i <= days; i++)
            {

                int currentPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (doctors >= currentPatients)
                {
                    treatedPatients += currentPatients;
                }

                else
                {
                    treatedPatients += doctors;
                    untreatedPatients += currentPatients - doctors;
                }

            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}."); 

        }
    }
}
