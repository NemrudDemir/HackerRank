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
    static int minimumDistances(int[] a) {
        var result = -1;
        var lastIndexOf = new Dictionary<int, int>();
        for(var i = 0; i<a.Length; i++) {
            var n = a[i];
            if(lastIndexOf.ContainsKey(n)) {
                var distance = i - lastIndexOf[n];
                result = result < 0 ? distance : Math.Min(result, distance);
            }
            lastIndexOf[n] = i;
        }

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
