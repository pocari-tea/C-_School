using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };


            foreach (object Arr in objectArr)
            {
                if (Arr is double)
                    sum += Convert.ToDouble(Arr);
            }

            Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
        }
    }
}