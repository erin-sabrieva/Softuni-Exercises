using System;

namespace DefiningClasses
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] peoplePropetyies= Console.ReadLine().Split();
                Person person = new Person(peoplePropetyies[0],int.Parse(peoplePropetyies[1]));
                family.AddMember(person);

            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
