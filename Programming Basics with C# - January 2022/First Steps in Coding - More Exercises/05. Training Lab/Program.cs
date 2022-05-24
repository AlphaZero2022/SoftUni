using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()); //w = 15 m = 1500 cm - дължина;
            double h = double.Parse(Console.ReadLine()); //h = 8.9 м = 890 cm - широчина;
            double workingPlaceh = Math.Floor((h*100 - 100) / 70); // 890 - 100 = 790 / 70 = 11 +  20 cm остатък
            double workingPlacew = Math.Floor(w*100 / 120);  //1500 / 120 = 12 + 60 cm 
            double workingPlace = workingPlaceh * workingPlacew - 3;
            Console.WriteLine(workingPlace);




        }
    }
}
