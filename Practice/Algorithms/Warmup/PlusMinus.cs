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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        decimal positives = 0;
        decimal negatives = 0;
        decimal zeros = 0;
        decimal total = arr.Count();
        foreach(var item in arr){
            if(item > 0)
                positives++;
            if(item < 0)
                negatives++;
            if(item == 0)
                zeros++;
        }
        Console.WriteLine((positives/total).ToString("0.000000"));
        Console.WriteLine((negatives/total).ToString("0.000000"));
        Console.WriteLine((zeros/total).ToString("0.000000"));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
