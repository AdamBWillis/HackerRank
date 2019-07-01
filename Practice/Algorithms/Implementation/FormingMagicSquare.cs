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

    // Complete the formingMagicSquare function below.
    static int formingMagicSquare(int[][] s) {
        var flatMatrix = s.SelectMany(x => x);

        var magicSquares = new List<List<int>> {

            new List<int> { 8, 1, 6, 3, 5, 7, 4, 9, 2 },
            new List<int> { 6, 1, 8, 7, 5, 3, 2, 9, 4 },
            new List<int> { 4, 9, 2, 3, 5, 7, 8, 1, 6 },
            new List<int> { 2, 9, 4, 7, 5, 3, 6, 1, 8 },
            new List<int> { 8, 3, 4, 1, 5, 9, 6, 7, 2 },
            new List<int> { 6, 7, 2, 1, 5, 9, 8, 3, 4 },
            new List<int> { 4, 3, 8, 9, 5, 1, 2, 7, 6 },
            new List<int> { 2, 7, 6, 9, 5, 1, 4, 3, 8 }
        };
        
        return magicSquares.Aggregate(int.MaxValue, (result, item) => {
            var min = flatMatrix.Select((t, i) => Math.Abs(t - item[i])).Sum();
            return min < result ? min : result;
        });
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] s = new int[3][];

        for (int i = 0; i < 3; i++) {
            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
        }

        int result = formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
