using System;
using System.Collections.Generic;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Artikle> all = new List<Artikle>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Artikle artikle = new Artikle(input[0], input[1], input[2]);
                all.Add(artikle);
            }
            string word = Console.ReadLine();
            foreach (var artikel in all)
            {
                Console.WriteLine(artikel);
            }
        }
    }
    class Artikle
    {
        public Artikle(string title, string content, string author)
        {
            Author = author;
            Content = content;
            Title = title;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}
