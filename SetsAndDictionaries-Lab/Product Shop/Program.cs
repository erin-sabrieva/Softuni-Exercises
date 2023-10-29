using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dictionaryNeted = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input!= "Revision")
            {
                string[] command = input.Split(", ");
                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);
                if (!dictionaryNeted.ContainsKey(shop))
                {
                    dictionaryNeted.Add(shop, new Dictionary<string, double>());
                }
                dictionaryNeted[shop].Add(product,price);
                input = Console.ReadLine();
            }
            dictionaryNeted = dictionaryNeted.OrderBy(r => r.Key).ToDictionary(r => r.Key, r => r.Value);
            foreach (var item in dictionaryNeted)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var prod in item.Value)
                {
                    Console.WriteLine($"Product: {prod.Key}, Price: {prod.Value}");
                }
            }
        }
    }
}
