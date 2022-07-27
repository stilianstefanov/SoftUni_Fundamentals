using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<sep>[\/=])(?<name>[A-Z][A-Za-z]{2,})(\k<sep>)";

            MatchCollection matches = Regex.Matches(input, pattern);

            int travelPoints = 0;

            foreach (Match match in matches)
            {
                travelPoints += match.Groups["name"].Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", matches.Select(match => match.Groups["name"]))}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
