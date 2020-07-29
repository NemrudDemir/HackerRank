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
    //cycles:
    //cycle[0] = {1,2,3}
    //cycle[1] = {4,5,6,7,8,9}
    //...
    static long strangeCounter(long t) {
        var cycle = (int)Math.Log((t-1)/3+1, 2); //cycle-index
        var cycleStart = 3*((long)Math.Pow(2, cycle)-1)+1; //first number in same cycle as t
        var cycleStartValue = cycleStart + 2; //first value in cycle

        return cycleStartValue - (t - cycleStart);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt64(Console.ReadLine());

        long result = strangeCounter(t);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
