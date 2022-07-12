using System;

namespace Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Operation(num1, num2, num3));
        }

        static int Operation(int num1, int num2, int num3)
        {
            int result = SumOfFirstTwo(num1, num2) - num3;
            return result;
        }
        static int SumOfFirstTwo(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
