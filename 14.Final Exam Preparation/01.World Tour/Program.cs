using System;

namespace _01.Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string innitialString = Console.ReadLine();

            string[] command = Console.ReadLine().Split(":");
            while (command[0] != "Travel")
            {
                switch (command[0])
                {
                    case "Add Stop":
                        int startIndex = int.Parse(command[1]);
                        string stopToAdd = command[2];
                        if (startIndex >= 0 && startIndex < innitialString.Length)
                        {
                             innitialString = innitialString.Insert(startIndex, stopToAdd);
                        }
                        break;
                    case "Remove Stop":
                        int startIndexToRemove = int.Parse(command[1]);
                        int endIndexToRemove = int.Parse(command[2]);

                        if (startIndexToRemove >= 0 && startIndexToRemove < innitialString.Length
                            && endIndexToRemove >= 0 && endIndexToRemove < innitialString.Length)
                        {
                            innitialString = innitialString.Remove(startIndexToRemove, endIndexToRemove - startIndexToRemove + 1);
                        }                        
                        break;
                    case "Switch":
                        string oldString = command[1];
                        string newString = command[2];

                        if (innitialString.Contains(oldString))
                        {
                            innitialString = innitialString.Replace(oldString, newString);
                        }
                        break;
                }
                Console.WriteLine(innitialString);
                command = Console.ReadLine().Split(":");
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {innitialString}");
        }
    }
}
