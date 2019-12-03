using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice06
{
    class Program
    {
        static void Main(string[] args)
        {
            FullSequenceOfLetters("or");
        }

        static void FullSequenceOfLetters(string munja)
        {
            for(int i = (int)munja[0]; i <= (int)munja[1]; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
        }
    }
}
