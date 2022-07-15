using System;

namespace _03.Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");

            string[] fileAndExt = path[path.Length - 1].Split('.');

            string file = fileAndExt[0];
            string ext = fileAndExt[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
