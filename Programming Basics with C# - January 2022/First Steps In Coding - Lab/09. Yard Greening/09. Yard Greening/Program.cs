using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());
            double noDiscountPrice = (yards * 7.61);
            double discount = (noDiscountPrice * 0.18);
            double finalPrice = (noDiscountPrice - discount);
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv. ");
        }
    }
}
