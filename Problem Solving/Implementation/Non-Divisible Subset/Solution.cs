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
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        var remainders = new int[k];
        foreach(var e in s)
            remainders[e%k]++;

        var result = 0;
        if(remainders[0] > 0) //if any elements with remainder == 0, take one of them
            result++;
        if(k%2 == 0) { //k is even
            if(remainders[k/2] > 0) //if any elements with remainder == k/2, take one of them
                result++;
            k--;
        }
        for(int i = 1; i<=k/2; i++) {
            var h = Math.Max(remainders[i], remainders[remainders.Length-i]);
            result += h;
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        int result = Result.nonDivisibleSubset(k, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
