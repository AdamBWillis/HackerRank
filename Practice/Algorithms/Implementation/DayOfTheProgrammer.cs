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

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year) {
        if (year == 1918)
            return "26.09.1918";
        var dayOfYear = year == 1918 ? 260 : 256;
        var isLeapYear = year >= 1918 ? ( year % 400 == 0 ) || ( year % 4 == 0 && year % 100 != 0 ) : year % 4 == 0;
        var february = isLeapYear == true ? 29 : 28;        
        var calendar = new List<int>{31,february,31,30,31,30,31,31,30,31,30,31};
        var rollingDays = 0;
        var month = 1;
        var day = 1;
        for(var i = 0; i < 12; i++)
        {
            rollingDays += calendar[i];
            if(rollingDays >= dayOfYear)
            {
                month = i + 1;
                day = calendar[i] - (rollingDays - dayOfYear);
                break;
            }
        }
        return day.ToString().PadLeft(2, '0') + '.' + month.ToString().PadLeft(2, '0') + '.' + year.ToString();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
