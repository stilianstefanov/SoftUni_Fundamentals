using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Complete")
            {
                switch (command[0])
                {
                    case "Make":
                        {
                            string state = command[1];
                            int atIndex = int.Parse(command[2]);
                            if (!char.IsLetter(inputString[atIndex]))
                            {
                                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }

                            if (state == "Upper")
                            {
                                char toUpper = char.ToUpper(inputString[atIndex]);
                                inputString = inputString.Remove(atIndex, 1);
                                inputString = inputString.Insert(atIndex, toUpper.ToString());
                                Console.WriteLine(inputString);
                            }
                            else if (state == "Lower")
                            {
                                char toLower = char.ToLower(inputString[atIndex]);
                                inputString = inputString.Remove(atIndex, 1);
                                inputString = inputString.Insert(atIndex, toLower.ToString());
                                Console.WriteLine(inputString);
                            }
                            else
                            {
                                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                        }
                        break;
                    case "Insert":
                        int atIndexI = int.Parse(command[1]);
                        char charToInsert = char.Parse(command[2]);
                        if (atIndexI >= 0 && atIndexI < inputString.Length)
                        {
                            inputString = inputString.Insert(atIndexI, charToInsert.ToString());
                            Console.WriteLine(inputString);
                        }
                        break;
                    case "Replace":
                        {
                            char chToReplace = char.Parse(command[1]);
                            int valueToSum = int.Parse(command[2]);
                            if (inputString.Contains(chToReplace))
                            {
                                int newCharCode = chToReplace + valueToSum;
                                char newChar = (char)newCharCode;
                                inputString = inputString.Replace(chToReplace, newChar);
                                Console.WriteLine(inputString);
                            }
                        }
                        break;
                    case "Validation":
                        {
                            if (inputString.Length < 8)
                            {
                                Console.WriteLine("Password must be at least 8 characters long!");
                            }
                            for (int i = 0; i < inputString.Length; i++)
                            {
                                if (!char.IsLetterOrDigit(inputString[i]) && inputString[i] != '_')
                                {
                                    Console.WriteLine("Password must consist only of letters, digits and _!");
                                    break;
                                }
                            }
                            bool isUpper = false;
                            for (int i = 0; i < inputString.Length; i++)
                            {
                                if (char.IsUpper(inputString[i]))
                                {
                                    isUpper = true;
                                    break;
                                }
                            }
                            if (isUpper == false)
                            {
                                Console.WriteLine("Password must consist at least one uppercase letter!");
                            }

                            bool isLower = false;
                            for (int i = 0; i < inputString.Length; i++)
                            {
                                if (char.IsLower(inputString[i]))
                                {
                                    isLower = true;
                                    break;
                                }
                            }
                            if (isLower == false)
                            {
                                Console.WriteLine("Password must consist at least one lowercase letter!");
                            }


                            bool isDigit = false;
                            for (int i = 0; i < inputString.Length; i++)
                            {
                                if (char.IsDigit(inputString[i]))
                                {
                                    isDigit = true;
                                    break;
                                }
                            }
                            if (isDigit == false)
                            {
                                Console.WriteLine("Password must consist at least one digit!");
                            }
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
