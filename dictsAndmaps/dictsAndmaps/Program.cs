using System;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) 
    {
        
        var numOfArgs = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> dc = new Dictionary<string, string>();

        for (var i = 0; i < numOfArgs; i++) 
        {
            string[] array = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToArray(); 

            foreach (string s in array)
            {
                //create new array from string
                string[] array2 = s.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                //add new keyvaluepair to dictionary.
                dc.Add(array2[0], array2[1]);

                Console.WriteLine(dc);
            }
         
        }
        
    }
}
