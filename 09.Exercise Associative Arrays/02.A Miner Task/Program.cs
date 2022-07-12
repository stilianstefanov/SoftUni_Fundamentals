using System;
using System.Collections.Generic;

namespace _02.A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> recourses = new Dictionary<string, long>();

            while (true)
            {
                string recourseName = Console.ReadLine();
                if (recourseName == "stop")
                {
                    break;
                }
                long recourseQty = long.Parse(Console.ReadLine());

                if (!recourses.ContainsKey(recourseName))
                {
                    recourses.Add(recourseName, 0);
                }
                recourses[recourseName] += recourseQty;
            }

            foreach (var item in recourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
