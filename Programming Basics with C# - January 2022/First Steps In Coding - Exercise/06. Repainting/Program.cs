using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());
            double bagPrice = 0.40; 

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint + paint * 0.10) * 14.50;
            double diluentPrice = diluent * 5;
            double workingHoursPrice = (nylonPrice + paintPrice + diluentPrice + bagPrice) * .30 * workingHours;

            double sum = nylonPrice + paintPrice + diluentPrice + workingHoursPrice+bagPrice;
            Console.WriteLine (sum);

        }
    }
}
