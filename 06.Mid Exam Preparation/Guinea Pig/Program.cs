using System;

namespace Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MONTH_LENGTH = 30;
            const decimal FOOD_PER_DAY = 0.300m;
            decimal foodKg = decimal.Parse(Console.ReadLine());
            decimal hayKg = decimal.Parse(Console.ReadLine());
            decimal coverKg = decimal.Parse(Console.ReadLine());
            decimal pigWeight = decimal.Parse(Console.ReadLine());

            bool isEnough = true;

            for (int i = 1; i <= MONTH_LENGTH; i++)
            {
               
                foodKg -= FOOD_PER_DAY;

                if (i % 2 == 0)
                {
                    decimal currHaytoGive = foodKg * 0.05m;
                    hayKg -= currHaytoGive;
                }

                if (i % 3 == 0)
                {
                    decimal coverToGive = pigWeight / 3;
                    coverKg -= coverToGive;
                }

                if (foodKg <= 0 || hayKg <= 0 || coverKg <= 0)
                {
                    isEnough = false;
                    break;
                }

            }
            if (isEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
