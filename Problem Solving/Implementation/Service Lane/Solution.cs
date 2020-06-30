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
    static int ServiceLane(int[] widths, int i, int j) {
        var min = int.MaxValue;
        for(var k = i; k<=j; k++)
            min = Math.Min(min, widths[k]);
        return min;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nt = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nt[0]);

        int t = Convert.ToInt32(nt[1]);

        int[] widths = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp));

        for (int i = 0; i < t; i++) {
            var ij = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            var result = ServiceLane(widths, ij[0], ij[1]);
            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
