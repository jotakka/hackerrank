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
            var distinctChars = str.Distinct().Count();

            if(  (str.Length)%distinctChars > 1)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
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