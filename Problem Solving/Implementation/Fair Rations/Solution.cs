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
    static int fairRations(int[] B) {
        var result = 0;
        for(var i = 0; i<B.Length-1; i++) {
            if(B[i]%2==0)
                continue;
            B[i]++;
            B[i+1]++;
            result+=2;
        }

        //if last element is odd -> return -1 (NO)
        return B[B.Length-1]%2 == 0 ? result : -1; 
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine());

        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
        ;
        int result = fairRations(B);
        textWriter.WriteLine(result < 0 ? "NO" : result.ToString());

        textWriter.Flush();
        textWriter.Close();
    }
}
