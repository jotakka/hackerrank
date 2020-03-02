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


namespace HackerRank.IPK.Arrays.Exercises
{
    class NewYearChaos : IExercise
    {


        static void minimumBribes(int[] a)
        {
            var d = a.Length;
            long sum = 0;
            for (var i = d - 1; i >= 0; i--)
            {
                if (a[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                for (int j = Math.Max(0, a[i] - 2); j < i; j++)
                {
                    sum+=a[j] > a[i]?1:0;
                }
            }
                Console.WriteLine(sum);
        }


        static void minimumBribesOnLySmallCases   (int[] a)
        {
            var d = a.Length;
            long sum = 0;
            var max = a.Length;
            var maxSet = new HashSet<int>(d);
            var min = a.Length;
            for (var i = d - 1; i >= 0; i--)
            {
                if (a[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                maxSet.Add(a[i]);
                if (a[i] == max)
                {
                    while (maxSet.Contains(--max)) ;
                    maxSet.Add(max);
                    continue;
                }

                if (a[i] < min)
                {
                    sum += Math.Min(min, max) - a[i];
                    min = a[i];
                    continue;
                }

                sum += max - a[i];
            }
            Console.WriteLine(sum);
        }


        // Complete the rotLeft function below.
        static void minimumBribesAboveTimeLimit(int[] a)
        {
            var d = a.Length;
            var sum = 0;
            for (var i = d - 1; i >= 0; i--)
            {
                if (a[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                sum += a.Take(i).Count(e => e > a[i]);
            }
            Console.WriteLine(sum);
        }


        public void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
    }
}