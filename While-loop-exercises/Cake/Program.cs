using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirina = int.Parse(Console.ReadLine());//10
            int duljina = int.Parse(Console.ReadLine());//10
            int allParcheta = shirina * duljina;//100
            string input = Console.ReadLine();//20
            while (input != "STOP")
            {
                int broiParcheta = int.Parse(input);//->20
                allParcheta -= broiParcheta;//100-20=80
                if (allParcheta < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(allParcheta)} pieces more.");
                    break;
                }

                input = Console.ReadLine();

            }
            if (input == "STOP")
            {
                Console.WriteLine($"{allParcheta} pieces are left.");
            }



        }
    }
}
