using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 1; i <= ordersCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysinMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double currentTotalPrice = daysinMonth * capsulesCount * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${currentTotalPrice:f2}");
                totalPrice += currentTotalPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
