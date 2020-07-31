using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int surfaceArea(int[][] A) {
        int result = 0;
        int h = A.Length;
        int w = A[0].Length;
        for(int i = 0; i<h; i++) //difference xaxis
            for(int j = 1; j<w; j++)
                result += Math.Abs(A[i][j] - A[i][j-1]);
        
        for(int j = 0; j<w; j++)//difference yaxis
            for(int i = 1; i<h; i++)
                result += Math.Abs(A[i][j] - A[i-1][j]);
        
        //top-bottom - we know from the Constraints that there is always at least 1 cube on A(ij)
        result += 2*h*w;
        
        //behind front
        for(int i = 0; i<h; i++) {
            result += A[i][0];
            result += A[i][w-1];
        }
        
        //left right
        for(int j = 0; j<w; j++) {
            result += A[0][j];
            result += A[h-1][j];
        }
        
        return result;
    }

    static void Main(String[] args) {
        string[] tokens_H = Console.ReadLine().Split(' ');
        int H = Convert.ToInt32(tokens_H[0]);
        int W = Convert.ToInt32(tokens_H[1]);
        int[][] A = new int[H][];
        for(int A_i = 0; A_i < H; A_i++){
           string[] A_temp = Console.ReadLine().Split(' ');
           A[A_i] = Array.ConvertAll(A_temp,Int32.Parse);
        }
        int result = surfaceArea(A);
        Console.WriteLine(result);
    }
}
