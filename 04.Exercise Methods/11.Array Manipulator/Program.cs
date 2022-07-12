using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputIntArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {              
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);                    
                    inputIntArr = Exchange(inputIntArr, index);
                }
                else if (command[0] == "max")
                {
                    MaxOddOrEven(inputIntArr, command[1]);
                }
                else if (command[0] == "min")
                {
                    MinOddOrEven(inputIntArr, command[1]);
                }
                else if (command[0] == "first")
                {
                    int countsRequired = int.Parse(command[1]);
                    FirstCountEvenOrOdd(inputIntArr, command[2], countsRequired);          
                }
                else if (command[0] == "last")
                {
                    int countsRequired = int.Parse(command[1]);                
                    LastCountEvenOrOdd(inputIntArr, command[2], countsRequired);                   
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", inputIntArr)}]");

        }
        static int[] Exchange(int[] input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Invalid index");
                return input;
            }
            int[] exchangeArr = new int[input.Length];

            int counter = 0;
            for (int i = index + 1; i < input.Length; i++)
            {
                exchangeArr[counter] = input[i];
                counter++;
            }

            for (int i = 0; i <= index; i++)
            {
                exchangeArr[counter] = input[i];
                counter++;
            }
            return exchangeArr;
        }

        static void MaxOddOrEven(int[] input, string type)
        {
            int max = -1;
            int highestValue = int.MinValue;


            for (int i = 0; i < input.Length; i++)
            {
                if (type == "odd")
                {
                    if (input[i] % 2 != 0)
                    {
                        if (input[i] > highestValue)
                        {
                            highestValue = input[i];
                            max = i;
                        }
                        else if (input[i] == highestValue)
                        {
                            if (i > max)
                            {
                                highestValue = input[i];
                                max = i;
                            }
                        }
                    }
                }
                else if (type == "even")
                {
                    if (input[i] % 2 == 0)
                    {
                        if (input[i] > highestValue)
                        {
                            highestValue = input[i];
                            max = i;
                        }
                        else if (input[i] == highestValue)
                        {
                            if (i > max)
                            {
                                highestValue = input[i];
                                max = i;
                            }
                        }
                    }
                }
            }
            if (max > -1)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinOddOrEven(int[] input, string type)
        {
            int min = -1;
            int lowestValue = int.MaxValue;


            for (int i = 0; i < input.Length; i++)
            {
                if (type == "odd")
                {
                    if (input[i] % 2 != 0)
                    {
                        if (input[i] < lowestValue)
                        {
                            lowestValue = input[i];
                            min = i;
                        }
                        else if (input[i] == lowestValue)
                        {
                            if (i > min)
                            {
                                lowestValue = input[i];
                                min = i;
                            }
                        }
                    }
                }
                else if (type == "even")
                {
                    if (input[i] % 2 == 0)
                    {
                        if (input[i] < lowestValue)
                        {
                            lowestValue = input[i];
                            min = i;
                        }
                        else if (input[i] == lowestValue)
                        {
                            if (i > min)
                            {
                                lowestValue = input[i];
                                min = i;
                            }
                        }
                    }
                }
            }
            if (min > -1)
            {
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void FirstCountEvenOrOdd(int[] input, string type, int countRequired)
        {
            if (countRequired > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (type == "odd")
                {
                    if (input[i] % 2 != 0)
                    {
                        result.Add(input[i]);
                        counter++;
                        if (counter >= countRequired)
                        {
                            break;
                        }
                    }
                }
                else if (type == "even")
                {
                    if (input[i] % 2 == 0)
                    {
                        result.Add(input[i]);
                        counter++;
                        if (counter >= countRequired)
                        {
                            break;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
        static void LastCountEvenOrOdd(int[] input, string type, int countRequired)
        {
            if (countRequired > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            List<int> result = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (type == "odd")
                {
                    if (input[i] % 2 != 0)
                    {
                        result.Add(input[i]);
                        counter++;
                        if (counter >= countRequired)
                        {
                            break;
                        }
                    }
                }
                else if (type == "even")
                {
                    if (input[i] % 2 == 0)
                    {
                        result.Add(input[i]);
                        counter++;
                        if (counter >= countRequired)
                        {
                            break;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                result.Reverse();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
    }
}
