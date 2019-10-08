using System;
using System.Collections.Generic;

namespace NewYearChaos
{
    class MainClass
    {
        static int MinimumBribes(int[] q)
        {

            List<int> Queue = new List<int>();
            int BribeCounter = 0;

            foreach (int item in q)
            {
                Queue.Add(item);
            }

            for (int i = 1; i < Queue.Count; i++)
            {
                //add in logic to check if swaps are more than 2

                //our loop will not go back through the array to check for swapping again
                if (Queue[i] < Queue[i - 1])
                {
                    BribeCounter++;
                    Console.WriteLine(BribeCounter);
                    Queue[i] = Queue[i - 1];
                }
            }
            return BribeCounter;
        }
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 3, 7, 8, 6, 4 };
            Console.WriteLine(MinimumBribes(array));
        }
    }
}



