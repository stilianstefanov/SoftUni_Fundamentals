using System;

namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personAKPD = int.Parse(Console.ReadLine());
            int personBKPD = int.Parse(Console.ReadLine());
            int personCKPD = int.Parse(Console.ReadLine());
            int customersCount = int.Parse(Console.ReadLine());

            int totalKPDperHour = personAKPD + personBKPD + personCKPD;
            TimeCalc(totalKPDperHour, customersCount);
        }

        static void TimeCalc(int kpdPerHour, int custemrsCount)
        {
            int hourCounter = 0;
            int breakCounter = 0;

            while (custemrsCount > 0)
            {
                if (breakCounter == 3)
                {
                    breakCounter = 0;
                    hourCounter++;
                    continue;
                }
                custemrsCount -= kpdPerHour;
                hourCounter++;
                breakCounter++;
            }
            Console.WriteLine($"Time needed: {hourCounter}h.");
        }
    }
}
