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
    class MaxArraySum : IExercise
    {
        // Complete the maxSubsetSum function below.

        static int maxSubsetSum(int[] arr)
        {

            if (arr.Length <= 2)
            {
                return arr.Max();
            }
            var maxArray = new int[arr.Length];
            maxArray[0] = arr[0];
            maxArray[1] =  Math.Max(arr[0], arr[1]); ;


            for (int i = 2; i < arr.Length; i++)
            {
                maxArray[i] = Math.Max(
                    Math.Max(arr[i], arr[i] + maxArray[i - 2]),
                    maxArray[i - 1]);
            }

            return maxArray[arr.Length - 1];
        }



        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = maxSubsetSum(arr);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
