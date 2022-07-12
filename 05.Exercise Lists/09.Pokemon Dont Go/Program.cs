using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Dont_Go
{
    internal class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<int> numbersArr = Console.ReadLine().Split().Select(int.Parse).ToList();

            int removedElementsSum = 0;
            while (numbersArr.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    int elementToRemove = numbersArr[0];
                    removedElementsSum += numbersArr[0];
                    numbersArr[0] = numbersArr[numbersArr.Count - 1];

                    for (int i = 0; i < numbersArr.Count; i++)
                    {
                        if (numbersArr[i] <= elementToRemove)
                        {
                            numbersArr[i] += elementToRemove;
                        }
                        else
                        {
                            numbersArr[i] -= elementToRemove;
                        }
                    }

                }
                else if (currentIndex >= numbersArr.Count)
                {
                    int elementToRemove = numbersArr[numbersArr.Count - 1];
                    removedElementsSum += numbersArr[numbersArr.Count - 1];
                    numbersArr[numbersArr.Count - 1] = numbersArr[0];

                    for (int i = 0; i < numbersArr.Count; i++)
                    {
                        if (numbersArr[i] <= elementToRemove)
                        {
                            numbersArr[i] += elementToRemove;
                        }
                        else
                        {
                            numbersArr[i] -= elementToRemove;
                        }
                    }
                }
                else
                {
                    int currentIndexValue = numbersArr[currentIndex];
                    numbersArr.RemoveAt(currentIndex);
                    removedElementsSum += currentIndexValue;

                    for (int i = 0; i < numbersArr.Count; i++)
                    {
                        if (numbersArr[i] <= currentIndexValue)
                        {
                            numbersArr[i] += currentIndexValue;
                        }
                        else
                        {
                            numbersArr[i] -= currentIndexValue;
                        }
                    }
                }              
            }
            Console.WriteLine(removedElementsSum);
        }
    }
}
