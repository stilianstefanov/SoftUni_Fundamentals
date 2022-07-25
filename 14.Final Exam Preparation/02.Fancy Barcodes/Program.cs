using System;
using System.Text.RegularExpressions;

namespace _02.Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCnt = int.Parse(Console.ReadLine());
            string pattern = @"@[#]+([A-Z][A-Za-z\d]{4,}[A-Z])@[#]+";

            for (int i = 0; i < inputCnt; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    string digitPattern = @"\d";
                    MatchCollection digits = Regex.Matches(input, digitPattern);

                    if (digits.Count > 0)
                    {
                        string productGroup = string.Join("", digits);

                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
