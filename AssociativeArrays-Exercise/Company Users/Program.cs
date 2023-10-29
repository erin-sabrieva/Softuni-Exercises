using System;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] words = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = words[0];
                string employId = words[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
               
                    if (companies[companyName].Contains(employId))
                    {
                    input = Console.ReadLine();
                        continue;
                    }
                    
                        companies[companyName].Add(employId);
               
                input = Console.ReadLine();
            }
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var s in item.Value )
                {
                    Console.WriteLine($"-- {s}");
                }
            }
        }
    }
}
