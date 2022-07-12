using System;

namespace Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split();
            string[] secondString = Console.ReadLine().Split();

            for (int i = 0; i < secondString.Length; i++)
            {
                string secondStringCurrElement = secondString[i];
                for (int j = 0; j < firstString.Length; j++)
                {
                    string firstStringCurrElement = firstString[j];
                    if (secondStringCurrElement == firstStringCurrElement)
                    {
                        Console.Write(secondStringCurrElement + " ");
                    }
                }
            }
        }
    }
}
