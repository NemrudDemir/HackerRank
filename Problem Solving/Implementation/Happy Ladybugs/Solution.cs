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
    static string happyLadybugs(string b) {
        //case no empty cells
        if(!b.Contains("_")) {
            b = $".{b}."; //add padding for outOfBounds handling
            for(var i = 1; i<b.Length-1; i++) { //Start from 1 because of paddings
                if(b[i] != b[i-1] && b[i] != b[i+1])
                    return "NO";
            }
            return "YES";
        }

        //case with atleast 1 empty cell
        var colorsCount = new Dictionary<char, int>();
        foreach(var color in b) {
            if(color < 'A' || color > 'Z') //not a color
                continue;
            if(!colorsCount.ContainsKey(color))
                colorsCount.Add(color, 0);
            colorsCount[color]++;
        }

        //if there is only one ladybug of color x, the ladybug cant be happy!
        return colorsCount.Any(x => x.Value == 1) ? "NO" : "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine());

        for (int gItr = 0; gItr < g; gItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            string b = Console.ReadLine();

            string result = happyLadybugs(b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
