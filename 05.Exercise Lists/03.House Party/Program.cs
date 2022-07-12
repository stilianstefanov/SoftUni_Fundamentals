using System;
using System.Collections.Generic;

namespace House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[2])
                {
                    case "going!":
                        string name = command[0];
                        Booking(guests, name);
                        break;
                    case "not":
                        string name2 = command[0];
                        UnBooking(guests, name2);
                        break;
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        private static void UnBooking(List<string> guests, string name)
        {
            if (!guests.Contains(name))
            {
                Console.WriteLine($"{name} is not in the list!");
                return;
            }
            else
            {
                guests.Remove(name);
            }
        }

        static void Booking(List<string> guests, string name)
        {
            if (guests.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
                return;
            }
            else
            {
                guests.Add(name);
            }
        }
    }
}
