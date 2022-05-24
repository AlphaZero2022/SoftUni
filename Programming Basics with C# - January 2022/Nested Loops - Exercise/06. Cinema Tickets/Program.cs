using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int numberOfStudentTickets = 0;
            int numberOfStandardTickets = 0;
            int numberOfKidTickets = 0;
            int allTickets = 0;
            int numberOfAllticketsForTheMovie = 0;

            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                
                    for (int i = 0; i < freeSeats; i++)
                    {
                    string typeOfTicket = Console.ReadLine();
                        
                        if (typeOfTicket == "End")
                        {
                        break;
                        }
                        
                        else 
                            if (typeOfTicket == "student")
                            {
                            numberOfStudentTickets++;
                            }

                            else if (typeOfTicket == "standard")
                            {
                            numberOfStandardTickets++;
                            }

                            else if (typeOfTicket == "kid")
                            {
                            numberOfKidTickets++;
                            }

                    numberOfAllticketsForTheMovie++;
  
                    }

                Console.WriteLine($"{movieName} - {100.0*numberOfAllticketsForTheMovie / freeSeats:f2}% full.");
                numberOfAllticketsForTheMovie = 0;

                movieName = Console.ReadLine();
            }

            allTickets = numberOfStudentTickets + numberOfStandardTickets + numberOfKidTickets;

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{ 100.0 * numberOfStudentTickets / allTickets:f2}% student tickets.");
            Console.WriteLine($"{ 100.0 * numberOfStandardTickets / allTickets:f2}% standard tickets.");
            Console.WriteLine($"{ 100.0 * numberOfKidTickets / allTickets:f2}% kids tickets.");
        
        }
    }
}
