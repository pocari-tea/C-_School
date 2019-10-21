using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    class Shape
    {
        public int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.Write("도형의 넓이 : ");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.Write("사각형의 넓이 : ");
            return width * height;
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.Write("삼각형의 넓이 : ");
            return width * height / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            PrintArea(r);
            PrintArea(t);
        }

        static void PrintArea(Shape a)
        {
            if(a is Rectangle)
            {
                Rectangle new_rectangle = a as Rectangle;
                Console.WriteLine(new_rectangle.Area());
            }

            if (a is Triangle)
            {
                Triangle new_triangle = a as Triangle;
                Console.WriteLine(new_triangle.Area());
            }
        }
    }
}
