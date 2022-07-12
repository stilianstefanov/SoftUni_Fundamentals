using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "Go")
            {
                switch (command[0])
                {
                    case "Urgent":
                        string itemToInsert = command[1];
                        Urgent(products, itemToInsert);
                        break;
                    case "Unnecessary":
                        string itemToRemove = command[1];
                        RemoveItem(products, itemToRemove);
                        break;
                    case "Correct":
                        string oldName = command[1];
                        string newName = command[2];
                        Correct(products, oldName, newName);
                        break;
                    case "Rearrange":
                        string itemToMove = command[1];
                        Rearrange(products, itemToMove);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", products));
        }

        static void Rearrange(List<string> products, string itemToMove)
        {
            if (!products.Contains(itemToMove))
            {
                return;
            }
            products.Add(itemToMove);
            products.Remove(itemToMove);
        }

        static void Correct(List<string> products, string oldName, string newName)
        {
            if (!products.Contains(oldName))
            {
                return;
            }

            int oldnameIndex = -1;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] == oldName)
                {
                    oldnameIndex = i;
                }
            }
            products[oldnameIndex] = newName;
        }

        static void RemoveItem(List<string> products, string itemToRemove)
        {
            if (!products.Contains(itemToRemove))
            {
                return;
            }
            products.Remove(itemToRemove);
        }

        static void Urgent(List<string> products, string itemToInsert)
        {
            if (products.Contains(itemToInsert))
            {
                return;
            }
            products.Insert(0, itemToInsert);
        }
    }
}
