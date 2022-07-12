using System;
using System.Text;

namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string output = AsciiTableChecker(firstChar, secondChar);
            Console.WriteLine(output);
        }
        static string AsciiTableChecker(char firstChar, char secondChar)
        {
            StringBuilder output = new StringBuilder();

            if (secondChar < firstChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                output.Append(Convert.ToChar(i));
                output.Append(" ");
            }
            return output.ToString();
        }
    }
}
