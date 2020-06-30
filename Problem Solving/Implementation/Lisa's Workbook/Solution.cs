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
    static int workbook(int n, int k, int[] arr) {
        if(k == 1) //special case for faster runtime - O(1) instead of O(n)
            return arr[0];

        var result = 0;
        var chapter = 0;
        var chapterPage = 0;
        var page = 0;
        while(chapter < n) { //we iterate every page and check if special chapter exists
            page++;
            var min = chapterPage*k+1;
            var max = Math.Min(min+k-1, arr[chapter]);
            if(page >= min && page<= max)
                result++;
            if(max == arr[chapter]) { //end of chapter - start new chapter
                chapter++;
                chapterPage = 0;
            } else {
                chapterPage++;
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}