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

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        var aggregates =
            a
            .GroupBy(x => x)
            .Select(group => new
            {
                nbr = group.Key,
                count = group.Count()
            })
            .OrderBy(x => x.nbr).ToList();

        if (aggregates.Count() == 1)
            return aggregates[0].count;

        var results = new List<int>();

        for(var i = 0; i < aggregates.Count()-1; i++)
        { 
            if(Math.Abs(aggregates[i].nbr - aggregates[i+1].nbr) == 1)
            {
                results.Add(aggregates[i].count + aggregates[i+1].count);
            }
            else
            {
                results.Add(aggregates[i].count);
            }
        }

        return results.DefaultIfEmpty(0).Max();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
