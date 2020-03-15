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

namespace HackerRank.IPK.Search.Exercises
{
    class Pairs : IExercise
    {
        // Complete the pairs function below.
        static int pairs(int k, int[] arr)
        { 
            var ordererArr = arr.OrderBy(c => c).ToArray();
            var count = 0;
            for (int i = 0; i < ordererArr.Length; i++)
            {
                var toFind = ordererArr[i] + k;

               if( Array.BinarySearch(ordererArr, i, ordererArr.Length - i, toFind) > 0)
                {
                    count++;
                }
            }
            return count;
        }


        public void Run()
        {
            //TextWriter textWriter = new StreamWriter("./hackrank", true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = pairs(k, arr);

            Console.WriteLine(result);


        }
    }
}

