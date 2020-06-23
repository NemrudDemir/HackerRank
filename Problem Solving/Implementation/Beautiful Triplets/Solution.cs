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
    static int beautifulTriplets(int d, int[] arr) {
        //we save the array in a dictionary <number, total appearances>
        var count = new Dictionary<int, int>();
        foreach(var a in arr) {
            if(!count.ContainsKey(a))
                count.Add(a, 0);
            count[a]++;
        }

        var result = 0;
        foreach(var i in count.Keys) { //iterate every number
            var j = i+d; //expected j
            var k = j+d; //expected k
            //if j or k are not in our dictionary, there is no triplet for this i,j,k
            if(!count.ContainsKey(j) || !count.ContainsKey(k)) 
                continue;
            //if j and k are in dictionary, count all combinations
            result += count[i] * count[j] * count[k]; //all combinations
        }

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
