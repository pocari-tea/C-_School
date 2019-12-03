using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Stack(First In Last Out) */
namespace Collection03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region System.collections.Stack
            Stack s = new Stack();
            s.Push(1);
            s.Push(3.14);
            s.Push('A');
            s.Push("Stack");

            while (s.Count>0)
                Console.Write($"{s.Pop()} ");
            Console.WriteLine('\n');
            #endregion

            #region System.Collections.Generic.Stack
            Stack<char> s2 = new Stack<char>();
            string str = "Stack";
            foreach (var c in str)
                s2.Push(c);

            PrintStack(s2);

            Stack<int> s3 = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

            #endregion
        }

        private static void PrintStack<T>(Stack<T> s2)
        {
            while (s2.Count>0)
                Console.Write($"{s2.Pop()} ");
            Console.WriteLine('\n');
        }
    }
}
