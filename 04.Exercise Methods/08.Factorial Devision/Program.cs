using System;

namespace Factorial_Devision_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factorielFirstNum = FactorialCalc(num1);
            double factorielSecondNum = FactorialCalc(num2);

            Console.WriteLine($"{factorielFirstNum / factorielSecondNum:f2}");
        }

        static double FactorialCalc(int number)
        {
            double result = 1;
            
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
