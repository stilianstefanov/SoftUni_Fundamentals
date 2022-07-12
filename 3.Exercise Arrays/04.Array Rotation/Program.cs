using System;
using System.Linq;

namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationCount; i++)
            {
                int tempFirstNum = inputArr[0];
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    inputArr[j] = inputArr[j + 1];                 
                }
                inputArr[inputArr.Length - 1] = tempFirstNum;
            }
            Console.WriteLine(String.Join(" ", inputArr));
        }
    }
}
