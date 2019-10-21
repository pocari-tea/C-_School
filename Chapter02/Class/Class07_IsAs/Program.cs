﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog("댕댕이");
            Mammal m2 = new Cat("떼껄룩");

            if(m1 is Dog)
            {
                Dog dog = (Dog)m1;  
                dog.Bark();
            }

            // Cat cat = m1 as Cat;
            // Console.WriteLine(cat == null);

            Cat cat = m2 as Cat;
            if(cat != null)
            {
                cat.Meow();
            }

            // 동물들의 이름과 함께 씻는다는 표현 출력
            void Wash(Mammal m) // 부모를 받아야 모두 씻음
            {
                Console.WriteLine($"{m.GetName()}가(이) 씻는다.");
                if(m is Dog)
                {
                    Dog dog = (Dog)m;
                    dog.Bark();
                }
            }

            Wash(new Dog("멍멍이"));
            Wash(new Dog("고양이"));
        }
    }
}
