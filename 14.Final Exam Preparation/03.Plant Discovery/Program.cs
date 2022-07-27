using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();

            int plantCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < plantCnt; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->");
                string currName = tokens[0];
                int currRarity = int.Parse(tokens[1]);

                if (!plants.Any(plant => plant.Name == currName))
                {
                    var newPlant = new Plant(currName, currRarity);
                    plants.Add(newPlant);
                }
                else
                {
                    var currPlant = plants.Find(plant => plant.Name == currName);
                    currPlant.Rarity = currRarity;
                }
            }

            string[] command = Console.ReadLine().Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Exhibition")
            {
                switch (command[0])
                {
                    case "Rate":
                        string plantName = command[1];
                        double plantRatingToAdd = double.Parse(command[2]);

                        if (!plants.Any(plant => plant.Name == plantName))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            var currPlant = plants.Find(plant => plant.Name == plantName);
                            currPlant.Ratings.Add(plantRatingToAdd);
                        }                        
                        break;
                    case "Update":
                        string plantNameToUpdate = command[1];
                        int newRarity = int.Parse(command[2]);

                        if (!plants.Any(plant => plant.Name == plantNameToUpdate))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            var currPlant = plants.Find(plant => plant.Name == plantNameToUpdate);
                            currPlant.Rarity = newRarity;
                        }
                        break;
                    case "Reset":
                        string plantNameToReset = command[1];
                        if (!plants.Any(plant => plant.Name == plantNameToReset))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            var currPlant = plants.Find(plant => plant.Name == plantNameToReset);
                            currPlant.Ratings.Clear();
                        }
                        break;
                }
                command = Console.ReadLine().Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.AvgRating:f2}");
            }
        }
    }
    class Plant
    {
        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            Ratings = new List<double>();
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Ratings { get; set; }
        public double AvgRating { get { return GetAvarage(this.Ratings); } }

        public static double GetAvarage(List<double> ratings)
        {
            if (ratings.Count == 0)
            {
                return 0.00;
            }
            else
            {
                return ratings.Average();
            }
        }
    }
}
