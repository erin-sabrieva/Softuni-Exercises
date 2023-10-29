using System;
using System.Collections.Generic;

namespace Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] words = input.Split();


                Student student = new Student
                {
                    FirstName = words[0],
                    LastName = words[1],
                    Age = int.Parse(words[2]),
                    City = words[3]
                };
                students.Add(student);

                input = Console.ReadLine();
            }
            string cityName = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.City == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }

            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}



