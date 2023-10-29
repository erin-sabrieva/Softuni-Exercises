using System;

namespace While_loop_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string nextBook = Console.ReadLine();
            int counter = 0;
            while (nextBook != book)
            {
                counter++;
                nextBook = Console.ReadLine();
                
                if (nextBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
               
                
            }
            if (book == nextBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
                
            }
        }
    }
}
