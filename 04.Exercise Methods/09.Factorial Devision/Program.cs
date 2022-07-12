using System;
using System.Linq;

namespace Factorial_Devision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                bool isPalindrome = IsPalindrome(input);
                Console.WriteLine(isPalindrome);
            }
        }

        static bool IsPalindrome(string number)
        {
            bool isPalindrome = true;
            int[] digits = new int[number.Length];
            int[] digitsReverse = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                digits[i] = number[i];
                digitsReverse[i] = number[i];
            }
            Array.Reverse(digitsReverse);

            for (int i = 0; i < number.Length; i++)
            {
                if (digits[i] != digitsReverse[i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
