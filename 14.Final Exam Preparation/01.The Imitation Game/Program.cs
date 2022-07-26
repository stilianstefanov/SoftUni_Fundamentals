using System;

namespace _01.The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split("|");
            while (command[0] != "Decode")
            {
                switch (command[0])
                {
                    case "Move":
                        int numberOfLetters = int.Parse(command[1]);
                        string substringToMove = input.Substring(0, numberOfLetters);
                        input += substringToMove;
                        input = input.Remove(0, numberOfLetters);
                        break;
                    case "Insert":
                        int atIndex = int.Parse(command[1]);
                        string valueToInsert = command[2];
                        input = input.Insert(atIndex, valueToInsert);
                        break;
                    case "ChangeAll":
                        string substringToReplace = command[1];
                        string newValue = command[2];
                        input = input.Replace(substringToReplace, newValue);
                        break;
                }
                command = Console.ReadLine().Split("|");
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
