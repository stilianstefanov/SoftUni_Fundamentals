using System;
using System.Text;

namespace _01.Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string[] tokens = Console.ReadLine().Split(">>>");
            while (tokens[0] != "Generate")
            {
                switch (tokens[0])
                {
                    case "Contains":
                        string currSubstring = tokens[1];
                        if (activationKey.Contains(currSubstring))
                        {
                            Console.WriteLine($"{activationKey} contains {currSubstring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        activationKey = FlipLetters(activationKey, tokens);
                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }
                tokens = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static string FlipLetters(string activationKey, string[] tokens)
        {
            StringBuilder result = new StringBuilder(activationKey);

            string toUpperOrLower = tokens[1];
            int startIndex = int.Parse(tokens[2]);
            int endIndex = int.Parse(tokens[3]);

            if (toUpperOrLower == "Upper")
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    result[i] = char.ToUpper(result[i]);                    
                }
            }
            else
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    result[i] = char.ToLower(result[i]);
                }
            }
            return result.ToString();
        }
    }
}
