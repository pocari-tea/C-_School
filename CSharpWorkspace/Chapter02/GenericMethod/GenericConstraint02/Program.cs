using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint02
{
    class Utility
    {
        public static T Max<T>(T item1, T item2) where T : IComparable
        {
            if (item1.CompareTo(item2) >= 0) // -1: item이 더 작음, 0: 같음, 1: 큼
                return item1;
            return item2;
        }

        public static int GetSizeOf<T>(T item) where T : struct
        {
            return Marshal.SizeOf(item); // 타입 크기 반환 int면 4
        }

        public static void CheckNull<T>(T item)
        {
            if (item == null)
            {
                Console.WriteLine("널이다.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utility.Max(5, 6));
            Console.WriteLine(Utility.Max(3.14, 6.54));
            Console.WriteLine(Utility.Max('a', 'B'));
            Console.WriteLine(Utility.Max("abc", "def"));

            int num = 5;
            string str = "abc";
            Console.WriteLine(Utility.GetSizeOf<int>(num));
            //Console.WriteLine(Utility.GetSizeOf<string>(str));

            string str2 = null;
            Utility.CheckNull<string>(str2);
            // Utility.CheckNull<int>(num);
        }
    }
}
