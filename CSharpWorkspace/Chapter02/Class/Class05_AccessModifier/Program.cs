using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_AccessModifier
{
    class Program
    {
        class A
        {
            public int value1 = 10;
            private int value2 = 20;
            protected int value3 = 30;

            public class C : A
            {
                public int GetValue2(int v)
                {
                    return value2;
                }
            }

            public void SetValue2(int v)
            {
                value2 = v;
            }
        }

        class B : A // 상속
        {
            public int GetValue3()
            {
                return value3;
            }            
        }

        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.value1);
        }
    }
}
