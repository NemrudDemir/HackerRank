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
    static int[] acmTeam(string[] topic, int m) {
        var max = 0;
        var count = 0;

        for(int i = 0; i<topic.Length; i++) {
            var a = topic[i];
            for(int j = i+1; j<topic.Length; j++) {
                var b = topic[j];
                var counter = 0;
                for(int k = 0; k<m; k++) {
                    if(a[k] == '1' || b[k] == '1')
                        counter++;
                }
                if(counter > max) {
                    max = counter;
                    count = 1;
                } else if(counter == max)
                    count++;
            }
        }

        return new [] {max, count};
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        string[] topic = new string [n];

        for (int i = 0; i < n; i++) {
            string topicItem = Console.ReadLine();
            topic[i] = topicItem;
        }

        int[] result = acmTeam(topic, m);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
