using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();
            int turn = 1;

            while (command[0] != "end")
            {
                int firstIndex = int.Parse(command[0]);
                int secondIndex = int.Parse(command[1]);
                if (firstIndex == secondIndex 
                    || firstIndex < 0
                    || firstIndex >= numbers.Count
                    || secondIndex < 0
                    || secondIndex >= numbers.Count)
                {
                    numbers.Insert(numbers.Count / 2, $"-{turn}a");
                    numbers.Insert(numbers.Count / 2, $"-{turn}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");                   
                }
                else if (numbers[firstIndex] == numbers[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");
                    string elementToRemove = numbers[firstIndex];
                    numbers.Remove(elementToRemove);
                    numbers.Remove(elementToRemove);                    
                }
                else if (numbers[firstIndex] != numbers[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {turn} turns!");

                    return;
                }
                turn++;
                command = Console.ReadLine().Split();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
