using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            List<Propety> all = new List<Propety>();
            while (words!="End")
            {
                string[] input = words.Split();
                Propety propety = new Propety(input[0], input[1], int.Parse(input[2]));
                all.Add(propety);
                words = Console.ReadLine();
            }
            foreach (var person in all.OrderBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
    class Propety
    {
        public Propety(string firstName, string iD, int age)
        {
            FirstName = firstName;
            Id = iD;
            Age = age;
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{FirstName} with ID: {Id} is {Age} years old.";
        
    }
}
