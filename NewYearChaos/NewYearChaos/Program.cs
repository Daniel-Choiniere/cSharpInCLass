using System;
using System.Collections.Generic;

namespace NewYearChaos
{
    class MainClass
    {
        //public static bool IsSorted(List<int> list)
        //{
        //    for (int i = 1; i < list.Count; i++)
        //    {
        //        if (list[i - 1] > list[i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        static int MinimumBribes(int[] q)
        {
            List<int> LineQueue = BuildList(q);

            int BribeCounter = 0;

            for (int j = 0; j < LineQueue.Count; j++)
            {
                for (int i = 1; i < LineQueue.Count; i++)
                {
                    //add in logic to check if swaps are more than 2

                    if (LineQueue[i] < LineQueue[i - 1])
                    {
                        BribeCounter++;

                        int temp;
                        temp = LineQueue[i - 1];
                        LineQueue[i - 1] = LineQueue[i];
                        LineQueue[i] = temp;
                    }
                }
            }
            return BribeCounter;
        }

        private static List<int> BuildList(int[] q)
        {
            List<int> Queue = new List<int>();

            foreach (int item in q)
                Queue.Add(item);

            return Queue;
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 3, 4, 7, 8, 6 };

            int totalNumberOfBribes = MinimumBribes(array);

            Console.WriteLine(totalNumberOfBribes);
        }
    }
}



