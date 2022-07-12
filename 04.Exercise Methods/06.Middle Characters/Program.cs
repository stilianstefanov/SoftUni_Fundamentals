using System;

namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleCharsFinder(input);
        }
        static void MiddleCharsFinder(string input)
        {
            char[] word = input.ToCharArray();

            if (input.Length % 2 != 0)
            {
                int counter = 0;

                for (int i = 0; i < input.Length; i++)
                {                  
                    if (i - counter == 0 && i + counter == input.Length - 1)
                    {
                        Console.WriteLine(word[i]);
                        break;
                    }
                    counter++;
                }
            }          
            else if (input.Length % 2 == 0)
            {
                int counter = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (i - counter == 0 && i + 1 + counter == input.Length - 1)
                    {
                        Console.WriteLine($"{word[i]}{word[i + 1]}");
                        break;
                    }
                    counter++;
                }
            }
        }
    }
}
