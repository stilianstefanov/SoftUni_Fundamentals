using System;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceWithoutTaxes = 0;
            double taxes = 0;

            string command = Console.ReadLine();
            while (command != "special")
            {
                if (command == "regular")
                {
                    break;
                }
                double currPrice = double.Parse(command);
                if (currPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                priceWithoutTaxes += currPrice;
                taxes += currPrice * 0.20;

                command = Console.ReadLine();
            }
            if (priceWithoutTaxes <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double totalPrice = priceWithoutTaxes + taxes;
            if (command == "special")
            {
                totalPrice -= totalPrice * 0.10;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");

        }
    }
}
