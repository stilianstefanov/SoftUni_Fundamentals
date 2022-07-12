using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int WORKERS_SHARE = 26;
            const int YELD_DECREASE = 10;
            int startingYeld = int.Parse(Console.ReadLine());
            int currentYeld = startingYeld;

            int totalSpiceExtracted = 0;
            int workingDays = 0;

            while (currentYeld >= 100)
            {
                totalSpiceExtracted += currentYeld;
                if (totalSpiceExtracted < WORKERS_SHARE)
                {
                    totalSpiceExtracted = 0;
                }
                else
                {
                    totalSpiceExtracted -= WORKERS_SHARE;
                }
                currentYeld -= YELD_DECREASE;
                workingDays++;
            }
            if (totalSpiceExtracted < WORKERS_SHARE)
            {
                totalSpiceExtracted = 0;
            }
            else
            {
                totalSpiceExtracted -= WORKERS_SHARE;
            }       
            Console.WriteLine(workingDays);
            Console.WriteLine(totalSpiceExtracted);

        }
    }
}
