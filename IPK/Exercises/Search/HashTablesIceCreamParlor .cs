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
    class HashTablesIceCreamParlor : IExercise
    {


        static void whatFlavors(int[] cost, int money)
        {
            var hashTable = new Hashtable(50000);

            hashTable.Add(money - cost[0], 1);

            for (int i = 1; i < cost.Length; i++)
            {
                if (hashTable.ContainsKey(cost[i]))
                {
                    Console.WriteLine($"{hashTable[cost[i]]} {i+1}");
                    return;
                }

                else if( money - cost[i] > 0 && !hashTable.ContainsKey(money - cost[i]))
                {
                    hashTable.Add(money - cost[i], i + 1);
                }
            }
        }


            // Complete the whatFlavors function below.
            static void whatFlavorsToComplicated(int[] cost, int money)
        {
            var hashTable = new Hashtable(50000);
            var idx1 = 0;
            var idx2 = 1;
            for (int i = 0; i < cost.Length; i++)
            {
                if (!hashTable.ContainsKey(cost[i]))
                {
                    hashTable.Add(cost[i], new int[2] { i + 1, -1 });
                }
                else if (((int[])hashTable[cost[i]])[1] == -1)
                {
                    ((int[])hashTable[cost[i]])[1] = i + 1;
                }
            }
            var orderedCost = cost.OrderBy(c => (int)c).ToArray();
            while (orderedCost[idx1] + orderedCost[idx2] != money)
            {
                if (idx2 + 1 <= orderedCost.Length && orderedCost[idx2 + 1] + orderedCost[idx1] <= money)
                {
                    idx2++;
                }
                else
                {
                    idx1++;
                }
            }

            var idxCost1 = ((int[])hashTable[orderedCost[idx1]])[0];

            var idxCost2 = orderedCost[idx1] == orderedCost[idx2] ? ((int[])hashTable[orderedCost[idx1]])[1] : ((int[])hashTable[orderedCost[idx2]])[0];

            Console.WriteLine($"{Math.Min(idxCost1, idxCost2)} {Math.Max(idxCost1, idxCost2)}");


        }

        public void Run()
        {
            //TextWriter textWriter = new StreamWriter("./hackrank", true);
            var file = new StreamReader(@"./Exercises/testFiles/test.txt");
            int t = Convert.ToInt32(file.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int money = Convert.ToInt32(file.ReadLine());

                int n = Convert.ToInt32(file.ReadLine());

                //var tst = file.ReadLine().Split(' ');
                int[] cost = Array.ConvertAll(file.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries), costTemp => Convert.ToInt32(costTemp))
                ;
                whatFlavors(cost, money);
            }
        }
    }
}
