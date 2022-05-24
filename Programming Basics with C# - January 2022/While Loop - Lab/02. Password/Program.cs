using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            // read usename and password
            string username = Console.ReadLine();
            //read passwordEntry
            string password = Console.ReadLine();

            //if passowrd != passwordEntry -> new password
            string input = Console.ReadLine();

            while (password != input)
            {
                input = Console.ReadLine();

            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
