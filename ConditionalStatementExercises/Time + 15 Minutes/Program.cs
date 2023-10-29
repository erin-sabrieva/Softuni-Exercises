using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int timeInMinute = minutes + hours * 60;
            int finalMinutes = timeInMinute + 15;
            hours = finalMinutes / 60;
            minutes = finalMinutes % 60;
            if (hours >= 24)
            {
                hours = hours - 24;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }


        }
    }
}
