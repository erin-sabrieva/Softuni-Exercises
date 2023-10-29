using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            
           List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    nums.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) > nums.Count - 1 || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;

                    }
                    else
                    {
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (nums.Count - 1 < int.Parse(command[1]) || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        nums.Remove(nums[int.Parse(command[1])]);
                    }
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            nums.Add(nums[0]);
                           
                            nums.RemoveAt(0);
                        }
                    }
                    else if (command[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(command[2]);i++)
                        {
                            nums.Insert(0, nums[nums.Count - 1]);
                            nums.RemoveAt(nums.Count - 1);
                        }
                    }
                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
