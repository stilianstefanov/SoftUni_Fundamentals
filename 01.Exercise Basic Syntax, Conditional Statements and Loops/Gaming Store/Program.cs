using System;

namespace Gaming_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double moneySpent = 0;

            string command;
            while ((command = Console.ReadLine()) != "Game Time")
            {
                string currentGame = command;

                if (currentGame == "OutFall 4")
                {
                    if (budget - 39.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 39.99;
                    moneySpent += 39.99;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else if (currentGame == "CS: OG")
                {
                    if (budget - 15.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 15.99;
                    moneySpent += 15.99;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else if (currentGame == "Zplinter Zell")
                {
                    if (budget - 19.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 19.99;
                    moneySpent += 19.99;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else if (currentGame == "Honored 2")
                {
                    if (budget - 59.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }   
                    budget -= 59.99;
                    moneySpent += 59.99;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else if (currentGame == "RoverWatch")
                {
                    if (budget - 29.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }   
                    budget -= 29.99;
                    moneySpent += 29.99;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else if (currentGame == "RoverWatch Origins Edition")
                {
                    if (budget - 39.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }   
                    budget -= 39.99;
                    moneySpent += 39.99;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${budget:f2}");
        }
    }
}
