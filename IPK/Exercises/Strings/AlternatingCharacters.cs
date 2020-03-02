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
    class AlternatingCharacters : IExercise
    {
        // Complete the makeAnagram function below.
        static int alternatingCharacters(string str)
        {
            var toDeleteCount = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    toDeleteCount++;
                }
            }
            return toDeleteCount;
        }


        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
            textWriter.Close();
        }
    }
}
