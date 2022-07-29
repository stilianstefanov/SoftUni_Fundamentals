using System;
using System.Text;

namespace _01.Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Done")
            {
                switch (command[0])
                {
                    case "TakeOdd":
                        input = TakeOdd(input);
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(command[1]);
                        int length = int.Parse(command[2]);

                        input = input.Remove(startIndex, length);
                        Console.WriteLine(input);
                        break;
                    case "Substitute":
                        if (input.Contains(command[1]))
                        {
                            input = input.Replace(command[1], command[2]);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Your password is: {input}");
        }

        private static string TakeOdd(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(input[i]);
                }
            }            

            return sb.ToString();
        }
    }
}
