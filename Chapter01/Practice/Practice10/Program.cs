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

            Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
        }

        static double SumDoubleOnly(object[] Arr) // 문자열 배열은 static을 사용하여야 함(변하면 안됌)
        {
            double sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] is double)
                    sum += Convert.ToDouble(Arr[i]);
            }
            return sum;
        }
    }
}