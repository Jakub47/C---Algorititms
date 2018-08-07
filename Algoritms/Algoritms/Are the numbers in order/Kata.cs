using System;
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

			for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length <= 1) return true;

                for (int y = 1 + i; y < arr.Length; y++)
                {
                    if (arr[i] > arr[y]) return false;
                }
            }
            return true;
		}
    }
}
