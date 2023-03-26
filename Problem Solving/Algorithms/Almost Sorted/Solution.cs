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
    static void almostSorted(int[] arr) {
        var sorted = arr.OrderBy(x => x).ToArray();

        var wrongIndices = new List<int>();
        for(var i = 0; i<arr.Length; i++) {
            if(arr[i] == sorted[i])
                continue;

            wrongIndices.Add(i);
        }
        if(!wrongIndices.Any()) {
            Console.WriteLine("yes");
            return;
        }

        if(wrongIndices.Count == 2) {
            Console.WriteLine("yes");
            Console.WriteLine($"swap {wrongIndices[0]+1} {wrongIndices[1]+1}");
            return;
        }

        //check for reverse
        var firstIndex = wrongIndices[0];
        var lastIndex = wrongIndices.Last();
        var isReversed = true;
        for(var i = firstIndex; i<lastIndex; i++) {
            if(arr[i] > arr[i+1])
                continue;
            
            isReversed = false;
            break;
        }

        if(isReversed) {
            Console.WriteLine("yes");
            Console.WriteLine($"reverse {firstIndex+1} {lastIndex+1}");
            return;
        }

        Console.WriteLine("no");
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        almostSorted(arr);
    }
}
