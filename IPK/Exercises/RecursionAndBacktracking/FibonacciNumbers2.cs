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

namespace HackerRank.IPK.RecursionAndBacktracking.Exercises
{
    class FibonacciNumbers2 : IExercise
    {

        public async static Task<int> FibonacciAsync(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            var n_one = FibonacciAsync(n - 1);
            var n_two = FibonacciAsync(n - 2);
            await Task.WhenAll(n_one, n_two);
            return n_two.Result + n_one.Result;
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciAsync(n).GetAwaiter().GetResult());
        }
    }
}
