using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputAge = int.Parse(Console.ReadLine());

            if (inputAge <=2)
            {
                Console.WriteLine("baby");
            }
            else if (inputAge <= 13)
            {
                Console.WriteLine("child");
            }
            else if (inputAge <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (inputAge <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (inputAge >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
