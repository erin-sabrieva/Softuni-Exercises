using System;
using System.Collections.Generic;

namespace text_processing_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            List<string> validName = new List<string>();
            foreach (var item in input)
            {

                if (item.Length>=3 && item.Length<=16)
                {
                    bool Isvalid = true;
                    for (int i = 0; i < item.Length; i++)
                    {
                        char curr = item[i];
                        if (!(curr =='-' || curr == '_'|| char.IsDigit(curr) || char.IsLetter(curr)))
                        {
                            Isvalid = false;
                            break;
                        }
                        
                    }
                    if (Isvalid)
                    {
                        validName.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,validName));
            
        }
    }
}
