using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_Struct
{
    struct Point3D // struct는 값타입
    {
        public int x, y, z;

        public Point3D(int x, int y, int z) // 생성자 메소드 직접 넣어주지 않아도 되도록 편하게 만들어줌
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"{x}, {y}, {z}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(10, 20, 30);
            Console.WriteLine(p1.ToString());

            Point3D p2 = new Point3D(100, 200, 300); // 클래스라면 p2가 주소값을 가짐
            Point3D p3 = p2;
            p3.z = 400;

            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString()); // class로 바꾸면 class는 주소를 가리키기 때문에 그것이 복사되어 값이 같음
        }
    }
}
