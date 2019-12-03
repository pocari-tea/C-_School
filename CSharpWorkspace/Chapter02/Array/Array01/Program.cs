using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 방법 1
            string[] array1 = new string[3] { "안녕", "hello", "halo" };

            foreach(string i in array1)        
                Console.WriteLine(i);

            // 방법 2
            string[] array2 = new string[] { "안녕", "hello", "halo" };

            foreach (string i in array1)
                Console.WriteLine(i);

            // 방법 3
            string[] array3 =  { "안녕", "hello", "halo" };

            foreach (string i in array1)
                Console.WriteLine(i);

            // 배열의 타입
            Console.WriteLine(array1.GetType());
            Console.WriteLine(array1.GetType().BaseType);
        }
    }
}
