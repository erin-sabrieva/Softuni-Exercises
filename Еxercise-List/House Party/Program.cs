using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCommand = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();
            for (int i = 0; i < countCommand; i++)
            {
                string input = Console.ReadLine();
                string[] name = input.Split();
                if (name[2] == "going!" && guest.Contains(name[0]))
                {
                        Console.WriteLine($"{name[0]} is already in the list!");
                }
                else if (name[2] == "not"&& guest.Contains(name[0]))
                {
                    guest.Remove(name[0]);
                }
                else if(name[2] == "not" && !guest.Contains(name[0]))
                {
                    Console.WriteLine($"{name[0]} is not in the list!");
                  
                }
                else
                {
                    guest.Add(name[0]);
                }
             
            }
            for (int i = 0; i < guest.Count; i++)
            {
                Console.Write(guest[i]);
                Console.WriteLine();
            }
        }
    }
}
