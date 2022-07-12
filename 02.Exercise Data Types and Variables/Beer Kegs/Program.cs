using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());

            string modelBiggestKeg = "";
            decimal volumeBiggestKeg = decimal.MinValue;

            for (int i = 0; i < countOfInputs; i++)
            {
                string modelCurrent = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * radius * radius * height;
                if (volume > volumeBiggestKeg)
                {
                    volumeBiggestKeg = volume;
                    modelBiggestKeg = modelCurrent;
                }
            }
            Console.WriteLine(modelBiggestKeg);
        }
    }
}
