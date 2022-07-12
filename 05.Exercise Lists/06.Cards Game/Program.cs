using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

           
            for (int i = 0; i < Math.Min(deck1.Count, deck2.Count); i++)
            {
                if (deck1[i] > deck2[i])
                {
                    deck1.Add(deck2[i]);
                    deck1.Add(deck1[i]);
                    deck1.RemoveAt(i);
                    deck2.RemoveAt(i);
                    i--;
                }
                else if (deck1[i] < deck2[i])
                {
                    deck2.Add(deck1[i]);
                    deck2.Add(deck2[i]);
                    deck2.RemoveAt(i);
                    deck1.RemoveAt(i);
                    i--;
                }
                else
                {
                    deck1.RemoveAt(i);
                    deck2.RemoveAt(i);
                    i--;
                }
            }
            if (deck1.Count > deck2.Count)
            {
                int sum = deck1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = deck2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
