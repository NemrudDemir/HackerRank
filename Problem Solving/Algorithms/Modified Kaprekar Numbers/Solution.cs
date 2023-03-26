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
    static void kaprekarNumbers(int p, int q) {
        var results = new List<int>();
        for (int i = p; i <= q; i++)
        {
            var square = (long)i * i; //int could overflow (up to 10^10)
            var mod = (int)Math.Pow(10, (int)Math.Log10(i)+1);
            var r = square % mod;
            var l = square / mod;
            if (r + l == i)
                results.Add(i);
        }

        Console.WriteLine(results.Any() ? string.Join(" ", results) : "INVALID RANGE");
    }

    static void Main(string[] args) {
        int p = Convert.ToInt32(Console.ReadLine());

        int q = Convert.ToInt32(Console.ReadLine());

        kaprekarNumbers(p, q);
    }
}
