using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2개의 실수를 입력하세요.");
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}, + {1}, = {2}", d1, d2, d1 + d2);
        }
    }
}
