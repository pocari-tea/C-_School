using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_Polymorphism
{
    class Malmmal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }

    class Lion : Malmmal
    {
        public override void Move()
        {
            Console.WriteLine("샤샤샥");
        }
    }

    class Whale : Malmmal
    {
        public override void Move()
        {
            Console.WriteLine("첨벙첨벙");
        }
    }

    class Human : Malmmal
    {
        public override void Move()
        {
            Console.WriteLine("미쳤습니까? 휴먼");
        }
    }
}
