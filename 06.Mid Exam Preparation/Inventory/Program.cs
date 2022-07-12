using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(" - ");
            while (command[0] != "Craft!")
            {
                switch (command[0])
                {
                    case "Collect":
                        string itemToAdd = command[1];
                        CollectItem(inventory, itemToAdd);
                        break;
                    case "Drop":
                        string itemToRemove = command[1];
                        DropItem(inventory, itemToRemove);
                        break;
                    case "Combine Items":
                        string[] oldAndNewItem = command[1].Split(":");
                        string oldItem = oldAndNewItem[0];
                        string newItem = oldAndNewItem[1];
                        CombineItems(inventory, oldItem, newItem);
                        break;
                    case "Renew":
                        string itemToRenew = command[1];
                        RenewItem(inventory, itemToRenew);
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }
            Console.WriteLine(string.Join(", ", inventory));
        }

        static void RenewItem(List<string> inventory, string itemToRenew)
        {
            if (!inventory.Contains(itemToRenew))
            {
                return;
            }
            inventory.Add(itemToRenew);
            inventory.Remove(itemToRenew);
        }

        static void CombineItems(List<string> inventory, string oldItem, string newItem)
        {
            if (!inventory.Contains(oldItem))
            {
                return;
            }
            int oldItemIndex = -1;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == oldItem)
                {
                    oldItemIndex = i;
                    break;
                }
            }
            inventory.Insert(oldItemIndex + 1, newItem);
        }

        static void DropItem(List<string> inventory, string itemToRemove)
        {
            if (!inventory.Contains(itemToRemove))
            {
                return;
            }
            inventory.Remove(itemToRemove);
        }

        static void CollectItem(List<string> inventory, string itemToAdd)
        {
            if (inventory.Contains(itemToAdd))
            {
                return;
            }
            inventory.Add(itemToAdd);
        }
    }
}
