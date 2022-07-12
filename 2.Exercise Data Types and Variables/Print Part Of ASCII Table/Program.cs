using System;

namespace Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secondIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= secondIndex; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}
