using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(command[1]);
                        numbers.RemoveAll(number => number == numberToDelete);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int atIndex = int.Parse(command[2]);
                        numbers.Insert(atIndex, numberToInsert);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
