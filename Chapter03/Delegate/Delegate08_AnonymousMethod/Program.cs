using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 익명메소드 : 다시 사용하지 않는 경우 유용 일회용 함수를 감싼다고 생각하면 된다.*/
namespace Delegate07_AnonymousMethod
{
    delegate int CalcDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {

            Calculate(3, 4, delegate (int x, int y) { return x + y; });
        }

        static void Calculate(int x, int y, CalcDelegate calcFunc)
        {
            Console.WriteLine(calcFunc(x, y));
        }
    }
}