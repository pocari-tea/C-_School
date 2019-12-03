using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("알파벳을 입력하세요: ");
            string b = Console.ReadLine();

            char a = Convert.ToChar(b);

            if(a >= 'A' && a <= 'z')
            {
                Console.WriteLine(a + "는 알파벳 입니다.");
            }
            else
            {
                Console.WriteLine(a + "는 알파벳이 아닙니다.");
            }
        }
    }
}
