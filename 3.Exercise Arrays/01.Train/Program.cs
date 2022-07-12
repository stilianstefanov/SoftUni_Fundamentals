using System;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[linesCount];

            int sum = 0;
            for (int i = 0; i < linesCount; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}
