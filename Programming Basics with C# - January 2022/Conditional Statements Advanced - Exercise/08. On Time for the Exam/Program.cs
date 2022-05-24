using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            examMinutes = examMinutes + examHours * 60;
            arrivalMinutes = arrivalMinutes + arrivalHours * 60;

            int difference = 0;
            int differenceInHours = 0;
            int differenceInMinutes = 0;

            if (examMinutes < arrivalMinutes)
            {
                Console.WriteLine("Late");

                difference = arrivalMinutes - examMinutes;
                differenceInHours = difference / 60;
                differenceInMinutes = difference % 60;

                if (differenceInHours >= 1)

                {
                    if (differenceInMinutes < 10)

                    {
                        Console.WriteLine($"{differenceInHours}:0{differenceInMinutes} hours after the start");
                    }

                    else
                    {
                        Console.WriteLine($"{differenceInHours}:{differenceInMinutes} hours after the start");
                    }

                }

                else
                {
                    Console.WriteLine($"{differenceInMinutes} minutes after the start");
                }

                        
            }

            else if (examMinutes - arrivalMinutes <= 30 )
            {
                Console.WriteLine("On time");

                if (arrivalMinutes != examMinutes)

                {
                    Console.WriteLine($"{examMinutes - arrivalMinutes} minutes before the start");


                }        
                
            }

            else 
            {
                Console.WriteLine("Early");

                difference = examMinutes - arrivalMinutes;
                differenceInHours = difference / 60;
                differenceInMinutes = difference % 60;

                if (differenceInHours >= 1)                    

                {
                    if (differenceInMinutes < 10)

                    {
                        Console.WriteLine($"{differenceInHours}:0{differenceInMinutes} hours before the start");
                    }

                    else
                    {
                        Console.WriteLine($"{differenceInHours}:{differenceInMinutes} hours before the start");
                    }

                }

                else
                {
                    Console.WriteLine($"{differenceInMinutes} minutes before the start");
                }
            } 
             
           
        }
    }
}
