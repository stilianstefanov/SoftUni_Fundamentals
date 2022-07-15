using System;
using System.Numerics;

namespace _05.Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            BigInteger result = firstNum * secondNum;
            Console.WriteLine(result);
        }
    }
}
