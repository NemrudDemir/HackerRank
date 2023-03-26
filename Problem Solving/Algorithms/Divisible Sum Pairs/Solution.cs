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

class Solution {

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar) {
        var mod = new Dictionary<int, int>();
        foreach(var a in ar) {
            var remainder = a%k;
            if(!mod.ContainsKey(remainder))
                mod.Add(remainder,1);
            else
                mod[remainder]++;
        }
        var result = 0;
        foreach(var remainder in mod.Keys) {
            var counterpart = (k-remainder)%k;
            if(counterpart > remainder || !mod.ContainsKey(counterpart))
                continue;
            if(remainder == counterpart)
                result += mod[remainder]*(mod[remainder]-1)/2;
            else
                result += mod[remainder]*mod[counterpart];
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
