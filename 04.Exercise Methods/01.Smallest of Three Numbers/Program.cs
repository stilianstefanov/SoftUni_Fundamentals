using System;

namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Compare(number1, number2, number3));
        }
        static int Compare(int number1, int number2, int number3)
        {
            int[] arr = { number1, number2, number3 };
            Array.Sort(arr);
            return arr[0];
        }
    }
}
