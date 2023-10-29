using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiTurniri = int.Parse(Console.ReadLine());
            int broiPoints = int.Parse(Console.ReadLine());
            int specheleniTurniri = 0;
            int finalPoints = 0;
            
            for (int i = 1; i <= broiTurniri; i++)
            {
                string etap = Console.ReadLine();
                if (etap == "W")
                {
                    finalPoints += 2000;
                }
                else if (etap == "F")
                {
                    finalPoints += 1200;
                }
                else if (etap == "SF")
                {
                    finalPoints += 720;
                }
                if (etap == "W")
                {
                    specheleniTurniri++;
                }
            
            }
            
            Console.WriteLine($"Final points: {finalPoints + broiPoints}");
            Console.WriteLine($"Average points: {Math.Floor(1.0 *finalPoints / broiTurniri)}");
            Console.WriteLine($"{((1.0 * specheleniTurniri / broiTurniri) * 100.0):f2}%");
        }
    }
}
