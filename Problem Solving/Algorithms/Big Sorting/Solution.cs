using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'bigSorting' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY unsorted as parameter.
     */

    public static List<string> bigSorting(List<string> unsorted)
    {
        var result = new List<string> { unsorted[0] };
        for(var i = 1; i<unsorted.Count; i++) {
            var binarySearch = BinarySearch(unsorted[i], result);
            result.Insert(binarySearch, unsorted[i]);
        }
        
        return result;
    }
    
    private static int BinarySearch(string value, List<string> sorted)
    {
        int min = 0;
        int max = sorted.Count;

        var pointer = 0;
        while (min != max)
        {
            pointer = (max + min) / 2;
            var compare = Compare(value, sorted[pointer]);
            if (compare == 0)
                return pointer;

            if(max - min <= 1) {
                if (compare > 0)
                    return pointer + 1;
                return pointer;
            }

            if (compare > 0)
                min = pointer;
            else
                max = pointer;
        }

        return pointer;
    }
    
    //returns 1 if x is bigger than y
    //returns -1 if y is bigger than x
    //returns 0 if x and y are equal
    private static short Compare(string x, string y) {
        if(x.Length > y.Length)
            return 1;
        if(x.Length < y.Length)
            return -1;
            
        for(var i = 0; i<x.Length; i++) {
            if(x[i] > y[i])
                return 1;
            if(x[i] < y[i])
                return -1;
        }
        
        return 0;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> unsorted = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string unsortedItem = Console.ReadLine();
            unsorted.Add(unsortedItem);
        }

        List<string> result = Result.bigSorting(unsorted);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
