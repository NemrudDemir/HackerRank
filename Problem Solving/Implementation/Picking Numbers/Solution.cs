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

    public static int pickingNumbers(List<int> a)
    {
        //Map the elements to a dictionary (number, count)
        var elementCount = new Dictionary<int, int>();
        foreach(var element in a) {
            if(!elementCount.ContainsKey(element))
                elementCount.Add(element, 0);
            elementCount[element]++;
        }

        var max = 0;
        foreach(var key in elementCount.Keys) {
            var result = elementCount[key];
            //check if there is a "smallKey" which is exactly 1 number below
            //the current key
            var smallKey = key-1;
            if(elementCount.ContainsKey(smallKey)) {
                result += elementCount[smallKey];
            }
            max = Math.Max(max, result);
        }

        return max;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
