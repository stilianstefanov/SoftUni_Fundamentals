using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] fieldArr = new int[fieldSize];
            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                int currentBugIndex = ladyBugsIndexes[i];
                if (currentBugIndex >= 0 && currentBugIndex < fieldSize)
                {
                    fieldArr[currentBugIndex] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandToArray = command.Split().ToArray();
                int innitialIndex = int.Parse(commandToArray[0]);
                string direction = commandToArray[1];
                int flyLength = int.Parse(commandToArray[2]);
                bool isFirst = true;
                while (innitialIndex >= 0 && innitialIndex < fieldSize && fieldArr[innitialIndex] != 0)
                {
                    if (isFirst)
                    {
                        fieldArr[innitialIndex] = 0;
                        isFirst = false;
                    }
                    if (direction == "right")
                    {
                        innitialIndex += flyLength;
                        if (innitialIndex < fieldSize && innitialIndex >= 0)
                        {
                            if (fieldArr[innitialIndex] == 0)
                            {
                                fieldArr[innitialIndex] = 1;
                                break;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        innitialIndex -= flyLength;
                        if (innitialIndex < fieldSize && innitialIndex >= 0)
                        {
                            if (fieldArr[innitialIndex] == 0)
                            {
                                fieldArr[innitialIndex] = 1;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(' ', fieldArr));
        }
    }
}
