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


namespace HackerRank.IPK.Strings.Exercises {
	class MakingAnagrams : IExercise {
		// Complete the makeAnagram function below.
		static int makeAnagram(string a, string b) {
			var aGroup = a.GroupBy(l => l).Select(l =>
			  new { Count = l.Count(), Char = l }
			  );
			var bGroup = b.GroupBy(l => l).Select(l =>
			  new { Count = l.Count(), Char = l }
			  );

			return 0;

		}



		public void Run() {
			TextWriter textWriter =
				new StreamWriter("./rank", true);

			string a = "fcrxzwscanmligyxyvym"; //Console.ReadLine();

			string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";//Console.ReadLine();

			int res = makeAnagram(a, b);

			textWriter.WriteLine(res);

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
