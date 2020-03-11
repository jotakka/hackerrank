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


namespace HackerRank.IPK.Miscelanious.Exercises {

	public class MaximumXor : IExercise {
		// Complete the maxXor function below.
		static int[] maxXor(int[] arr, int[] queries)
		{
			var maxArr = new int[queries.Length];
			maxArr = maxArr.Select(i => int.MinValue).ToArray();
			
			foreach( var e in arr)
			{
				for (int i = 0; i < queries.Length; i++)
				{
					maxArr[i] = Math.Max(maxArr[i], queries[i] ^ e);
				}
			}
			return maxArr;
		}


		//To slow
		static int[] maxXorToSlow(int[] arr, int[] queries)
		{
			var maxArr = new int[queries.Length];
			maxArr = maxArr.Select(i => int.MinValue).ToArray();

			foreach (var e in arr)
			{
				for (int i = 0; i < queries.Length; i++)
				{
					maxArr[i] = Math.Max(maxArr[i], queries[i] ^ e);
				}
			}
			return maxArr;
		}


		public void Run() {
			TextWriter textWriter = new StreamWriter("./rank", true);
			int p = Convert.ToInt32(Console.ReadLine());
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
			;
			int m = Convert.ToInt32(Console.ReadLine());

			int[] queries = new int[m];

			for (int i = 0; i < m; i++)
			{
				int queriesItem = Convert.ToInt32(Console.ReadLine());
				queries[i] = queriesItem;
			}

			int[] result = maxXor(arr, queries);

			textWriter.WriteLine(string.Join("\n", result));

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
