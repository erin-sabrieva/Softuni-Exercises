using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfTheExam = int.Parse(Console.ReadLine());
            int minutesOfTheExam = int.Parse(Console.ReadLine());
            int hourOfArrive = int.Parse(Console.ReadLine());
            int minuteOfArival = int.Parse(Console.ReadLine());

            minutesOfTheExam = minutesOfTheExam + hoursOfTheExam * 60;
            minuteOfArival = minuteOfArival + hourOfArrive * 60;
           int difference = Math.Abs(minuteOfArival - minutesOfTheExam);
           int  difHour = difference / 60;
            int  difMinute = difference % 60;
            if (minuteOfArival > minutesOfTheExam)
            {
                Console.WriteLine("Late");
               
                if (difHour >= 1)
                {
                    if (difMinute < 10)
                    {
                        Console.WriteLine($" {difHour}:0{difMinute} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($" {difHour}:{difMinute} hours after the start");
                    }

                }
                else
                {
                    Console.WriteLine($" {difMinute} minutes after the start");
                }
            }
            



            else if (minutesOfTheExam - minuteOfArival <= 30)
            {
                Console.WriteLine("On time");
                if (minutesOfTheExam != minuteOfArival )
                {
                    
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else 
            {
                Console.WriteLine("Early");
                
                if (difHour >= 1)
                {
                    if (difMinute < 10)
                    {
                        Console.WriteLine($" {difHour}:0{difMinute} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($" {difHour}:{difMinute} hours before the start");
                    }

                }
                else
                {
                    Console.WriteLine($"{difMinute} minutes before the start");
                }


            }
            
            

        }
    }
}
