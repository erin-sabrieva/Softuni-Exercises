using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string healthPattern = @"[^\+\-\*\/\.,0-9]";
            string damagePattern = @"-?\d+\.?\d*";
            string multiplyOrDevidePattern = @"[\*\/]";
            string splitPattern = @"[,\s]+";
            string input = Console.ReadLine();
            string[] demons = Regex.Split(input,splitPattern).OrderBy(x=>x).ToArray();
            for (int i = 0; i < demons.Length; i++)
            {
                string currDemon = demons[i];
                var healthMatch = Regex.Matches(currDemon, healthPattern);
                var helath = 0;
                foreach (Match match in healthMatch)
                {
                    char curChar = char.Parse(match.ToString());
                    helath += curChar;
                }
                double damage = 0;
                var damageMatch = Regex.Matches(currDemon,damagePattern);
                foreach (Match match in damageMatch)
                {
                    double currDamage = double.Parse(match.ToString());
                    damage += currDamage;
                }
                var multiplyOrdDevide = Regex.Matches(currDemon, multiplyOrDevidePattern);
                foreach (Match match in multiplyOrdDevide)
                {
                    char currSymbol = char.Parse(match.ToString());
                    if (currSymbol == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                Console.WriteLine($"{currDemon} - {helath} health, {damage:f2} damage");

            }
            

        }
    }
}
