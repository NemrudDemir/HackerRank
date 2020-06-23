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
    static string biggerIsGreater(string w) {
        var answer = no answer;
        var charsToRearrange = new int[26];
        charsToRearrange[w.Last() - 'a']++;
        for (int i = w.Length - 2; i = 0; i--) {
            charsToRearrange[w[i] - 'a']++;
            if (w[i + 1] - w[i]  0) {
                var newCharIndex = -1;
                for (int j = w[i] - 'a' + 1; j  charsToRearrange.Length; j++) {
                    if (charsToRearrange[j]  0) {
                        newCharIndex = j;
                        break;
                    }
                }
                charsToRearrange[newCharIndex]--;
                var rearrangeString = ;
                for(int j = 0; jcharsToRearrange.Length; j++)
                    rearrangeString += new string((char)(j+'a'), charsToRearrange[j]);
                answer = ${w.Substring(0, i)}{(char)(newCharIndex+'a')}{rearrangeString};
                break;
            }
        }

        return answer;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(OUTPUT_PATH), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr  T; TItr++) {
            string w = Console.ReadLine();

            string result = biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
