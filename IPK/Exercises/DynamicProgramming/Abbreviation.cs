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


namespace HackerRank.IPK.DynamicProgramming.Exercises
{
    class Abbreviation : IExercise
    {
        // Complete the abbreviation function below.
        static string abbreviation(string a, string b)
        {
            return isPossibleToAbbreviate(a,b)?"YES":"NO";
        }

        static bool isPossibleToAbbreviate(string strA, string strB)
        {
            var opArray = new bool[strA.Length + 1, strB.Length + 1];
            if (strB.Length > strA.Length) return false;
            opArray[0, 0] = true;
            setingFirstLine(strA, opArray);

            for (int i = 1; i < strA.Length + 1; i++)
            {
                for (int j = 1; j < strB.Length + 1; j++)
                {
                    if (char.IsUpper(strA[i - 1])  )
                    {
                        if( strA[i-1]==strB[j-1] && opArray[i - 1, j - 1])
                        opArray[i, j] = true;
                        else opArray[i, j] = false;
                    }
                    else if (char.ToUpper(strA[i - 1]) == strB[j - 1] && opArray[i - 1, j - 1])
                    {

                        opArray[i, j] = true;
                    }
                    else
                    {
                        opArray[i, j] = opArray[i - 1, j]; 
                    }
                }
            }

            return opArray[strA.Length, strB.Length];
        }

        private static void setingFirstLine(string strA, bool[,] opArray)
        {
            for (int i = 1; i < strA.Length + 1; i++)
            {
                if (char.IsLower(strA[i - 1]))
                {
                    opArray[i, 0] = true;
                }
                else
                {
                    break;
                }

            }
        }

        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string a = Console.ReadLine();

                string b = Console.ReadLine();

                string result = abbreviation(a, b);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
