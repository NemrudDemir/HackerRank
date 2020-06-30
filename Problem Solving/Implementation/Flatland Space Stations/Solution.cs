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
    static int flatlandSpaceStations(int n, int[] c) {
        var dist = new int[n];
        //set distance of every element to maxValue
        for(var i = 0; i<n; i++)
            dist[i] = int.MaxValue;
        //set distance of every space station to 0
        foreach(var stat in c)
            dist[stat] = 0;
        
        var lastStatIndex = -1;
        for(var i = 0; i<n; i++) {
            if(dist[i] == 0) { //element is space station
                lastStatIndex = i;
                continue;
            }
            if(lastStatIndex < 0) //no space station found yet
                continue;
            dist[i] = i-lastStatIndex;
        }

        lastStatIndex = -1;
        //iterate reverse
        //dist[i] = min(dist[i], |i-lastStatIndex|)
        for(var i = n-1; i>=0; i--) {
            if(dist[i] == 0) { //element is space station
                lastStatIndex = i;
                continue;
            }
            if(lastStatIndex < 0) //no space station found yet
                continue;
            dist[i] = Math.Min(dist[i], lastStatIndex-i);
        }

        return dist.Max();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = flatlandSpaceStations(n, c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}