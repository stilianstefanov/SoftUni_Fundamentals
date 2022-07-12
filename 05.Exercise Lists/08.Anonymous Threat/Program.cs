using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dataArr = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "3:1")
            {
                switch (command[0])
                {
                    case "merge":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        MergeStrings(dataArr, startIndex, endIndex);
                        break;
                    case "divide":
                        int atIndex = int.Parse(command[1]);
                        int patritions = int.Parse(command[2]);
                        DivideStrings(dataArr, atIndex, patritions);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", dataArr));
        }

        static void DivideStrings(List<string> dataArr, int atIndex, int patritions)
        {
            List<string> substrings = new List<string>();
            int substringsLength = dataArr[atIndex].Length / patritions;
            string currSubString = dataArr[atIndex];
            int additionalSubstringLength = dataArr[atIndex].Length % patritions;

            for (int i = 0; i < patritions; i++)
            {
                if (i == patritions - 1) substringsLength += additionalSubstringLength;
                substrings.Add(currSubString.Substring(0, substringsLength));
                currSubString = currSubString.Remove(0, substringsLength);
            }

            dataArr.RemoveAt(atIndex);
            dataArr.InsertRange(atIndex, substrings);
        }


        static void MergeStrings(List<string> dataArr, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex >= dataArr.Count)
            {
                if (startIndex < 0 && endIndex < dataArr.Count)
                {
                    for (int i = 0; i < endIndex; i++)
                    {
                        dataArr[0] += dataArr[0 + 1];
                        dataArr.RemoveAt(0 + 1);
                    }
                }
                else if (startIndex >= 0 && endIndex >= dataArr.Count)
                {
                    int timesToLoop = dataArr.Count - 1 - startIndex;
                    for (int i = 0; i < timesToLoop; i++)
                    {
                        dataArr[startIndex] += dataArr[startIndex + 1];
                        dataArr.RemoveAt(startIndex + 1);
                    }
                }
                else
                {
                    int timesToLoop = dataArr.Count - 1;
                    for (int i = 0; i < timesToLoop; i++)
                    {
                        dataArr[0] += dataArr[0 + 1];
                        dataArr.RemoveAt(0 + 1);
                    }
                }
            }
            else
            {
                int timesToLoop = endIndex - startIndex;
                for (int i = 0; i < timesToLoop; i++)
                {
                    dataArr[startIndex] += dataArr[startIndex + 1];
                    dataArr.RemoveAt(startIndex + 1);
                }
            }
        }
    }
}

