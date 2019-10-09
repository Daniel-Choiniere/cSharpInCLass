
using System;

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int BribeCounter = 0;
        bool alreadyLogged = false;

        for (int k = 0; k < q.Length; k++)
        {
            if ((k + 1 - q[k]) < -2)
            {
                Console.WriteLine("Too chaotic");
                alreadyLogged = true;
                break;
            }
        }

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
        if (alreadyLogged == false)
        {
            Console.WriteLine(BribeCounter);
        }
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}



