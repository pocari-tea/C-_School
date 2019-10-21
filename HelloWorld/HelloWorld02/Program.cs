using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld02
{
    class Program
    {
        static void Main(string[] args)
        {
            // cw tap tap = console.wrtieline()
            Console.WriteLine("사용법: HelloWorld2.exe 이름");
            // Console.WriteLine("Hello { 0 }", args[0]);

            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
