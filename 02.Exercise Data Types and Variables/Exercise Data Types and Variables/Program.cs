using System;

namespace Exercise_Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int result = number1 + number2;
            result /= number3;
            result *= number4;
            Console.WriteLine(result);
        }
    }
}
