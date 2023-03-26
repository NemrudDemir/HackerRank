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

class Solution
{
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr, int n)
    {
        double positives = 0;
        double negatives = 0;
        double zeroes = 0;

        foreach (int number in arr)
        {
            if (number > 0)
                positives++;
            else if (number < 0)
                negatives++;
            else
                zeroes++;
        }

        Console.WriteLine($"{positives / n:0.000000}");
        Console.WriteLine($"{negatives / n:0.000000}");
        Console.WriteLine($"{zeroes / n:0.000000}");
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr, n);
    }
}