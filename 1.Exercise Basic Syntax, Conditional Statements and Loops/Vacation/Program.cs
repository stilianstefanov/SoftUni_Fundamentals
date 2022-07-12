using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfpeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWheek = Console.ReadLine();

            double pricefor1person = 0;
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWheek == "Friday")
                {
                    pricefor1person = 8.45;
                }
                else if (dayOfWheek == "Saturday")
                {
                    pricefor1person = 9.80;
                }
                else if (dayOfWheek == "Sunday")
                {
                    pricefor1person = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfWheek == "Friday")
                {
                    pricefor1person = 10.90;
                }
                else if (dayOfWheek == "Saturday")
                {
                    pricefor1person = 15.60;
                }
                else if (dayOfWheek == "Sunday")
                {
                    pricefor1person = 16.00;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWheek == "Friday")
                {
                    pricefor1person = 15.00;
                }
                else if (dayOfWheek == "Saturday")
                {
                    pricefor1person = 20.00;
                }
                else if (dayOfWheek == "Sunday")
                {
                    pricefor1person = 22.50;
                }
            }
            totalPrice = pricefor1person * countOfpeople;

            if (groupType == "Students" && countOfpeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (groupType == "Business" && countOfpeople >= 100)
            {
                totalPrice -= pricefor1person * 10;
            }
            else if (groupType == "Regular" && countOfpeople >= 10 && countOfpeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
