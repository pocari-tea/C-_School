using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate06_Chain
{
    delegate void Call(string location);

    class Program
    {
        static void Main(string[] args)
        {
            Call location = Call119;
            location += ShotOut;
            location += Escape;

            location("GSM");
        }

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? {location}에 불이났어요. ");
        }
        static void ShotOut(string location)
        {
            Console.WriteLine($"피하세요!! {location}에 불이났어요. ");
        }
        static void Escape(string location)
        {
            Console.WriteLine($"어서 {location}에 나가세요. ");
        }
    }
}
