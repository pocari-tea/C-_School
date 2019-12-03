using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice07
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("몇번째 까지 출력하시겠습니까?");
            int i1 = int.Parse(Console.ReadLine());

            Console.WriteLine("반복문은 1 재귀문은 2");
            int i2 = int.Parse(Console.ReadLine());
            if (i2 == 1)
                FibonacciLoop(i1);
            else
                for (int i = 0; i < i1; i++)
                {
                    Console.WriteLine($"FibonacciRecursice({i})" + FibonacciRecursice(i));
                }
        }

        static void FibonacciLoop(int k)
        {
            int a= 0, b = 1, c = 0;
            for(int i = 0; i < k; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"FibonacciLoop({i}): {a}");
                    a += b;
                }
                else
                {
                    Console.WriteLine($"FibonacciLoop({i}): {b}");
                    b += a;
                }                  
            }
        }

        static int FibonacciRecursice(int k)
        {
            if (k == 0)
                return 0;

            else if (k == 1)
                return 1;

            else
                return FibonacciRecursice(k - 1) + FibonacciRecursice(k - 2);
        }
    }
}
