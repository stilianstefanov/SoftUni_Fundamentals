using System;

namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int winsCount = 0;

            string command = Console.ReadLine();
            while (command != "End of battle")
            {
                int currDistance = int.Parse(command);

                if (energy >= currDistance)
                {
                    energy -= currDistance;
                    winsCount++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {energy} energy");
                    return;
                }

                if (winsCount % 3 == 0)
                {
                    energy += winsCount;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {winsCount}. Energy left: {energy}");
        }
    }
}
