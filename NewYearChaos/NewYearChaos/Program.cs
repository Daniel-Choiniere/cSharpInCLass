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


        //add in logic to check if swaps are more than 2

        static int MinimumBribes(int[] q)
        {
            int BribeCounter = 0;

            for (int j = 0; j < q.Length; j++)
            {
                for (int i = 1; i < q.Length; i++)
                {
                    if (q[i] < q[i - 1])
                    {
                        BribeCounter++;

                        int temp;
                        temp = q[i - 1];
                        q[i - 1] = q[i];
                        q[i] = temp;
                    }
                }
            }
            return BribeCounter;
        }

        public static void Main(string[] args)
        {
            //not valid
            //int[] array = { 2, 5, 1, 3, 4 };

            //valid
            int[] array = { 2, 1, 5, 3, 4 };
            

            int totalNumberOfBribes = MinimumBribes(array);

            Console.WriteLine(totalNumberOfBribes);
        }
    }
}



