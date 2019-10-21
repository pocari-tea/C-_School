using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice08
{
    class Cube
    {
        int x, y, z;
        static public int countOfInstance;

        public Cube()
        {
            countOfInstance++;
        }

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            countOfInstance++;
        }

        public int GetVolume()
        {
            return x * y * z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cube cube1 = new Cube(10, 10, 10);
            Cube cube2 = new Cube(30, 30, 30);

            Console.WriteLine(cube1.GetVolume());
            Console.WriteLine(cube2.GetVolume());

            Console.WriteLine(Cube.countOfInstance);

        }
    }
}