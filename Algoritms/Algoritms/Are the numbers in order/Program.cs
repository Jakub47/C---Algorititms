using System;

namespace Algoritms.Arethenumbersinorder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine(Kata.IsAscOrder(new int[] { 1, 2 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 2, 1 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 1, 2, 3 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 1, 3, 2 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 2, 1, 3 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 2, 3, 1 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 3, 1, 2 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 3, 2, 1 }));
			Console.WriteLine(Kata.IsAscOrder(new int[] { 3, 1, 2 }));
            Console.ReadLine();
        }
    }
}
