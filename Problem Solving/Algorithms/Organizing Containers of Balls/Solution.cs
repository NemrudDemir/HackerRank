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
    //alternative solution: Create 2 lists (total number of each ballType, each containers inital ballCount), sort the 2 lists and check if every value is equal - this method would be slower!

    static string organizingContainers(int[][] container) {
        //every containers balltype has to be the same number as the containers initial number of balls
        //1. we initialize a dictionary with the <containerSize, numberOfContainers>
        //2. we find all balltypes total number
        //3. we iterate all balltypes and check if there is a container which can hold them - if yes, we remove it from the dictionary, if not we return impossible
        var containers = new Dictionary<int, int>();
        var ballCounter = new int[container.Length];
        for(int i = 0; i<container.Length; i++) {
            var contain = container[i];
            var containerSize = 0;
            for(int j = 0; j<container[i].Length; j++) {
                ballCounter[j] += container[i][j];
                containerSize += container[i][j];
            }
            if(!containers.ContainsKey(containerSize))
                containers.Add(containerSize, 0);
            containers[containerSize]++;
        }

        var result = true;
        foreach(var count in ballCounter) {
            if(!containers.ContainsKey(count)) {
                result = false;
                break;
            }
            containers[count]--;
            if(containers[count] == 0)
                containers.Remove(count);
        }

        result = result && !containers.Keys.Any();
        return result ? "Possible" : "Impossible";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] container = new int[n][];

            for (int i = 0; i < n; i++) {
                container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
            }

            string result = organizingContainers(container);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
