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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        var elevation = 0;
        var valleys = 0;
        var direction = 0;
        for(var i = 0; i < s.Length; i++)
        {
            var currentElevation = elevation;
            elevation = s[i] == 'D' ? --elevation : ++elevation;
            direction = s[i] == 'D' ? -1 : 1;
            if (currentElevation < 0 && currentElevation + direction == 0)
                valleys++;            
        }
        return valleys;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
