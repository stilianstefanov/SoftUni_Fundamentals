using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double avarage = Math.Round(numbers.Average(), 2);

            List<int> topNumbers = new List<int>();

            int numbersAdded = 0;
            foreach (int number in numbers)
            {
                if (number > avarage)
                {
                    topNumbers.Add(number);
                    numbersAdded++;
                }
            }

            if (numbersAdded == 0)
            {
                Console.WriteLine("No");
                return;
            }

            topNumbers.Sort();
            topNumbers.Reverse();

            int counter = 0;
            foreach (int num in topNumbers)
            {
                Console.Write($"{num} ");
                counter++;

                if (counter == 5)
                {
                    break;
                }
            }
        }
    }
}
