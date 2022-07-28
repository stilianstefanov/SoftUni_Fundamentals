using System;
using System.Text;

namespace _01.Secret_Chat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(":|:");
            while (command[0] != "Reveal")
            {
                switch (command[0])
                {
                    case "InsertSpace":
                        int indexToInsert = int.Parse(command[1]);
                        input = input.Insert(indexToInsert, " ");
                        break;
                    case "Reverse":
                        string stringToReverse = command[1];

                        if (input.Contains(stringToReverse))
                        {
                            string reversedString = RevStr(stringToReverse);

                            int startIndex = input.IndexOf(stringToReverse);

                            input = input.Remove(startIndex, stringToReverse.Length);

                            input += reversedString;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            command = Console.ReadLine().Split(":|:");
                            continue;
                        }
                        break;
                    case "ChangeAll":
                        string substringToReplace = command[1];
                        string newSubstring = command[2];

                        input = input.Replace(substringToReplace, newSubstring);
                        break;                    
                }
                Console.WriteLine(input);
                command = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {input}");
        }

        private static string RevStr(string stringToReverse)
        {
            StringBuilder result = new StringBuilder();

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                result.Append(stringToReverse[i]);
            }

            return result.ToString();
        }
    }
}
