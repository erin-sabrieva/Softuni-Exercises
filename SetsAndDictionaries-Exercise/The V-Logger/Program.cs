using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vlogger> vloggers = new List<Vlogger>();
            string input = Console.ReadLine();
            while (input!= "Statistics")
            {
                string[] commands = input.Split();
                string vloggerName = commands[0];
                string action = commands[1];
                string vloggerToFolllowName = commands[2];
                if (action== "joined")
                {
                    if (!vloggers.Any(x=>x.Name == vloggerName))
                    {
                        vloggers.Add(new Vlogger(vloggerName));
                    }
                }
                else
                {
                    if (vloggerName==vloggerToFolllowName|| !vloggers.Any(v=>v.Name==vloggerName)|| !vloggers.Any(j=>j.Name==vloggerToFolllowName))
                    {
                        input=Console.ReadLine();
                        continue;
                    }
                    Vlogger vloger = vloggers.Single(v=>v.Name==vloggerName);
                    vloger.Following.Add(vloggerToFolllowName);
                    Vlogger vlogerToFollow= vloggers.Single(b => b.Name == vloggerToFolllowName);
                    vloger.Folllowers.Add(vloggerName);
                }

                input = Console.ReadLine();
            }
            vloggers = vloggers.OrderByDescending(v=>v.Folllowers.Count).ThenBy(x=>x.Following.Count).ToList();
            Console.WriteLine($"The V - Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var item in vloggers)
            {
                Console.WriteLine($"{count}. {item.Name} : {item.Folllowers.Count} followers, {item.Following.Count} following");
                if (count == 1)
                {
                    foreach (var ft in item.Folllowers)
                    {
                        Console.WriteLine($"* {ft}");
                    }
                }
                count++;
                

            }
        }
    }
    public class Vlogger
    {
        public Vlogger(string name)
        {
            Name=name;
            Folllowers = new SortedSet<string>();
            Following = new HashSet<string>();

        }
        public string Name { get; set; }
        public SortedSet<string> Folllowers { get; set; }
        public HashSet<string> Following { get; set; }
        
    }
}
