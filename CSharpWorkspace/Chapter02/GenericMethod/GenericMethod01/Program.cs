using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 타입을 넘겨 한가지가 여러가지 타입을 사용 가능하므로 코드를 줄이고 boxing unboxing을 사용하지 않음 */
namespace GenericMethod01
{
    class OverloadMethod
    {
        public void Print(int value)
        {
            Console.WriteLine(value);
        }
        public void Print(double value)
        {
            Console.WriteLine(value);
        }
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class GenericMethod
    {
        public void Print<T>(T value) // T는 형식 매개변수
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OverloadMethod om = new OverloadMethod();
            om.Print(100);
            om.Print(3.14);
            om.Print("Hello World!");

            GenericMethod gm = new GenericMethod();
            gm.Print<int>(100);
            gm.Print<double>(3.14);
            gm.Print<string>("Hellow World!");
        }
    }
}
