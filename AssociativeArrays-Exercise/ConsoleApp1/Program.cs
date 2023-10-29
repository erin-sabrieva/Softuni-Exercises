using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
var information = new Dictionary<string, List<string>>();
            string input  = Console.ReadLine();
            
            while (input!="end")
            {
                string[] words = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = words[0];
                string user = words[1];
                if (!information.ContainsKey(courseName))
                {
                    information[courseName] = new List<string>();
                }
                information[courseName].Add(user);
                
               input = Console.ReadLine();
            }
            foreach (var item in information)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
