using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoneyAccomulated = 0;

            string input;

            while ((input = Console.ReadLine()) != "Start")
            {
                double inputCurrentMoney = double.Parse(input);
                if (inputCurrentMoney == 0.1 || inputCurrentMoney == 0.2 || inputCurrentMoney == 0.5 || inputCurrentMoney == 1 || inputCurrentMoney == 2)
                {
                    totalMoneyAccomulated += inputCurrentMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputCurrentMoney}");
                }

            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                double totalPrice = 0;

                if (command == "Nuts")
                {
                    totalPrice = 2.0;
                }
                else if (command == "Water")
                {
                    totalPrice = 0.7;
                }
                else if (command == "Crisps")
                {
                    totalPrice = 1.5;
                }
                else if (command == "Soda")
                {
                    totalPrice = 0.8;
                }
                else if (command == "Coke")
                {
                    totalPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (totalMoneyAccomulated < totalPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {command.ToLower()}");
                    totalMoneyAccomulated -= totalPrice;
                }
            }
            Console.WriteLine($"Change: {totalMoneyAccomulated:f2}");
        }
    }
}
