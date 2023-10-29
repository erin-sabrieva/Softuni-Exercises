using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);
           
            while (songs.Count>0)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]=="Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string songName = String.Join(" ", command.Skip(1));
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                
            }
            Console.WriteLine("No more songs!");
        }
    }
}
