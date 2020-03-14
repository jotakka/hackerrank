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
    class DecibinaryNumbers : IExercise
    {

		// Complete the decibinaryNumbers function below.
		static long decibinaryNumbers(long x) {

			return 0l;
		}



		public void Run()
        {
            TextWriter textWriter =
                new StreamWriter("./rank", true);

			int q = Convert.ToInt32(Console.ReadLine());

			for (int qItr = 0; qItr < q; qItr++) {
				long x = Convert.ToInt64(Console.ReadLine());

				long result = decibinaryNumbers(x);

				textWriter.WriteLine(result);
			}

			textWriter.Flush();
			textWriter.Close();
		}
    }
}

