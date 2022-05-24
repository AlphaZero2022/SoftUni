using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double occupiedSpace = double.Parse(Console.ReadLine());

            double volumeInLiters = (lenght * width * height)/1000.00;
            double liters = volumeInLiters * (1 - occupiedSpace / 100);
            Console.WriteLine(liters);
        }
    }
}
