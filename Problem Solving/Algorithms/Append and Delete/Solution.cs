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
    static string appendAndDelete(string s, string t, int k) {
        const string YES = "Yes";
        const string NO = "No";

        if(s.Length < t.Length) { //make s always the longer string & t shorter string
            var temp = s;
            s = t;
            t = temp;
        }

        var lengthDif = s.Length - t.Length;
        k -= lengthDif;
        if(k < 0) //too many operations needed to make t and s same length
            return NO;
        
        var remainder = k%2; //we need to check if it's exactly with k moves possible
        k /= 2;

        if(k >= t.Length) //we can delete all characters and build the "t"-string
            return YES;

        if(remainder == 1) //special case - delete all chars AND atleast once more to build string with EXACTLY k moves
            return k > t.Length*2 ? YES : NO;

        return s.Substring(0, t.Length - k) == t.Substring(0, t.Length - k) ? YES : NO;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
