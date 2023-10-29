using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string text = Console.ReadLine();
            while (text!= password)
            {
                text = Console.ReadLine();
            }
             Console.WriteLine($"Welcome {name}!");
           
        }
    }
}
