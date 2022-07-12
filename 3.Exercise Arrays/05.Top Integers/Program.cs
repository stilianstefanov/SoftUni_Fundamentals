using System;
using System.Linq;

namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                bool isBigger = true;
                for (int j = i + 1; j < input.Length; j++)
                {                   
                    int comparableNum = input[j];
                    if (currentNum <= comparableNum)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger == true)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
