using System;

namespace imitation_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = Console.ReadLine();
            while (word!="Decode")
            {
                string[] command = word.Split('|');
                switch (command[0])
                {
                    case "Move":
                        int length = int.Parse(command[1]);
                        string stringToMOve = input.Substring(0, length);
                        input = input.Remove(0, length);
                        input += stringToMOve;
                        break;
                    case "Insert":
                        int index = int.Parse(command[1]);
                        string value = command[2];
                        input = input.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = command[1];
                        string replacment = command[2];
                        input = input.Replace(substring, replacment);

                        break;
                }
                word = Console.ReadLine(); ;
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
