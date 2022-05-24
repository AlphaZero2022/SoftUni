using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            double primeSum = 0;
            double nonPrimeSum = 0;
            int number;

            while (input != "stop")
            {
                number = int.Parse(input); //нова променлива, която е преобразуван string input в int

                if (number < 0) //първа проверка
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true; //с тази променилва isPrime е винаги true

                for (int i = 2; i < number; i++) //на лекцията кодът е с number -1, макар че и с number judge дава 100%; според мен това -1 е излишно
                {
                    if (number%i ==0) //ако number се дели на i, тогава е четно; реално се изследват всички число до number;
                    {
                        isPrime = false; //булевата променилва става false и излизаме от цикъла, за да можем да влезем в else
                        break;
                    }
                }

                if (isPrime) //ситуацията, в която не сме влезнали в горния if и булевата isPrime е останал true
                {
                    primeSum += number;
                }

                else //влизаме тук, ако числото не е просто.
                {
                    nonPrimeSum += number;
                }
                

                input = Console.ReadLine(); //това е винаги добре да се пише в началото, когато имаме while цикъл, за да не го забравим накрая
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
           
        }
    }
}
