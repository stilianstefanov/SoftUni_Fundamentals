using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int toIndex = int.Parse(command[2]);
                        InsertNumber(numbers, numberToInsert, toIndex);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        RemoveNumber(numbers, indexToRemove);
                        break;
                    case "Shift":
                        string direction = command[1];
                        int count = int.Parse(command[2]);
                        Shift(numbers, count, direction);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Shift(List<int> numbers, int count, string direction)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }

        static void RemoveNumber(List<int> numbers, int indexToRemove)
        {
            if (indexToRemove < 0 || indexToRemove >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            numbers.RemoveAt(indexToRemove);
        }

        static void InsertNumber(List<int> numbers, int numberToInsert, int toIndex)
        {
            if (toIndex < 0 || toIndex >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            numbers.Insert(toIndex, numberToInsert);
        }
    }
}
