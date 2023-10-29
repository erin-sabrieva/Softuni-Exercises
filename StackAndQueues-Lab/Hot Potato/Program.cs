using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());
            int tosses = 1;
            Queue<string> queue = new Queue<string>(kids);
            while (queue.Count>1)
            {
                string currKid = queue.Dequeue();
                if (tosses==count)
                {
                    Console.WriteLine($"Removed {currKid}");
                    tosses = 1;
                    continue;
                }
                
                    tosses++;
                queue.Enqueue(currKid);
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
