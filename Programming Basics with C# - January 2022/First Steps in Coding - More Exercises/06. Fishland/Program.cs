using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int musselsKg = int.Parse(Console.ReadLine());

            double musselsPrice = 7.50;
            double bonitoPrice = mackerelPrice + 0.60 * mackerelPrice;
            double scadPrice = spratPrice + 0.80 * spratPrice;

            double musselsFinal = musselsKg * musselsPrice;
            double bonitoFinal = bonitoKg * bonitoPrice;
            double scadFinal = scadKg * scadPrice;

            double sum = musselsFinal + bonitoFinal + scadFinal;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
