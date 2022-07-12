using System;

namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 97; i < (97 + count); i++)
            {
                for (int j = 97; j < (97 + count); j++)
                {
                    for (int k = 97; k < (97 + count); k++)
                    {
                        char firtLetter = Convert.ToChar(i);
                        char secondLetter = Convert.ToChar(j);
                        char thirdLetter = Convert.ToChar(k);

                        Console.Write($"{firtLetter}{secondLetter}{thirdLetter}");
                        Console.WriteLine();
                    }
                }
            }
                  
        }
    }
}
