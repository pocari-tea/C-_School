using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice05
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAndAverage(11, 66); 
        }

        static void SumAndAverage(int a, int b)
        {
            double Sum = 0, count = 0;

            for(int i = a; a <= b; a++)
            {
                Sum += a;
                count++;
            }

            Console.WriteLine($"Sum: {Sum} Average: {Sum / count}");
        }
    }
}
