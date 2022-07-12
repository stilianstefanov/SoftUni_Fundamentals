using System;
using System.Linq;

namespace The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_CAPACITY = 4;
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < lift.Length; i++)
            {
                int currWagon = lift[i];
                int spaceAvaliable = MAX_CAPACITY - currWagon;
                if (spaceAvaliable == 0)
                {
                    continue;
                }

                if (spaceAvaliable > peopleWaiting)
                {
                    lift[i] += peopleWaiting;
                    peopleWaiting = 0;
                    
                }
                else
                {
                    lift[i] += spaceAvaliable;
                    peopleWaiting -= spaceAvaliable;
                }

                if (peopleWaiting <= 0)
                {                   
                    break;
                }              
            }
            bool isLiftFull = true;
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] != 4)
                {
                    isLiftFull = false;
                }
            }

            if (peopleWaiting == 0 && isLiftFull == false)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (peopleWaiting > 0 && isLiftFull == true)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (peopleWaiting == 0 && isLiftFull == true)
            {
                Console.WriteLine(String.Join(" ", lift));
            }
        }
    }
}
