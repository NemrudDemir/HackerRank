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
    static string gridSearch(char[,] G, char[,] P) {
        //Bruteforce
        for(var i = 0; i<G.GetLength(0)-P.GetLength(0)+1;i++) {
            for(var j = 0; j<G.GetLength(1)-P.GetLength(1)+1; j++) {
                var found = true;
                for(var pi=0; pi<P.GetLength(0); pi++) {
                    for(var pj=0; pj<P.GetLength(1); pj++) {
                        if(G[i+pi,j+pj] != P[pi,pj]) {
                            found = false;
                            break;
                        }
                    }
                    if(!found)
                        break;
                }
                if(found)
                    return "YES";
            }
        }
        return "NO";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] RC = Console.ReadLine().Split(' ');

            int R = Convert.ToInt32(RC[0]);

            int C = Convert.ToInt32(RC[1]);

            var G = new char[R,C];

            for (int i = 0; i < R; i++) {
                var GItem = Console.ReadLine();
                for(var j=0; j<GItem.Length; j++) {
                    G[i,j] = GItem[j];
                }
            }

            string[] rc = Console.ReadLine().Split(' ');

            int r = Convert.ToInt32(rc[0]);

            int c = Convert.ToInt32(rc[1]);

            var P = new char[r,c];

            for (int i = 0; i < r; i++) {
                var PItem = Console.ReadLine();
                for(var j=0; j<PItem.Length; j++) {
                    P[i,j] = PItem[j];
                }
            }

            string result = gridSearch(G, P);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
