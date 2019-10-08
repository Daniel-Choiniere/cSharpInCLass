using System;
using System.Collections.Generic;

class MainClass
{
    static int FirstDuplicateNumber(int[] array)
    {
        List<int> NumbersInList = new List<int>();
        List<int> NumToCheck = new List<int>();

        foreach (int number in array)
        {
            NumbersInList.Add(number);
        }

        for (int i = 0; i < NumbersInList.Count; i++)
        {
            NumToCheck.Add(NumbersInList[i]);

            NumbersInList.Remove(NumbersInList[i]);

            if (NumToCheck.IndexOf(NumbersInList[0]) != -1)
            {
                return NumbersInList[i];
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int[] theArray = { 1, 3, 5, 3, 7, 9 };
        Console.WriteLine(FirstDuplicateNumber(theArray));
    }
}


