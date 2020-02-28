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
    class JumpingOnTheClouds:IExercise
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            var jumps = 0;
            for (int i = 0; i < c.Length - 1;)
            {
                i += (i < c.Length - 2) && (c[i + 2] == 0) ? 2 : 1;
                jumps++;
            }
            return jumps;
        }


        public void Run()
        {
            TextWriter textWriter = new StreamWriter("./rank", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
