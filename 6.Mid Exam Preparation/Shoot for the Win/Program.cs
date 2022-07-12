using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotCount = 0;

            string command = Console.ReadLine();
            while (command != "End")
            {
                int targetIndex = int.Parse(command);

                if (targetIndex >= 0 && targetIndex < numbers.Length)
                {
                    int targetValue = numbers[targetIndex];
                    if (numbers[targetIndex] == -1)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers[targetIndex] = -1;
                    shotCount++;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i == targetIndex)
                        {                           
                            continue;
                        }
                        if (numbers[i] == -1)
                        {
                            continue;
                        }

                        if (targetValue < numbers[i])
                        {
                            numbers[i] -= targetValue;
                        }
                        else
                        {
                            numbers[i] += targetValue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotCount} -> {string.Join(" ", numbers)}");
        }
    }
}
