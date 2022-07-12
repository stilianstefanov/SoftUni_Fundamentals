using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int peopleCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCnt; i++)
            {
                var personInfo = Console.ReadLine().Split();
                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);

                family.AddPerson(personName, personAge);
            }
            family.GetOldestPerson();
        }
    }
    class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; set; }

        public void AddPerson(string personToAdd, int age) => this.Persons.Add(new Person(personToAdd, age));

        public void GetOldestPerson()
        {
            int maxAge = int.MinValue;
            Person oldestPerson = null;

            foreach (var person in Persons)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestPerson = person;
                }
            }

            Console.WriteLine(oldestPerson);
        }
      
    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
