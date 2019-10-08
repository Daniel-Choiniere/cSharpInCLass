using System;
using System.Collections.Generic;

class MainClass
{
    static int FirstDuplicateNumber(int[] array)
    {
        List<int> NumbersInList = new List<int>();
        List<int> NumToCheck = new List<int>();

        foreach (int number in array) NumbersInList.Add(number);
        

        foreach (int item in NumbersInList)
        {
            if (NumToCheck.IndexOf(item) != -1) return item;
            NumToCheck.Add(item);
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int[] theArray = { 1, 3, 5, 3, 7, 9 };
        Console.WriteLine(FirstDuplicateNumber(theArray));
    }
}


