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
    class RepeatedString:IExercise
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            var countAsString = s.Count(c => c == 'a');

            var  subStrLength =(int)( n %s.Length );

            var countAsSubstring = s.Substring(0, subStrLength).Count(c=>c == 'a');

            var totalAs = (n / s.Length) * countAsString + countAsSubstring;

            return totalAs;
        }

        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./rank", true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
