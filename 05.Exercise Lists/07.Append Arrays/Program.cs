using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').Reverse().ToArray();
            string temporal = string.Join(" ", input);
            string[] rezult = temporal.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}
