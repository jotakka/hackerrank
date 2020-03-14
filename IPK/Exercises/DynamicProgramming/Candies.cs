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
    class Candies : IExercise
    {

		// Complete the candies function below.
		// Complete the candies function below.
		static long candies(int n, int[] arr) {
			var candies = new long[n];
			candies[0] = 1;
			var sum = candies[0];
			for (int i = 1; i < n; i++) {
				candies[i] = arr[i] > arr[i - 1] ? candies[i - 1] + 1 : 1;
				sum += candies[i];
			}
			for (int i = n - 1; i > 0; i--) {
				if (arr[i] < arr[i - 1] && candies[i] >= candies[i - 1]) {
					var diff = candies[i] + 1 - candies[i - 1];
					candies[i - 1] = candies[i] + 1;
					sum += diff;
				}
			}

			return sum;
		}


		public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);


            int n = Convert.ToInt32(Console.ReadLine());

            long[] arr = new long[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            long result = candies(n, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

