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
    class RecursiveDigitSum : IExercise
    {

        // Complete the superDigit function below.
        static int superDigitTakeToLong(string n, int k)
        {
            if (n.Length == 1) return int.Parse(n);
            var newSum = k * n.Sum(i => int.Parse($"{i}"));
            return superDigitTakeToLong($"{newSum}", 1);
        }


        //this implementation takes too long and probably causes stack overflow for very huge numbers
        static int superDigit(string n, int k)
            {
                if (n.Length == 1) return int.Parse(n);
                var newSum =k*n.Sum(i=>int.Parse($"{i}"));
                return superDigit($"{newSum}", 1);
            }


        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./hackrank", true);

            string[] nk = Console.ReadLine().Split(' ');

            string n = nk[0];

            int k = Convert.ToInt32(nk[1]);

            int result = superDigit(n, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
