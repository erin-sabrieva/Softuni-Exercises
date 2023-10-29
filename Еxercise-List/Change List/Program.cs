using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (int.Parse(command[1]) == nums[i])
                        {
                            nums.Remove(nums[i]);
                        }
                    }
                }
                else
                {
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
