using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            int svobodnoMqsto = shirina * duljina * visochina;
            int sum = 0;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int broiCashoni = int.Parse(input);
                sum += broiCashoni;
                if (sum > svobodnoMqsto)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(svobodnoMqsto - sum)} Cubic meters more.");
                    break;
                }
                
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{svobodnoMqsto - sum} Cubic meters left.");
                
            }
        }
    }
}
