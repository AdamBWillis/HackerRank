using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        var leftToRight = p / 2;
        var rightToLeft = (n - p == 1 && n % 2 == 0) ? 1 : ((n - p) / 2);
        var min = Math.Min(leftToRight, rightToLeft);
        return min;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
