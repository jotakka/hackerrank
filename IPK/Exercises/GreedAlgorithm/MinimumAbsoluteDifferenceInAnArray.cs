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


namespace HackerRank.IPK.GreedAlgorithm.Exercises {
	class MinimumAbsoluteDifferenceInAnArray : IExercise {
		static int minimumAbsoluteDifference(int[] arr) {
			var min = int.MaxValue;
			var orderArr = arr.OrderBy(a => a).ToArray();
			for ( var i = 0; i < orderArr.Length-1;i++) {
				var diff = Math.Abs(orderArr[i] - orderArr[i + 1]);
				if (diff<min) {
					min =diff;
				}
			}
			return min;
		}



		public void Run() {
			TextWriter textWriter = new StreamWriter("./hackrank", true);

			int n = Convert.ToInt32(Console.ReadLine());

			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
			;
			int result = minimumAbsoluteDifference(arr);

			textWriter.WriteLine(result);

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
