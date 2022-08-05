using System;
using System.Linq;
using System.Text;

namespace _01.Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "Done")
            {
                switch (command[0])
                {
                    case "TakeOdd":
                        inputString = GetOdd(inputString);
                        Console.WriteLine(inputString);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(command[1]);
                        int length = int.Parse(command[2]);
                        inputString = inputString.Remove(startIndex, length);
                        Console.WriteLine(inputString);
                        break;
                    case "Substitute":
                        if (inputString.Contains(command[1]))
                        {
                            inputString = inputString.Replace(command[1], command[2]);
                            Console.WriteLine(inputString);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }                
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Your password is: {inputString}");
        }

        private static string GetOdd(string inputString)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i < inputString.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Append(inputString[i]);
                }
            }

            return result.ToString();
        }
    }
}
