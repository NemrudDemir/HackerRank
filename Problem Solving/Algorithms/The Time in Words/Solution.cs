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
    static string timeInWords(int h, int m) {
        var numbers = new [] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
            "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty",
            "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine", "thirty"};

        //special case x:00 => x o' clock
        if(m == 0)
            return $"{numbers[h]} o' clock";

        var md = Math.Min(m, 60-m);
        //past has higher prio -> if m == 30 its 'half past' instead 'half to'!
        var rightHandSide = md == m ? $"past {numbers[h]}" : $"to {numbers[h+1]}";
        //if md == 1 (m==1|m==59) than its 'minute' instead of 'minutes'
        var leftHandSide = $"{numbers[md]} {md == 1 ? "minute" : "minutes"}";
        if(md == 15) //special case md == 15 (m==15|m==45)
            leftHandSide = "quarter";
        else if(md == 30) //special case md|m = 30
            leftHandSide = "half";

        return $"{leftHandSide} {rightHandSide}";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine());

        int m = Convert.ToInt32(Console.ReadLine());

        string result = timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
