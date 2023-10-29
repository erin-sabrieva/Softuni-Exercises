using System;

namespace worldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = Console.ReadLine();
            while (word!="Travel")
            {
                string[] command = word.Split(":");
                switch (command[0])
                {
                    case "Add Stop":
                        int index = int.Parse(command[1]);
                        string text = command[2];
                        if (index >=0 && index < input.Length)
                        {
                            input = input.Insert(index, text);
                            
                        }
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (startIndex>=0 && endIndex >=0 && startIndex<input.Length && endIndex< input.Length)
                        {
                            input = input.Remove(startIndex, endIndex-startIndex+1);
                            
                        }
                        break;
                    case "Switch":
                        string oldString = command[1];
                        string newString=command[2];
                        if (input.Contains(oldString))
                        {
                            input = input.Replace(oldString, newString);
                           
                        }
                        break;
                }
                Console.WriteLine(input);
                word = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
