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
    class ArraysLeftRotation : IExercise
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            if (d == a.Length) { return a; };

            var toReturn = new int[a.Length];

            Array.Copy(a, 0, toReturn, a.Length - d, d);
            Array.Copy(a, d, toReturn, 0, a.Length - d);

            return toReturn;
        }


        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./rank", true);
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
