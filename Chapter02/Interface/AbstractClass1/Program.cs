using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass01
{
    abstract class AbstractBase // 추상메서드를 하나라도 포함하면 추상클래스로 선언해야됨
    {
        protected void PrivateMethod() // 일반메서드
        {
            Console.WriteLine("AbstractBase.PrivateMethod()");
        }

        public void PublicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMethod()");
        }
        public abstract void AbstractMethod(); // 추상메서드
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethod()");
            PrivateMethod();
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethod();
            obj.PublicMethod();


        }
    }
}