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
    static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles) {
        //0 = top
        //1 = topright
        //2 = right
        //3 = bottomright
        //4 = bottom
        //5 = bottomleft
        //6 = left
        //7 = topleft
        var obst = new int[8]; //relevant obstacles-distance in each direction
        for(int i = 0; i<8; i++)
            obst[i] = int.MaxValue;
        foreach(var obstacle in obstacles) {
            var rowDif = obstacle[0] - r_q;
            var colDif = obstacle[1] - c_q;
            if(rowDif == 0) { //same row
                if(colDif < 0) { //left
                    obst[6] = Math.Min(obst[6], colDif*-1);
                } else { //right
                    obst[2] = Math.Min(obst[2], colDif);
                }
            } else if(colDif == 0) { //same column
                if(rowDif < 0) { //bottom
                    obst[4] = Math.Min(obst[4], rowDif*-1);
                } else { //top
                    obst[0] = Math.Min(obst[0], rowDif);
                }
            } else if(rowDif == colDif) { //diagonal1
                if(rowDif < 0) { //bottomleft
                    obst[5] = Math.Min(obst[5], rowDif*-1);
                } else { //topright
                    obst[1] = Math.Min(obst[1], rowDif);
                }
            } else if(rowDif == colDif*-1) { //diagonal2
                if(rowDif < 0) { //bottomright
                    obst[3] = Math.Min(obst[3], colDif);
                } else { //topleft
                    obst[7] = Math.Min(obst[7], rowDif);
                }
            }
        }

        //result without obstacles
        var result = 2*(n-1); //top, bottom, right, left
        var topright = Math.Min(n-r_q, n-c_q);
        var topleft = Math.Min(n-r_q, c_q-1);
        var bottomright = Math.Min(r_q-1, n-c_q);
        var bottomleft = Math.Min(r_q-1, c_q-1);
        result += topright + topleft + bottomright + bottomleft;

        //consider obstacles
        result -= Math.Max(0, 1+n-r_q-obst[0]);//top
        result -= Math.Max(0, 1+topright-obst[1]);//topright
        result -= Math.Max(0, 1+n-c_q-obst[2]);//right
        result -= Math.Max(0, 1+bottomright-obst[3]);//bottomright
        result -= Math.Max(0, r_q-obst[4]);//bottom
        result -= Math.Max(0, 1+bottomleft-obst[5]);//bottomleft
        result -= Math.Max(0, c_q-obst[6]);//left
        result -= Math.Max(0, 1+topleft-obst[7]);//topleft

        return result;
    }
    
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        string[] r_qC_q = Console.ReadLine().Split(' ');

        int r_q = Convert.ToInt32(r_qC_q[0]);

        int c_q = Convert.ToInt32(r_qC_q[1]);

        int[][] obstacles = new int[k][];

        for (int i = 0; i < k; i++) {
            obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));
        }

        int result = queensAttack(n, k, r_q, c_q, obstacles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}