using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Artikle newArtikel =new Artikle(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string command = lines[0];
                string argument = lines[1];
                switch (command)
                {
                    case "Edit":
                        newArtikel.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        newArtikel.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        newArtikel.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(newArtikel);
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
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Edit(string newContent)
        {
            Content= newContent;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString() => $"{Title} - {Content}: {Author}";
        
    }
}
