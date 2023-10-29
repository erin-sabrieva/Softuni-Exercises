using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double allSuma = 0.0;
            
            while (input!= "NoMoreMoney")
            {
                double suma = double.Parse(input);
                
                if (suma < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                allSuma += suma;
                Console.WriteLine($"Increase: {suma:f2}");
                
                  input = Console.ReadLine();
                
                
            }
            Console.WriteLine($"Total: {allSuma:f2}");
        }
    }
}
