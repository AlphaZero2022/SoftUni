using System;

namespace _01._Old_Books_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine(); //името на любимата книга
            int counter = 0; //колко книги са проверени
            bool isBookFound = false; //намерена ли е книгата
            string nextBookName = Console.ReadLine();

            while (nextBookName !="No More Books")
            {
                if (nextBookName == favouriteBook) //ако съвпада излизаме от while цикъла
                {
                    isBookFound = true; //променя се първоначалната булева променлива в true
                    break;
                }

                counter++;
                nextBookName = Console.ReadLine();

            }

            if (isBookFound) //променено е на true по-горе, ако сме въвели любимото заглавие
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books");
            }


        }
    }
}
