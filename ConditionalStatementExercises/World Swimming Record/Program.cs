using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double TimeInSeconds = double.Parse(Console.ReadLine());
            double prepluva = distanceInMetres * TimeInSeconds;
            double zabavqne = Math.Floor((distanceInMetres / 15)) * 12.5;
            double totalTime = prepluva + zabavqne;
            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - recordInSeconds):f2} seconds slower.");

            }


        }

    }
}
