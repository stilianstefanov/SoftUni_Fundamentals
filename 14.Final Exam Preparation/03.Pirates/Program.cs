using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Town> townList = new List<Town>();

            string[] townInfo = Console.ReadLine().Split("||");
            while (townInfo[0] != "Sail")
            {
                string currTownName = townInfo[0];
                int currPopulation = int.Parse(townInfo[1]);
                int currGold = int.Parse(townInfo[2]);

                if (!townList.Any(town => town.Name == currTownName))
                {
                    var newTown = new Town(currTownName);
                    townList.Add(newTown);
                }

                var currTown = townList.Find(town => town.Name == currTownName);
                currTown.Population += currPopulation;
                currTown.Gold += currGold;

                townInfo = Console.ReadLine().Split("||");
            }

            string[] command = Console.ReadLine().Split("=>");
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Plunder":
                        Plunder(townList, command);
                        break;
                    case "Prosper":
                        Prosper(townList, command);
                        break;
                }
                command = Console.ReadLine().Split("=>");
            }

            if (townList.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {townList.Count} wealthy settlements to go to:");
                Console.WriteLine(string.Join(Environment.NewLine, townList));
            }
        }

        private static void Prosper(List<Town> townList, string[] command)
        {
            string currTownName = command[1];
            int goldToIncrease = int.Parse(command[2]);

            if (goldToIncrease < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                return;
            }

            var currTown = townList.Find(town => town.Name == currTownName);
            currTown.Gold += goldToIncrease;

            Console.WriteLine($"{goldToIncrease} gold added to the city treasury. {currTownName} now has {currTown.Gold} gold.");
        }

        private static void Plunder(List<Town> townList, string[] command)
        {
            string currTownName = command[1];
            int populationToDecrease = int.Parse(command[2]);
            int goldToDecrease = int.Parse(command[3]);

            var currTown = townList.Find(town => town.Name == currTownName);
            currTown.Population -= populationToDecrease;
            currTown.Gold -= goldToDecrease;

            Console.WriteLine($"{currTownName} plundered! {goldToDecrease} gold stolen, {populationToDecrease} citizens killed.");

            if (currTown.Population == 0 || currTown.Gold == 0)
            {
                townList.Remove(currTown);
                Console.WriteLine($"{currTownName} has been wiped off the map!");
            }

            return;
        }
    }

    class Town
    {
        public Town(string name)
        {
            Name = name;            
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
}
