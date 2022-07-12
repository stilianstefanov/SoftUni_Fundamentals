using System;

namespace Mu_Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int health = 100;
            int bitCoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currRoom = rooms[i].Split();

                if (currRoom[0] == "potion")
                {
                    int potionPower = int.Parse(currRoom[1]);
                    health += potionPower;
                    if (health > 100)
                    {
                        int healthOverflow = health - 100;
                        int partOfPotionUsed = potionPower - healthOverflow;
                        Console.WriteLine($"You healed for {partOfPotionUsed} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                       Console.WriteLine($"You healed for {potionPower} hp.");
                       Console.WriteLine($"Current health: {health} hp.");
                    }                  
                }
                else if (currRoom[0] == "chest")
                {
                    int chestPower = int.Parse(currRoom[1]);
                    bitCoins += chestPower;
                    Console.WriteLine($"You found {chestPower} bitcoins.");
                }
                else
                {
                    string monster = currRoom[0];
                    int monsterPower = int.Parse(currRoom[1]);
                    health -= monsterPower;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitCoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
