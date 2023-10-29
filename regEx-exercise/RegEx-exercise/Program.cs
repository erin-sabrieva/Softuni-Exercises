using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[>A-Za-z\s]+)<<(?<price>[0-9]+(.[0-9]+)?)!(?<quantity>[0-9]+)";
            var list = new List<string>();
            double totalPrice = 0;
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    list.Add(name);
                    totalPrice += price * quantity;

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
