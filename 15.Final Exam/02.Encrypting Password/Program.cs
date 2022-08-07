using System;
using System.Text.RegularExpressions;

namespace _03.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string pattern = @"(?<sep>.+)>(?<digits>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<anysumb>[^><]{3})<(\k<sep>)";

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string digits = match.Groups["digits"].Value;
                    string lowers = match.Groups["lower"].Value;
                    string uppers = match.Groups["upper"].Value;
                    string anySumbols = match.Groups["anysumb"].Value;

                    string encryptedPass = digits + lowers + uppers + anySumbols;
                    Console.WriteLine($"Password: {encryptedPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
