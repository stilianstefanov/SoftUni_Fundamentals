using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split("|").ToList();

            List <string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "Yohoho!")
            {
                switch (command[0])
                {
                    case "Loot":
                        Loot(treasure, command);
                        break;
                    case "Drop":
                        int indexToDrop = int.Parse(command[1]);
                        DropLoot(treasure, indexToDrop);
                        break;
                    case "Steal":
                        int countToSteal = int.Parse(command[1]);
                        StealItems(treasure, countToSteal);
                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }
            if (treasure.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int sum = 0;
                foreach (string item in treasure)
                {
                    sum += item.Length;
                }
                double finalValue = (double)sum / treasure.Count;
                Console.WriteLine($"Average treasure gain: {finalValue:f2} pirate credits.");
            }
        }

        static void StealItems(List<string> treasure, int countToSteal)
        {
            List<string> stoleItems = new List<string>();
            int counter = 0;
            for (int i = treasure.Count - 1; i >= 0; i--)
            {
                stoleItems.Add(treasure[i]);
                treasure.RemoveAt(i);
                counter++;
                if (counter == countToSteal)
                {
                    break;
                }
            }
            stoleItems.Reverse();
            Console.WriteLine(String.Join(", ", stoleItems));
        }

        static void DropLoot(List<string> treasure, int indexToDrop)
        {
            if (indexToDrop < 0 || indexToDrop >= treasure.Count)
            {
                return;
            }
            string itemToDrop = treasure[indexToDrop];
             treasure.Add(itemToDrop);
            treasure.RemoveAt(indexToDrop);
        }

        static void Loot(List<string> treasure, List<string> command)
        {
            command.RemoveAt(0);
            for (int i = 0; i < command.Count; i++)
            {
                if (treasure.Contains(command[i]))
                {
                    command.Remove(command[i]);
                    i--;
                }
            }
            command.Reverse();
            treasure.InsertRange(0, command);
        }
    }
}
