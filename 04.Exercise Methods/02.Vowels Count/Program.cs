using System;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = VowelCounter(input);
            Console.WriteLine(result);
        }
        static int VowelCounter(string input)
        {
            int counter = 0;
            char[] word = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (word[i] == 65 || word[i] == 69 || input[i] == 73 || input[i] == 79 || input[i] == 85 || input[i] == 97 || input[i] == 101 || input[i] == 105 || input[i] == 111 || input[i] == 117)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
