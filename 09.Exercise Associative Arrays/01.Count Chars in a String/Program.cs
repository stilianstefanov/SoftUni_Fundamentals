using System;
using System.Collections.Generic;

namespace _01.Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word = string.Join("", input);

            Dictionary <char, int> chars = new Dictionary<char, int>();

            foreach (var charr in word)
            {
                if (!chars.ContainsKey(charr))
                {
                    chars.Add(charr, 0);
                }
                chars[charr]++;
            }
            foreach (var charr in chars)
            {
                Console.WriteLine($"{charr.Key} -> {charr.Value}");
            }
        }
    }
}
