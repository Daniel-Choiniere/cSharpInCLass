using System;
using System.Collections.Generic;

namespace NewYearChaos
{
    class MainClass
    {
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
            //foreach (int item in q)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (int item in q)
            {

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



