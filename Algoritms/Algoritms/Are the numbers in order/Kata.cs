using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms.Arethenumbersinorder
{
	/// <summary>
	/// In this Kata, your function receives an array of integers as input. Your task is to determine whether the numbers are in ascending order
    /// </summary>
    public class Kata
    {
        public Kata()
        {
			
        }

		public static bool IsAscOrder(int[] arr)
        {
			if (arr.Length <= 1) return true;

            var temp = new List<int>(arr);

            //return temp.TrueForAll(i => temp[temp.IndexOf(i)] > temp.);
            return temp.Zip(temp, (t1,t2) => temp.Where(i => t1 == t2));

            //for (int i = 0; i < arr.Length; i++)
            //         {
            //             if (arr.Length <= 1) return true;

            //             for (int y = 1 + i; y < arr.Length; y++)
            //             {
            //                 if (arr[i] > arr[y]) return false;
            //             }
            //         }
            return true;
		}
    }
}
