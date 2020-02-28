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
using System.Threading.Tasks;

namespace HackerRank.IPK.Arrays.Exercises
{
    class NewYearChaos : IExercise
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            var maxSum = int.MinValue;
            for (int i = 0; i < 4; i++)
            {
                var sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                    + arr[i + 1][j + 1] +
                          arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    maxSum = sum > maxSum ? sum : maxSum;
                }
            }
            return maxSum;
        }


        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./rank", true);
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result =  hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
