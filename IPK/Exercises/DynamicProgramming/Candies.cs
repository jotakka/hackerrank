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


namespace HackerRank.IPK.DynamicProgramming.Exercises
{
    class Candies : IExercise
    {


        // Complete the candies function below.
        static long candies(int n, long[] arr)
        {
            var candiesArr = new long[n];
            candiesArr[0] = 1;
            var sum = candiesArr[0];

            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i] > arr[i - 1] ? candiesArr[i - 1]+1 : 1;
                if (arr[i] > arr[i + 1])
                {
                    arr[i]++;
                    arr[i - 1]++;
                    sum+=2;
                }
                candiesArr[i] = arr[i];
            }

           return sum;
        }

        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);


            int n = Convert.ToInt32(Console.ReadLine());

            long[] arr = new long[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            long result = candies(n, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

