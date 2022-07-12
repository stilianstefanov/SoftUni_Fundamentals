using System;

namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= end; i++)
            {
                bool isDivisible = IsSumDivisible(i);
                bool isOddDigit = IsContainOddDigit(i);

                if (isDivisible && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsSumDivisible(int number)
        {
            bool isDivisible = false;
            int sum = 0;

            while (number > 0)
            {
                int curDigit = number % 10;
                sum += curDigit;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }
        static bool IsContainOddDigit(int number)
        {
            bool isValid = false;

            while (number > 0)
            {
                int curDigit = number % 10;
                if (curDigit % 2 != 0)
                {
                    isValid = true;
                    break;
                }
                number /= 10;
            }
            return isValid;
        }
    }
}
