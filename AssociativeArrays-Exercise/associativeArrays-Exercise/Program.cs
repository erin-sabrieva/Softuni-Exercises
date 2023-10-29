using System;
using System.Collections.Generic;

namespace associativeArrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> myDic = new Dictionary<char, int>();
            foreach (var w in word)
            {
                if (w!=' ')
                {
                    if (!myDic.ContainsKey(w))
                    {
                        myDic[w] = 0;
                    }
                    myDic[w]++;
                }
            }
            foreach (var item in myDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
