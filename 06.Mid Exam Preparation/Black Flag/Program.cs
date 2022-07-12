using System;

namespace Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysPlunder = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double targetPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= daysPlunder; i++)
            {
                totalPlunder += plunderPerDay;

                if (i % 3 == 0)
                {
                    double additionalPlunder = plunderPerDay * 0.50;
                    totalPlunder += additionalPlunder;
                }
                if (i % 5 == 0)
                {
                    double plunderLost = totalPlunder * 0.30;
                    totalPlunder -= plunderLost;
                }
            }

            if (totalPlunder >= targetPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentPlunder = totalPlunder / targetPlunder * 100.00;
                Console.WriteLine($"Collected only {percentPlunder:f2}% of the plunder.");
            }
        }
    }
}
