using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int totalFilled = 0;
            int pourCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pourCount; i++)
            {
                int currentPour = int.Parse(Console.ReadLine());
                if ((capacity - currentPour) < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                totalFilled += currentPour;
                capacity -= currentPour;
            }
            Console.WriteLine(totalFilled);
        }
    }
}
