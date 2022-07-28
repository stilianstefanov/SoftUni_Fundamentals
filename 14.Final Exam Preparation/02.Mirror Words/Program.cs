using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mirrorWords = new List<string>();

            string input = Console.ReadLine();

            string pattern = @"(?<sep>[#@])(?<word1>[A-Za-z]{3,})(\k<sep>)(\k<sep>)(?<word2>[A-Za-z]{3,})(\k<sep>)";

            MatchCollection validMatches = Regex.Matches(input, pattern);

            if (validMatches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }

            foreach (Match match in validMatches)
            {
                string firstWord = match.Groups["word1"].Value;
                string secondWord = match.Groups["word2"].Value;

                string reversedSecondWord = GetReversed(secondWord);

                if (firstWord == reversedSecondWord)
                {
                    StringBuilder wordToAdd = new StringBuilder();

                    wordToAdd.Append(firstWord);
                    wordToAdd.Append(" <=> ");
                    wordToAdd.Append(secondWord);

                    mirrorWords.Add(wordToAdd.ToString());
                }
            }

            Console.WriteLine($"{validMatches.Count} word pairs found!");
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }

        private static string GetReversed(string secondWord)
        {
            StringBuilder result = new StringBuilder();

            for (int i = secondWord.Length - 1; i >= 0; i--)
            {
                result.Append(secondWord[i]);
            }

            return result.ToString();
        }
    }
}
