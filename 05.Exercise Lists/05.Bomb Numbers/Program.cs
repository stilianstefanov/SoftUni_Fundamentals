using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] numberAndPower = Console.ReadLine().Split();

            int numberToRemove = int.Parse(numberAndPower[0]);
            int power = int.Parse(numberAndPower[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numberToRemove)
                {
                    if (i - power < 0 || i + power >= numbers.Count)
                    {
                        if (i - power < 0 && i + power < numbers.Count)
                        {
                            numbers.RemoveRange(0, i + power + 1);
                        }
                        else if (i - power >= 0 && i + power >= numbers.Count)
                        {
                            numbers.RemoveRange(i - power, numbers.Count - i + power);
                        }
                        else if (i - power < 0 && i + power >= numbers.Count)
                        {
                            numbers.RemoveRange(0, numbers.Count);
                        }
                    }
                    else
                    {
                        int countOfNumbersToDel = power * 2 + 1;
                        numbers.RemoveRange(i - power, countOfNumbersToDel);
                    }
                    i = -1;
                }
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
