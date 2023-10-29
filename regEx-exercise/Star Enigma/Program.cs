using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<name>[A-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<count>[0-9]+)";
            int linesOfInput = int.Parse(Console.ReadLine());
            var attacked = new List<string>();
            var destroyed = new List<string>();
            for (int i = 0; i < linesOfInput; i++)
            {
                string message = Console.ReadLine();
                int sum = message.ToLower().Count(x=> x=='s'|| x == 't' || x == 'a' || x == 'r');
                string decreptMessage = "";
                foreach (var symbol in message)
                {
                    decreptMessage += (char)(symbol - sum);
                }
                Match matches = Regex.Match(decreptMessage, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    int population = int.Parse(matches.Groups["population"].Value);
                    char type = char.Parse(matches.Groups["type"].Value);
                    int count = int.Parse(matches.Groups["count"].Value);
                    if (type!='A')
                    {
                        destroyed.Add(name);
                    }
                    else
                    {
                        attacked.Add(name);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x=> x).ToList().ForEach(pl => Console.WriteLine($"-> {pl}"));
            
            
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(pl => Console.WriteLine($"-> {pl}"));
           
            
        }
    }
}
