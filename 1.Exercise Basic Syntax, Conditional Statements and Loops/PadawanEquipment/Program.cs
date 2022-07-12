using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightSaberToAdd = Math.Ceiling(studentsCount * 0.10);
            double lightSaberCount = studentsCount + lightSaberToAdd;

            double beltsFree = Math.Floor(studentsCount / 6.0);
            double beltsCount = studentsCount - beltsFree;

            double robesCount = studentsCount;

            double lightsabersTotalPrice = lightSaberPrice * lightSaberCount;
            double beltsTotalPrice = beltPrice * beltsCount;
            double robesTotalPrice = robePrice * robesCount;
            double totalPrice = lightsabersTotalPrice + beltsTotalPrice + robesTotalPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }

        }
    }
}
