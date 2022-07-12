using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Shoot":
                        int shootAtIndex = int.Parse(command[1]);
                        int power = int.Parse(command[2]);
                        Shoot(targets, shootAtIndex, power);
                        break;
                    case "Add":
                        int addAtIndex = int.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        addValue(targets, addAtIndex, value);
                        break;
                    case "Strike":
                        int strikeAtIndex = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);
                        StrikeF(targets, strikeAtIndex, radius);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join("|", targets));
        }

        static void StrikeF(List<int> targets, int strikeAtIndex, int radius)
        {
            if (strikeAtIndex < 0 || strikeAtIndex >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            if (strikeAtIndex - radius < 0 || strikeAtIndex + radius >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            int countOfNumbersToDel = radius * 2 + 1;
            targets.RemoveRange(strikeAtIndex - radius, countOfNumbersToDel);
        }

        static void addValue(List<int> targets, int addAtIndex, int value)
        {
            if (addAtIndex >= 0 && addAtIndex < targets.Count)
            {
                targets.Insert(addAtIndex, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Shoot(List<int> targets, int atIndex, int power)
        {
            if (atIndex >= 0 && atIndex < targets.Count)
            {
                targets[atIndex] -= power;
                if (targets[atIndex] <= 0)
                {
                    targets.RemoveAt(atIndex);
                }
            }
        }
    }
}
