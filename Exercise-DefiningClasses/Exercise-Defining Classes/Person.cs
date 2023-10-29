using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
   public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "No name";
            age = 1;

        }

        public Person(int years):this()
        {
            age = years;
        }

        public Person(string text, int years)
        {
            name = text;
            age = years;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
