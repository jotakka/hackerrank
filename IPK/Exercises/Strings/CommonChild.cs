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
    class CommonChild : IExercise
    {
        // Complete the commonChild function below.
        static int commonChild(string str1, string str2)
        {
            var maxCommonChildLeght = 0;
            var oldMaxCCL=int.MinValue;
            var str2Idx = 0;
            var str2AsHashSet = str2.ToHashSet();
            for (int i = 0; i < str1.Length; i++)
            {
                if (str2AsHashSet.Contains(str1[i]))
                {
                    maxCommonChildLeght++;
                    str2Idx = str2.IndexOf(str1[i]);
                    if(str2Idx == str2.Length - 1)
                    {
                        break;
                    }
                }
            }
            return maxCommonChildLeght;
        }
        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = commonChild(s1, s2);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}