using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojiPattern = @"(?<sep>::|\*\*)(?<name>[A-Z][a-z]{2,})(\k<sep>)";

            BigInteger coolFactor = GetCoolFactor(input);

            List<string> allEmoji = new List<string>();
            List<string> allCool = new List<string>();

            MatchCollection emojis = Regex.Matches(input, emojiPattern);

            foreach (Match emoji in emojis)
            {
                int currEmojiCoolness = GetCoolness(emoji);
                allEmoji.Add(emoji.Value);

                if (currEmojiCoolness >= coolFactor)
                {
                    allCool.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolFactor}");
            Console.WriteLine($"{allEmoji.Count} emojis found in the text. The cool ones are:");
            foreach (var coolEmoji in allCool)
            {
                Console.WriteLine(coolEmoji);
            }
        }

        private static int GetCoolness(Match emoji)
        {
            string letterPattern = @"[A-Za-z]";
            MatchCollection lettermatches = Regex.Matches(emoji.Value, letterPattern);

            int sum = 0;

            char[] letters = lettermatches.Select(letter => char.Parse(letter.Value)).ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                sum += letters[i];
            }

            return sum;
        }

        private static BigInteger GetCoolFactor(string input)
        {
            string digitPattern = @"\d";
            BigInteger coolFactor = 1;
            MatchCollection digits = Regex.Matches(input, digitPattern);
            if (digits.Count == 0)
            {
                coolFactor = 0;

                return coolFactor;
            }
            
            int[] ints = digits
                .Select(digit => int.Parse(digit.Value))
                .ToArray();

            for (int i = 0; i < digits.Count; i++)
            {
                coolFactor *= ints[i];
            }

            return coolFactor;
        }
    }
}
