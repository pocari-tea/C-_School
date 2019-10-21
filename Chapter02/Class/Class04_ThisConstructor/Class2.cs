using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_ThisConstructor
{
    class Class2
    {
        int a, b, c;

        public Class2() // 결국 이게 가장 먼저 실행
        {
            this.a = 1;
            Console.WriteLine("Class2() 호출");
        }

        public Class2(int b) : this() // this 실행
        {
            this.a = 1;
            this.b = 2;
            Console.WriteLine($"Class2(int {b}) 호출");
        }

        public Class2(int b, int c) : this(b) // b를 먼저 실행
        {
            this.a = 1;
            this.b = 2;
            this.c = 3;
            Console.WriteLine($"Class2(int {b}, int {c}) 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
