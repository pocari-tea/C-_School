using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 교재 376p 예제 */
namespace GenericMethod02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];
            string[] source2 = { "a", "b", "c", "d", "e" };
            string[] target2 = new string[source2.Length];

            CopyArray<int>(source, target);
            PrintArray<int>(target);

            CopyArray<string>(source2, target2);
            PrintArray<string>(target2);
        }

        private static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
        }

        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
