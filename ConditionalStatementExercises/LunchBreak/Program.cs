using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());//48
            int restDuration = int.Parse(Console.ReadLine());//60
            double lunchTime = restDuration * 1 / 8.0;//7.5
            double otdihTime = restDuration * 1 / 4.0;//15
            double timeLeft = restDuration - (lunchTime + otdihTime);//37,5
            
            
            if (timeLeft >=episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(episodeDuration - timeLeft)} more minutes.");
            }




        }
    }
}
