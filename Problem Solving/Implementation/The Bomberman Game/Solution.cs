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
    static string[] bomberMan(int n, string[] grid) {
        var r = grid.Length;
        var c = grid[0].Length;

        var iGrid = sGridToIGrid(grid);
        var actN = 0;
        var maxN = Math.Min(n, n%4+4); //the patterns are recurring
        while(actN < maxN)
            SecondPass(ref actN, ref iGrid);

        return iGridToSGrid(iGrid);
    }

    static int[,] sGridToIGrid(string[] grid) {
        var r = grid.Length;
        var c = grid[0].Length;

        var iGrid = new int[r,c];
        for(var iR = 0; iR < r; iR++) {
            for(var iC = 0; iC < c; iC++) {
                iGrid[iR, iC] = grid[iR][iC] == '.' ? 0 : 3;
            }
        }

        return iGrid;
    }

    static void SecondPass(ref int n, ref int[,] grid) {
        var r = grid.GetLength(0);
        var c = grid.GetLength(1);

        n++;
        if(n%2==0) { //place bombs and decrease timer
            for(var i = 0; i<r; i++)
                for(var j = 0; j<c; j++)
                    grid[i,j] = grid[i,j] == 0 ? 3 : grid[i,j]-1;
        } else { //only decrease timer
            //bombs only explode on odd n
            var indicesToExplode = new List<int[]>();
            for(var i = 0; i<r; i++) {
                for(var j = 0; j<c; j++) {
                    if(grid[i,j] == 0)
                        continue;

                    grid[i,j] = grid[i,j]-1;
                    if(grid[i,j] == 0) { //explode!
                        indicesToExplode.Add(new [] {i,j});
                    }
                }
            }

            foreach(var index in indicesToExplode) {
                var i = index[0];
                var j = index[1];
                TrySet(ref grid, i+1, j, 0);
                TrySet(ref grid, i-1, j, 0);
                TrySet(ref grid, i, j+1, 0);
                TrySet(ref grid, i, j-1, 0);
            }
        }
    }

    //Out-Of-Bounds-Safe
    static void TrySet(ref int[,] grid, int row, int col, int value) {
        if(row >= 0 && row < grid.GetLength(0) && col >= 0 && col < grid.GetLength(1))
            grid[row, col] = value;
    }

    static string[] iGridToSGrid(int[,] grid) {
        var r = grid.GetLength(0);
        var c = grid.GetLength(1);

        var sGrid = new string[r];
        for(var iR = 0; iR < r; iR++) {
            var tempString = "";
            for(var iC = 0; iC < c; iC++) {
                tempString += grid[iR, iC] == 0 ? '.' : 'O';
            }
            sGrid[iR] = tempString;
        }

        return sGrid;
    }

    static string[] iGridToSGridDebug(int[,] grid) {
        var r = grid.GetLength(0);
        var c = grid.GetLength(1);

        var sGrid = new string[r];
        for(var iR = 0; iR < r; iR++) {
            var tempString = "";
            for(var iC = 0; iC < c; iC++) {
                tempString += grid[iR, iC] == 0 ? "." : grid[iR, iC].ToString();
            }
            sGrid[iR] = tempString;
        }

        return sGrid;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] rcn = Console.ReadLine().Split(' ');

        int r = Convert.ToInt32(rcn[0]);

        int c = Convert.ToInt32(rcn[1]);

        int n = Convert.ToInt32(rcn[2]);

        string[] grid = new string [r];

        for (int i = 0; i < r; i++) {
            string gridItem = Console.ReadLine();
            grid[i] = gridItem;
        }

        string[] result = bomberMan(n, grid);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
