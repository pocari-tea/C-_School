using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요: ");
            int i1 = int.Parse(Console.ReadLine());

            string result = (i1 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
