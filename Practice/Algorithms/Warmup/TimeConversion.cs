using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        var timeArr = s.Split(new String[]{":"}, StringSplitOptions.None);
        var hour = Int32.Parse(timeArr[0]);
        var minute = timeArr[1];
        var second = timeArr[2].Substring(0,2);
        var isPM = s.Contains("PM");
        if(isPM && hour != 12){
            hour += 12;
        }
        if(!isPM && hour == 12){
            hour = 0;
        }
        return hour.ToString().PadLeft(2, '0') + ":" + minute + ":" + second;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
