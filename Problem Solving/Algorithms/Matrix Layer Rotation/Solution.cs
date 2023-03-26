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
        static void matrixRotation(List<List<int>> matrix, int r)
    {
        var m = matrix.Count;
        var n = matrix.First().Count;

        var subCount = Math.Min(m, n) / 2;
        for (int i = 0; i < subCount; i++)
        {
            var deconstructedSub = GetOneDimensionalSubMatrix(matrix, i);
            var copy = deconstructedSub.ToArray();
            for (var j = 0; j < deconstructedSub.Length; j++)//shift each value
                deconstructedSub[(j + r) % deconstructedSub.Length] = copy[j]; 

            SetOneDimensionalSubMatrix(matrix, i, deconstructedSub);
        }

        foreach (var ma in matrix)
            Console.WriteLine(string.Join(" ", ma));
    }

    /*
    extracts a submatrix as 1 dimensional matrix
    example:
    1  2  3  4
    5  6  7  8
    9 10 11 12

    Level0 => {1,5,9,10,11,12,8,4,3,2}
    Level1 => {6,7}
    */
    static int[] GetOneDimensionalSubMatrix(List<List<int>> matrix, int level)
    {
        var m = matrix.Count;
        var n = matrix.First().Count;
        var length = (m + n - 2 - 4 * level) * 2; //2*(m-1)+2*(n-1)-8*level
        var result = new int[length];

        for (var r = level; r < m - level; r++)
        {
            result[r - level] = matrix[r][level];
            result[r - level + length / 2] = matrix[m - r - 1][n - level - 1];
        }

        for (var c = level + 1; c < n - level - 1; c++)
        {
            result[c - (level + 1) + (m-2*level)] = matrix[m - level - 1][c];
            result[c - (level + 1) + (m - 2 * level) + length / 2] = matrix[level][n - c - 1];
        }

        return result;
    }

    //sets the one dimensional submatrix back to the 'main'matrix
    static void SetOneDimensionalSubMatrix(List<List<int>> matrix, int level, int[] subMatrix)
    {
        var m = matrix.Count;
        var n = matrix.First().Count;
        var length = subMatrix.Length;

        for (var r = level; r < m - level; r++)
        {
            matrix[r][level] = subMatrix[r - level];
            matrix[m - r - 1][n - level - 1] = subMatrix[r - level + length / 2];
        }

        for (var c = level + 1; c < n - level - 1; c++)
        {
            matrix[m - level - 1][c] = subMatrix[c - (level + 1) + (m - 2 * level)];
            matrix[level][n - c - 1] = subMatrix[c - (level + 1) + (m - 2 * level) + length / 2];
        }
    }

    static void Main(string[] args) {
        string[] mnr = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(mnr[0]);

        int n = Convert.ToInt32(mnr[1]);

        int r = Convert.ToInt32(mnr[2]);

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < m; i++) {
            matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
        }

        matrixRotation(matrix, r);
    }
}
