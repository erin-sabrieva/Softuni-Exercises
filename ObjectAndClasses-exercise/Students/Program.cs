using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> all = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                all.Add(student);
            }
            all= all.OrderByDescending(s => s.Grade).ToList();
            foreach (var student in all)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Student
    {
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

}
