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


namespace HackerRank.IPK.Strings.Exercises
{
    class SherlockAndTheValidString : IExercise
    {
        // Complete the isValid function below.
        static string isValid(string str)
        {
            var distinctCounts = str.OrderBy(c => c)
                .GroupBy(c => c).Select(c => c.Count() 
                ).GroupBy(n => n)
                .Select(n => new { Count = n.Count(), N = n.Key }).OrderByDescending(n => n.Count).ToArray();

            if(distinctCounts.Count() == 1 || distinctCounts[1].N == 1 || distinctCounts[1].N == distinctCounts[0].N + 1)
            {
                return "YES";
            }

            if( distinctCounts.Count() > 2 || distinctCounts[1].Count > 1)
            {
                return "NO";
            }

            return "NO";

        }

        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            string s = Console.ReadLine();

            string result = isValid(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}