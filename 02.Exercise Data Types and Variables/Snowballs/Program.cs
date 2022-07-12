using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;
            BigInteger bestSnowBall = int.MinValue;
            string bestFormula = "";

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                snowBallSnow = int.Parse(Console.ReadLine());
                snowBallTime = int.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger currentValue = snowBallSnow / snowBallTime;
                BigInteger currentSnowBallValue = BigInteger.Pow(currentValue, snowBallQuality);

                if (currentSnowBallValue > bestSnowBall)
                {
                    bestSnowBall = currentSnowBallValue;
                    bestFormula = $"{snowBallSnow} : {snowBallTime} = {bestSnowBall} ({snowBallQuality})";
                }
            }
            Console.WriteLine(bestFormula);
        }
    }
}
