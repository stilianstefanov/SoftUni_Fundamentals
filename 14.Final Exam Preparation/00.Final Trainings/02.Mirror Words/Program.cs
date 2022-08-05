using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mirrorWords = new List<string>();
            
            string input = Console.ReadLine();
            string pattern = @"(?<sep>[#@])(?<word1>[A-Za-z]{3,})(\k<sep>){2}(?<word2>[A-Za-z]{3,})(\k<sep>)";

            MatchCollection validMatches = Regex.Matches(input, pattern);

            if (validMatches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }

            foreach (Match match in validMatches)
            {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;

                string word2Reversed = string.Join("", word2.Reverse().ToArray());
                    
                if (word1 == word2Reversed)
                {
                    string concatString = $"{word1} <=> {word2}";
                    mirrorWords.Add(concatString);
                }
            }

            Console.WriteLine($"{validMatches.Count} word pairs found!");
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", mirrorWords));
        }
    }
}
