using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {     
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadsets = 0;
            int brokenMouses = 0;
            int brokenKeyboards = 0;
            int brokenDisplays = 0;

            int currentBrokenKeyboardsCounter = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    brokenHeadsets++;
                }
                if (i % 3 == 0)
                {
                    brokenMouses++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    brokenKeyboards++;
                    currentBrokenKeyboardsCounter++;
                }
                if (currentBrokenKeyboardsCounter % 2 == 0)
                {
                    if (currentBrokenKeyboardsCounter == 0)
                    {
                        continue;
                    }
                    brokenDisplays++;
                    currentBrokenKeyboardsCounter = 0;
                }
            }
            double brokenHeadsetsCost = brokenHeadsets * headSetPrice;
            double brokenMousesCost = brokenMouses * mousePrice;
            double brokenKeyboardsCost = brokenKeyboards * keyboardPrice;
            double brokenDisplayCost = brokenDisplays * displayPrice;
            double totalPrice = brokenHeadsetsCost + brokenMousesCost + brokenKeyboardsCost + brokenDisplayCost;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");


        }
    }
}
