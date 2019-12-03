using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17
{
    delegate double AreaDelegate(double w, double h);

    class ShapeArea
    {
        public void PrintShapeArea(string name, double a, double b, AreaDelegate areaDelegate)
        {
            Console.WriteLine($"{name} 도형의 넓이 : {areaDelegate(a, b)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShapeArea area = new ShapeArea();
            AreaDelegate areaAdd = RectangleArea;

            area.PrintShapeArea("사각형", 20, 30, areaAdd);
            areaAdd = TriangleArea;
            area.PrintShapeArea("삼각형", 20, 30, areaAdd);
        }

        static double RectangleArea(double w, double h)
        {
            return w * h;
        }

        static double TriangleArea(double w, double h)
        {
            return w * h / 2;
        }
    }
}
