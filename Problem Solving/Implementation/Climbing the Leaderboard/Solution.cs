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

    static List<int> climbingLeaderboard(int[] scores, int[] alice) {
        var newScores = new List<int>(); //TODO improve(?)
        var lastScore = int.MinValue;
        foreach(var score in scores) {
            if(score == lastScore)
                continue;
            newScores.Insert(0, score);
            lastScore = score;
        }

        var results = new List<int>();
        foreach(var aScore in alice) {
            int binSearch = newScores.BinarySearch(aScore);

            if(binSearch >= 0)
            {
                results.Add(newScores.Count - binSearch);
            } else
            {
                binSearch = ~binSearch;
                results.Add(newScores.Count - binSearch + 1);
            }
        }
        return results;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        var result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
