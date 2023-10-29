using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

           
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "3:1") break;
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                string concatedWord = "";
                
                if (startIndex<0 || startIndex>myList.Count-1)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > myList.Count - 1)
                {
                   endIndex = myList.Count - 1;
                }
                
                if (command[0]== "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatedWord += myList[i];
                    }
                    myList.RemoveRange(startIndex, endIndex-startIndex+1);
                    myList.Insert(startIndex, concatedWord);

                }
                else if(command[0]== "divide")
                {
                    var divideList = new List<string>();
                    int participants = int.Parse(command[2]);
                    string word = myList[startIndex];
                    myList.RemoveAt(startIndex);
                    int parts = word.Length / participants;
                    for (int i = 0; i < participants; i++)
                    {
                        if (i==participants-1)
                        {
                            divideList.Add(word.Substring(i*parts));
                        }
                        else
                        {
                            divideList.Add(word.Substring(i * parts, parts));
                        }
                    }
                    myList.InsertRange(startIndex, divideList);
                }
            }
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
