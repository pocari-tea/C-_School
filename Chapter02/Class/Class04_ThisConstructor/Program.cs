﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_ThisConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본 생성자 사용
            {
                Class1 a1 = new Class1();
                a1.PrintFields();

                Class1 a2 = new Class1(2); // b
                a2.PrintFields();

                Class1 a3 = new Class1(2, 3); // b, c
                a3.PrintFields();
            }
            Console.WriteLine('\n');

            // this 생성자 사용
            {
                Class2 b1 = new Class2();
                b1.PrintFields();

                Class2 b2 = new Class2(2); // b
                b2.PrintFields();

                Class2 b3 = new Class2(2, 3); // b, c
                b3.PrintFields();
            }
        }
    }
}
