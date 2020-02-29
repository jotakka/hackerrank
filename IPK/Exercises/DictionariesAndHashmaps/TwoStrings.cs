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
	class RansomNote : IExercise {
		// Complete the checkMagazine function below.
		static void checkMagazine(string[] magazine, string[] note) {
			var hashTable = new Hashtable(30000);

			if (magazine.Length < note.Length) {
				Console.WriteLine("No");
				return;
			}

			foreach (var word in magazine) {
				if (hashTable.ContainsKey(word)) {
					hashTable[word] = (int)hashTable[word] + 1;
				} else {
					hashTable.Add(word, 1);
				}
			}

			foreach (var word in note) {
				if (!hashTable.ContainsKey(word) || (int)hashTable[word] == 0) {
					Console.WriteLine("No");
					return;
				} else {
					hashTable[word] = (int)hashTable[word] - 1;
				}
			}

			Console.WriteLine("Yes");
			return;
		}



		public void Run() {
			string[] mn = Console.ReadLine().Split(' ');

			int m = Convert.ToInt32(mn[0]);

			int n = Convert.ToInt32(mn[1]);

			string[] magazine = Console.ReadLine().Split(' ');

			string[] note = Console.ReadLine().Split(' ');

			checkMagazine(magazine, note);
		}
	}
}
