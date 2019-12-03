using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a1 = new Actor("마후마후");
            Actor a2 = new Actor("구루타밍");
            Actor a3 = new Actor("소라루");

            Console.WriteLine(a1.countOfInstance);
            Console.WriteLine(a2.countOfInstance);

            // static 필드는 인스턴스를 만들지 않고 클래스.필드명으로 접근 가능
            Console.WriteLine(Actor.staticCountOfInstance);

            a1.SetName("레오루");
            Console.WriteLine(a1.name);

            Console.WriteLine($"생성된 객체 숫자: {Actor.GetCountOfInstance()}");
            Actor a4 = new Actor("마후마후");
            Actor a5 = new Actor("구루타밍");
            Console.WriteLine($"생성된 객체 숫자: {Actor.GetCountOfInstance()}");
        }
    }
}
