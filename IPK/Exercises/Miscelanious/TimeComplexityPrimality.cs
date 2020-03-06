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

	public class TimeComplexityPrimality : IExercise {
		static int[] ints = new int[44722];
		static HashSet<int> hashSet = new HashSet<int>();
		static bool isPrime(int n) {
			if (n == 1) { return true; };
			if (n % 2 == 0) { return false; };
			var startIdx = -1;
			var sqrtNCeiling = Math.Floor(Math.Sqrt(n));
			if (n % sqrtNCeiling == 0) {
				hashSet.Add(n);
				return false;
			}

			do {
				startIdx++;
				if (n % ints[startIdx] == 0) {
					return false;
				}
			}
			while (ints[startIdx + 1] != 0 && ints[startIdx] < sqrtNCeiling);
			for (var i = ints[startIdx]; i < sqrtNCeiling; i += 2) {
				if (isPrime(i)) {
					ints[startIdx] = i;
					if (n % i == 0) {
						return false;
					}
				}
			}
			hashSet.Add(n);
			return true;
		}

		static string primality(int n) {
			if (n == 1 || n == 0) return "Not prime";
			if (hashSet.Contains(n)) return "Prime";
			return isPrime(n) ? "Prime" : "Not prime";
		}



		static void initializeInts() {
			hashSet.Add(2);
			hashSet.Add(3);
			hashSet.Add(5);
			hashSet.Add(7);
			hashSet.Add(11);

			ints[0] = 2;
			ints[1] = 3;
			ints[2] = 5;
			ints[3] = 7;
			ints[4] = 11;
		}


		public void Run() {
			TextWriter textWriter = new StreamWriter("./rank", true);
			int p = Convert.ToInt32(Console.ReadLine());

			initializeInts();
			for (int pItr = 0; pItr < p; pItr++) {
				int n = Convert.ToInt32(Console.ReadLine());

				string result = primality(n);

				Console.WriteLine(result);
			}

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
