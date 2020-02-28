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
    class CountingValleys : IExercise
    {
        // Complete the sockMerchant function below.
        // Complete the countingValleys function below.

        private static readonly Dictionary<char, int> stepVal = new Dictionary<char, int>() { { 'U', 1 }, { 'D', -1 } }; 
        static int countingValleys(int n, string s)
        {
            var sum = 0;
            var previousSum = 0;
            var valeyCounter = 0;
            foreach( var step in s )
            {
                previousSum = sum;
                sum+= stepVal[step];
                if (sum == 0)
                {
                    valeyCounter += previousSum >= 0 ? 0 : 1;
                }
            }
            return valeyCounter;
        }


        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./rank", true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
