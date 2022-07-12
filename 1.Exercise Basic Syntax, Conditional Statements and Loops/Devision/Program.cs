using System;

namespace Devision
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInt = int.Parse(Console.ReadLine());

            if (inputInt % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (inputInt % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (inputInt % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (inputInt % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (inputInt % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
