using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();
            while (command[0] != "Retire")
            {
                switch (command[0])
                {
                    case "Fire":
                        int atIndex = int.Parse(command[1]);
                        int damageFire = int.Parse(command[2]);
                        FireAt(warShip, atIndex, damageFire);
                        if (atIndex >= 0 && atIndex < warShip.Count)
                        {
                            if (warShip[atIndex] <= 0)
                            {
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        int damageTaken = int.Parse(command[3]);
                        if ((startIndex >= 0 && startIndex < pirateShip.Count)
                            && (endIndex >= 0 && endIndex < pirateShip.Count)
                            )
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateShip[i] -= damageTaken;
                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                        break;
                    case "Repair":
                        int atIndexRepair = int.Parse(command[1]);
                        int healthRecieved = int.Parse(command[2]);
                        Healing(pirateShip, atIndexRepair, healthRecieved, maxHealth);
                        break;
                    case "Status":
                        GetStatus(pirateShip, maxHealth);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            int pirateShipSum = 0;
            foreach (var section in pirateShip)
            {
                pirateShipSum += section;
            }
            int warShipSum = 0;
            foreach (var section in warShip)
            {
                warShipSum += section;
            }
            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warShipSum}");
        }

        static void GetStatus(List<int> pirateShip, int maxHealth)
        {
            double lowHealth = maxHealth * 0.20;
            int count = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] < lowHealth)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} sections need repair.");
        }

        static void Healing(List<int> pirateShip, int atIndexRepair, int healthRecieved, int maxHealth)
        {
            if (atIndexRepair < 0 || atIndexRepair >= pirateShip.Count)
            {
                return;
            }
            pirateShip[atIndexRepair] += healthRecieved;
            if (pirateShip[atIndexRepair] > maxHealth)
            {
                pirateShip[atIndexRepair] = maxHealth;
            }
        }

        static void FireAt(List<int> warShip, int atIndex, int damageFire)
        {
            if (atIndex < 0 || atIndex >= warShip.Count)
            {
                return;
            }
            warShip[atIndex] -= damageFire;
            if (warShip[atIndex] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                return;
            }
        }
    }
}
