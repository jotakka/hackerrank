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
    class MinimumTimeRequired : IExercise
    {


        // Complete the minTime function below.
        static long minTime(long[] machines, long goal){
            var maxDays = (long) Math.Ceiling(machines.Max()*goal *1.0f /(machines.Length))+1;
            var minDays = (long)Math.Ceiling(goal * 1.0f / (machines.Length )* machines.Min());
            long mid=0;

            while (minDays<maxDays)
            {
                mid = (maxDays + minDays) / 2;
                if( machines.Sum(d=>mid/d)>=goal)
                {
                    maxDays = mid;
                }
                else
                {
                    minDays = mid + 1;
                }
            }

            return Math.Min(maxDays,minDays);
        }


        static long minTimeToLong(long[] machines, long goal)
        {
            bool repeat;
            long days = 0;
            do
            {
                repeat = false;
                var sumInverse = machines.Sum(n => 1.0f / n);


                days = (long)Math.Ceiling(goal / sumInverse);

                for (int i = 0; i < machines.Length; i++)
                {
                    if (machines[i] > days)
                    {
                        machines[i] = long.MaxValue;
                        repeat = true;
                    }
                }

            }while (repeat);

            return days;
        }


        static long minTimeToLongIterative(long[] machines, long goal)
        {
            bool repeat;
            long days = 0;
            do
            {
                repeat = false;
                var sumInverse = machines.Sum(n => 1.0f / n);


                days = (long)Math.Ceiling(goal / sumInverse);

                for (int i = 0; i < machines.Length; i++)
                {
                    if (machines[i] > days)
                    {
                        machines[i] = long.MaxValue;
                        repeat = true;
                    }
                }

            } while (repeat);

            return days;
        }


        public void Run()
        {
            //TextWriter textWriter = new StreamWriter("./hackrank", true);
            string[] nGoal = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nGoal[0]);

            long goal = Convert.ToInt64(nGoal[1]);

            long[] machines = Array.ConvertAll(Console.ReadLine().Split(' '), machinesTemp => Convert.ToInt64(machinesTemp))
            ;
            long ans = minTime(machines, goal);

            Console.WriteLine(ans);

        }
    }
}

