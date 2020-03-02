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
    class SpecialStringAgain : IExercise
    {
        // Complete the substrCount function below.
        static long substrCount(int length, string str)
        {
            var countSpecialStr = length;

            for (int i = 0; i < length; i++)
            {
                countSpecialStr = countSpecialType1(length, str, countSpecialStr, i);

                countSpecialStr = countSpecialType2(length, str, countSpecialStr, i);
            }

            return countSpecialStr;
        }

        private static int countSpecialType1(int length, string str, int countSpecialStr, int i)
        {
            for (int j = 1; j + i < length; j++)
            {
                if (str[i] == str[i + j])
                {
                    countSpecialStr++;
                }
                else
                {
                    break;
                }
            }

            return countSpecialStr;
        }

        private static int countSpecialType2(int length, string str, int countSpecialStr, int i)
        {
            for (int j = 1; i + j < length && i - j >= 0; j++)
            {
                var lastChar = str[i + 1];
                if (str[i] != str[i + j] && str[i + j] == str[i - j] && lastChar == str[i + j])
                {
                    countSpecialStr++;
                }
                else
                {
                    break;
                }
            }

            return countSpecialStr;
        }


        public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = substrCount(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

    }
}