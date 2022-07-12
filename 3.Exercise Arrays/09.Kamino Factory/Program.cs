using System;
using System.Linq;

namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[sequenceLength];
            int bestCounter = - 1;
            int beststartingIndex = -1;
            int bestSum = 0;
            int samples = 0;
            int bestSample = 0;
            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentCounter = 0;
                int currentfinalIndex = 0;
                int currentstartingIndex = 0;
                int currentSum = 0;
                bool isBest = false;
                samples++;

                int counter = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {

                    if (currentDNA[i] != 1)
                    {
                        counter = 0;
                        continue;
                    }
                    counter++;
                    if (counter > currentCounter)
                    {
                        currentCounter = counter;
                        currentfinalIndex = i;
                    }
                }
                currentstartingIndex = currentfinalIndex - currentCounter + 1;
                currentSum = currentDNA.Sum();
                if (currentCounter > bestCounter)
                {
                    bestCounter = currentCounter;
                    isBest = true;
                }
                else if (currentCounter == bestCounter)
                {
                    if (currentstartingIndex < beststartingIndex)
                    {
                        isBest = true;
                    }
                    else if (currentstartingIndex == beststartingIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            isBest = true;
                        }
                    }
                }
                if (isBest)
                {
                    beststartingIndex = currentstartingIndex;
                    bestDNA = currentDNA;
                    bestSum = currentSum;
                    bestSample = samples;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
