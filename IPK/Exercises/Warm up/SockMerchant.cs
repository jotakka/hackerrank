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


namespace HackerRank.IPK.WarmUp.Exercises
{
    class SockMerchant:IExercise
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            return ar.GroupBy(c => c).Select(c => new
            {
                Count = c.Count(),
                Color = c
            }).Sum(c=>c.Count/2);
        }

        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./rank", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
