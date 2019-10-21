using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Malmmal one = new Malmmal();
            one.Move(); // 이동한다

            Lion lion = new Lion();
            lion.Move();

            // 자식이 부모 타입으로 암시적 형변환된 경우
            one = lion;
            one.Move(); // 이동한다.

            Malmmal two = new Human();
            two.Move();
        }
    }
}
