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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr) {
        var dict = new Dictionary<int, int>(); //number, counter
        foreach(var e in arr) {
            if(!dict.ContainsKey(e))
                dict.Add(e, 0);
            dict[e]++;
        }
        var result = new int[dict.Keys.Count];
        var elementCount = arr.Length;
        var keysSorted = dict.Keys.OrderBy(x => x).ToArray();
        for(var i = 0; i<dict.Keys.Count; i++) {
            result[i] = elementCount;
            elementCount -= dict[keysSorted[i]];
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
