using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(num => Convert.ToInt32(num))
                .ToArray();

            int bestStart = 0;
            int bestLength = 1;
            

            int currStart = 0;
            int currLength = 1;
            

            for (int i = 1; i < arr.Length; i++)
            {
                
                if (arr[i] != arr[i - 1])
                {
                    if (currLength > bestLength)
                    {
                        bestLength = currLength;
                        bestStart = currStart;                        
                    }
                    currStart = i;
                    currLength = 1;                    
                }
                else
                {                    
                    currLength++;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
