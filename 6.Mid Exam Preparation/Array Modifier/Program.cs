using System;
using System.Linq;

namespace Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    inputArr = SwapElements(inputArr, index1, index2);
                }
                else if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    inputArr = MultiplyElements(inputArr, index1, index2);
                }
                else if (command[0] == "decrease")
                {
                    inputArr = DecreaseElemets(inputArr);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(", ", inputArr));
        }

        static int[] SwapElements(int[] inputArr, int index1, int index2)
        {
            int temp = inputArr[index1];
            inputArr[index1] = inputArr[index2];
            inputArr[index2] = temp;
            return inputArr;
        }

        static int[] MultiplyElements(int[] inputArr, int index1, int index2)
        {
            int result = inputArr[index1] * inputArr[index2];
            inputArr[index1] = result;
            return inputArr;
        }

        static int[] DecreaseElemets(int[] inputArr)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i] = inputArr[i] - 1;
            }
            return inputArr;
        }
    }
}
