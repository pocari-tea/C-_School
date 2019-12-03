using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
    class Cat
    {
        public string color; // field 필드
        public string name;

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }

        public Cat() // 디폴트 생성자
        {

        }

        public Cat(string color, string name)
        {
            this.color = color;
            this.name = name;
        }
    }
}
