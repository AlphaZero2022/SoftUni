using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double yearlyInterestRate = double.Parse(Console.ReadLine());
            double depositEndSum = depositSum + depositTerm * ((depositSum * yearlyInterestRate/100)/ 12);
            Console.WriteLine(depositEndSum);
        }
    }
}
