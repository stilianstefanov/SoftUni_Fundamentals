using System;

namespace Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPower = int.Parse(Console.ReadLine());
            int power = startingPower;
            int distance = int.Parse(Console.ReadLine());
            int specialFactor = int.Parse(Console.ReadLine());

            int pokeCount = 0;

            while (power >= distance)
            {
                power -= distance;
                pokeCount++;

                if (startingPower * 0.5 == power && specialFactor > 0)
                {
                    power /= specialFactor;
                }
               
            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
        }
    }
}
