using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            int[] evenArr = new int[linesCount];
            int[] oddArr = new int[linesCount];

            for (int i = 0; i < linesCount; i++)
            {
                int[] currentInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArr[i] = currentInput[0];
                    oddArr[i] = currentInput[1];
                }
                else if (i % 2 != 0)
                {
                    oddArr[i] = currentInput[0];
                    evenArr[i] = currentInput[1];
                }
            }
            Console.WriteLine(String.Join(" ", evenArr));
            Console.WriteLine(String.Join(" ", oddArr));
        }
    }
}
