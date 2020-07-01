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

    // Complete the cavityMap function below.
    static string[] cavityMap(string[] grid) {
        for(var i = 1; i<grid.Length-1; i++) {
            for(var j = 1; j<grid[i].Length-1; j++) {
                var c = grid[i][j];
                if(c > grid[i][j+1] &&
                c > grid[i][j-1] &&
                c > grid[i+1][j] &&
                c > grid[i-1][j]) {
                    grid[i] = $"{grid[i].Substring(0, j)}X{grid[i].Substring(j+1)}";
                    j++; //we know that the next cell was smaller than the current one
                }
            }
        }
        return grid;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] grid = new string [n];

        for (int i = 0; i < n; i++) {
            string gridItem = Console.ReadLine();
            grid[i] = gridItem;
        }

        string[] result = cavityMap(grid);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
