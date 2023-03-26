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
    static int[] stones(int n, int a, int b) {
        if(a == b)
            return new[] {(n-1)*a};

        //make a < b
        if(a > b) {
            var temp = a;
            a = b;
            b = temp;
        }

        //there are always n results
        var result = new int[n];
        result[0] = (n-1)*a; //the smallest result
        for(var i = 1; i<n; i++)
            result[i] = result[i-1] + (b-a); //take the previous result and use b instead of a

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int[] result = stones(n, a, b);

            textWriter.WriteLine(string.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
