using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            int messageCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split("=", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Statistics")
            {
                switch (command[0])
                {
                    case "Add":
                        {
                            string userName = command[1];
                            int sentMessages = int.Parse(command[2]);
                            int recievedMessages = int.Parse(command[3]);

                            if (!personList.Any(person => person.Name == userName))
                            {
                                var newPerson = new Person(userName, sentMessages, recievedMessages);
                                personList.Add(newPerson);
                            }
                        }
                        break;
                    case "Message":
                        Messages(personList, command, messageCapacity);
                        break;
                    case "Empty":
                        Empty(personList, command);
                        break;
                }
                command = Console.ReadLine().Split("=", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Users count: {personList.Count}");
            foreach (var person in personList)
            {
                Console.WriteLine($"{person.Name} - {person.TotalMessages}");
            }
        }

        private static void Empty(List<Person> personList, string[] command)
        {
            string userName = command[1];

            if (userName == "All")
            {
                personList.Clear();
            }
            else
            {
                var currUser = personList.Find(user => user.Name == userName);
                personList.Remove(currUser);
            }
        }

        private static void Messages(List<Person> personList, string[] command, int messageCapacity)
        {
            string senderName = command[1];
            string recieverName = command[2];

            if (personList.Any(person => person.Name == senderName) && personList.Any(person1 => person1.Name == recieverName))
            {
                var currSender = personList.Find(person => person.Name == senderName);
                var currReciever = personList.Find(person => person.Name == recieverName);

                currSender.SentMessages += 1;
                currReciever.RecievedMessages += 1;

                if (currSender.TotalMessages >= messageCapacity)
                {
                    personList.Remove(currSender);
                    Console.WriteLine($"{senderName} reached the capacity!");
                }
                if (currReciever.TotalMessages >= messageCapacity)
                {
                    personList.Remove(currReciever);
                    Console.WriteLine($"{recieverName} reached the capacity!");
                }
            }
        }
    }

    class Person
    {
        public Person(string name, int sentMessages, int recievedMessages)
        {
            Name = name;
            SentMessages = sentMessages;
            RecievedMessages = recievedMessages;           
        }

        public string Name { get; set; }
        public int RecievedMessages { get; set; }
        public int SentMessages { get; set; }
        public int TotalMessages { get { return RecievedMessages + SentMessages; } }
    }
}
