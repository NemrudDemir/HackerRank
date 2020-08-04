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
    //Bruteforce -> very bad time complexity
    //TODO improve!
    static bool larrysArray(int[] A) {
        var hadChange = false;
        do {
            hadChange = false;
            for(var i = 0; i<A.Length-2; i++) {
                while(A[i] > A[i+1] || A[i] > A[i+2]) {
                    var temp = A[i];
                    A[i] = A[i+1];
                    A[i+1] = A[i+2];
                    A[i+2] = temp;
                    hadChange = true;
                }
            }
        } while(hadChange);
        return A[A.Length-2] < A[A.Length-1];
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp))
            ;
            var result = larrysArray(A);

            textWriter.WriteLine(result ? "YES" : "NO");
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
