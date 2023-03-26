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
    
    static int formingMagicSquare(int[] s) {
        //make the square flat - easier to handle
        //you can get the valid magicSquares by calling the 'PrintMagicSquares3x3' method
        var magicSquares = new List<int[]> { 
            new int[] {2, 7, 6, 9, 5, 1, 4, 3, 8},
            new int[] {2, 9, 4, 7, 5, 3, 6, 1, 8},
            new int[] {4, 3, 8, 9, 5, 1, 2, 7, 6},
            new int[] {4, 9, 2, 3, 5, 7, 8, 1, 6},
            new int[] {6, 1, 8, 7, 5, 3, 2, 9, 4},
            new int[] {6, 7, 2, 1, 5, 9, 8, 3, 4},
            new int[] {8, 3, 4, 1, 5, 9, 6, 7, 2},
            new int[] {8, 1, 6, 3, 5, 7, 4, 9, 2}
        };
        var minimum = int.MaxValue;

        foreach(var validSquare in magicSquares) {
            var cost = 0;
            for(int i = 0; i<9; i++) {
                cost += Math.Abs(s[i]-validSquare[i]);
            }
            minimum = Math.Min(minimum, cost);
        }
        
        return minimum;
    }

    private static void PrintMagicSquares3x3()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        var permutations = Permute(list);

        foreach (var perm in permutations)
        {
            var sum = perm[0] + perm[1] + perm[2];
            if (perm[3] + perm[4] + perm[5] != sum ||
                perm[6] + perm[7] + perm[8] != sum ||
                perm[0] + perm[3] + perm[6] != sum ||
                perm[1] + perm[4] + perm[7] != sum ||
                perm[2] + perm[5] + perm[8] != sum ||
                perm[0] + perm[4] + perm[8] != sum ||
                perm[2] + perm[4] + perm[6] != sum)
                continue;
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    private static List<int[]> Permute(List<int> set)
    {
        var result = new List<int[]>();

        Action<int> permute = null;
        permute = start =>
        {
            if (start == set.Count)
            {
                result.Add(set.ToArray());
            }
            else
            {
                var swaps = new List<int>();
                for (var i = start; i < set.Count; i++)
                {
                    if (swaps.Contains(set[i]))
                        continue; // skip if we already done swap with this item
                    swaps.Add(set[i]);

                    Swap(set, start, i);
                    permute(start + 1);
                    Swap(set, start, i);
                }
            }
        };

        permute(0);

        return result;
    }

    private static void Swap(List<int> set, int index1, int index2)
    {
        int temp = set[index1];
        set[index1] = set[index2];
        set[index2] = temp;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var s = new int[9];

        for (int i = 0; i < 3; i++) {
            var sTemp = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));
            var startIndex = i*3;
            s[startIndex] = sTemp[0];
            s[startIndex+1] = sTemp[1];
            s[startIndex+2] = sTemp[2];
        }

        int result = formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
