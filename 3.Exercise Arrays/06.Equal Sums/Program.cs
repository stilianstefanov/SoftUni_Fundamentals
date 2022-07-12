using System;
using System.Linq;

namespace Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            if (inputArr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < inputArr.Length; i++)
            {
                int currentNumIndex = i;

                int rightSum = 0;
                for (int rightIndex = currentNumIndex + 1; rightIndex < inputArr.Length; rightIndex++)
                {
                    rightSum += inputArr[rightIndex];
                }
                int leftSum = 0;
                for (int leftIndex = currentNumIndex - 1; leftIndex >= 0; leftIndex--)
                {
                    leftSum += inputArr[leftIndex];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(currentNumIndex);
                    return;
                }                
            }
            Console.WriteLine("no");
        }
    }
}
