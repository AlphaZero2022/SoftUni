using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a program...
            //string name = "zvezdelin";
            //string surname = "ngo";
            //int age = 34;
            //double height = 1.78;
            //string phonenumber = "0877882398";
            //console.writeline($"name = {name}");
            //console.writeline($"surname = {surname}");
            //console.writeline($"age = {age}");
            //console.writeline($"height = {height:f3} m");
            //console.writeline($"phone = {phonenumber}");

            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());// "25 -> 25
            double height = double.Parse(Console.ReadLine()); // "1.78 -> 1.78
            string phoneNumber = Console.ReadLine();

            Console.WriteLine($"name = {name}");
            Console.WriteLine($"surname = {surname}");
            Console.WriteLine($"age = {age}");
            Console.WriteLine($"height = {height:f3} m");
            Console.WriteLine($"phone = {phoneNumber}");








        }
    }
}
