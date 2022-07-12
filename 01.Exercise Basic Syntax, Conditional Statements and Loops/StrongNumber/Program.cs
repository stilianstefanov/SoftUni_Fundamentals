using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string inputToString = input.ToString();
            int inputNumber = input;
            int sumOfFactoriels = 0;
            
            

            for (int i = 0; i < inputToString.Length; i++)
            {
                int currentDigit = inputNumber % 10;
                int currentFactoriel = currentDigit;

                if (currentDigit == 0)
                {
                    sumOfFactoriels++;
                    inputNumber /= 10;
                    continue;
                }

                for (int j = currentDigit - 1; j >= 1; j--)
                {
                    currentFactoriel *= j;
                }

                sumOfFactoriels += currentFactoriel;
                inputNumber /= 10;
            }
            if (sumOfFactoriels == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
