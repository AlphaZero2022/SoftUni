using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string favouriteBook = Console.ReadLine();
            string book = Console.ReadLine();
            int booksChecked = 0;

            while (book != "No More Books")

            {
                
                if (book == favouriteBook)
                {
                    break;
                }

                booksChecked++;
                book = Console.ReadLine();

            }

            if (book == favouriteBook)
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
            }

            else 
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked} books.");
            }




        }
    }
}
