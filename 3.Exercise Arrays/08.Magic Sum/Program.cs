using System;
using System.Linq;

namespace Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inpputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magiNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inpputArr.Length - 1; i++)
            {               
                for (int j = i + 1; j < inpputArr.Length; j++)
                {
                    int currentSum = inpputArr[i] + inpputArr[j];
                    if (currentSum == magiNum)
                    {
                        Console.WriteLine($"{inpputArr[i]} {inpputArr[j]}");
                    }
                }
               
            }
        }
    }
}
