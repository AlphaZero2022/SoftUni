using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1; //променилва, която е началото на пирамидата и се увеличава, докато не стигнем number;

            for (int rows = 1; rows <= number; rows++) //външен цикъл, който контролира броят редове;
            {
                for (int columns = 1; columns <= rows; columns++) //върешен цикъл, който контролира броят на числата във всеки ред; броят на числата е не по-голям от номера на реда;
                {
                    Console.Write(currentNumber+ " "); //Write отбелязва на същия ред
                    currentNumber++;

                    if (currentNumber > number) //излизаме от вътрешния цикъл, ако сме достигнали number;
                    {
                        break;
                    }
                }

                Console.WriteLine(); //въвежда се, за да има "space" между всяка стойност на променилвата currentNumber

                if (currentNumber > number) //за да излезем от външния цикъл;
                {
                    break;
                }
            }

            
            {

            }
        }
    }
}
