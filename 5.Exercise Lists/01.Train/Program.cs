using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityWagon = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int numberOfPassangers = int.Parse(command[1]);
                    AddPassangers(wagons, numberOfPassangers);
                }
                else
                {
                    int passagersToFit = int.Parse(command[0]);
                    FitPassangers(wagons, passagersToFit, maxCapacityWagon);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }

        static void FitPassangers(List<int> wagons, int passagersToFit, int maxCapacityWagon)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passagersToFit <= maxCapacityWagon)
                {
                    wagons[i] = wagons[i] + passagersToFit;
                    break;
                }
            }
        }

        static void AddPassangers(List<int> wagons, int numberOfPassangers)
        {
            wagons.Add(numberOfPassangers);
        }
    }
}
