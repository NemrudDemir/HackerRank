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

    // Complete the bonAppetit function below.
    static void bonAppetit(List<int> bill, int k, int b) {
        var sum = 0;
        //add all items to sum except "k"
        for(int i = 0;i<k; i++)
            sum += bill[i];
        for(int i = k+1; i<bill.Count; i++)
            sum += bill[i];
        
        //as stated in the problem description it's always an integer
        //so we dont have to cast as double/float
        var fairPrice = sum/2;
        if(fairPrice == b)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(b-fairPrice);
    }

    static void Main(string[] args) {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}
