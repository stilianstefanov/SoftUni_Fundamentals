using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houeseHearts = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            int currentPosition = 0;

            string[] command = Console.ReadLine().Split();
            while (command[0] != "Love!")
            {
                int spacesToJump = int.Parse(command[1]);
                int nextPosition = currentPosition + spacesToJump;
                if (nextPosition >= houeseHearts.Count)
                {
                    nextPosition = 0;
                }
                if (houeseHearts[nextPosition] <= 0)
                {
                    Console.WriteLine($"Place {nextPosition} already had Valentine's day.");
                    currentPosition = nextPosition;
                    command = Console.ReadLine().Split();
                    continue;
                }

                houeseHearts[nextPosition] -= 2;
                if (houeseHearts[nextPosition] <= 0)
                {
                    Console.WriteLine($"Place {nextPosition} has Valentine's day.");
                }
                currentPosition = nextPosition;
                command = Console.ReadLine().Split();
            }

            bool isSuccesful = true;
            int housesLeft = 0;
            foreach (var house in houeseHearts)
            {
                if (house > 0)
                {
                    isSuccesful = false;
                    housesLeft++;
                }
            }
            Console.WriteLine($"Cupid's last position was {currentPosition}.");
            if (isSuccesful)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {housesLeft} places.");
            }

        }
    }
}
