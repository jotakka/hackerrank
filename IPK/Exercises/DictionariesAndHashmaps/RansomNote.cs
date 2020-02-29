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


namespace HackerRank.IPK.DictionariesAndHashmaps.Exercises {
	class TwoStrings : IExercise {
		// Complete the twoStrings function below.
		string twoStrings(string s1, string s2) {
			var hashSet1 = s1.ToHashSet();
			var hashSet2 = s2.ToHashSet();
			return hashSet1.Intersect(hashSet2).Count() >= 0 ? "YES" : "NO";
		}

		//solution 1 : take to long for some cases
		static string twoStringsTakesToLong(string s1, string s2) {
			return s1.Any(s => s2.Contains(s)) ? "YES" : "NO";
		}

		public void Run() {
			TextWriter textWriter =
				new StreamWriter(
					@System.Environment.GetEnvironmentVariable("./rank"), true);

			int q = Convert.ToInt32(Console.ReadLine());

			for (int qItr = 0; qItr < q; qItr++) {
				string s1 = Console.ReadLine();

				string s2 = Console.ReadLine();

				string result = twoStrings(s1, s2);

				textWriter.WriteLine(result);
			}

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
