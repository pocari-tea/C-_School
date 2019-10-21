using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = System.DateTime.Now.ToString("tt dd");
            
            Console.WriteLine(date1 + "시 입니다.");
        }
    }
}
