using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 매개변수가 있는 스레드 */
namespace Thread03
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(threadFunc1);
            t1.Start(6);

            NameCard nc = new NameCard() { Name = "아이유", Age = 28 };
            Thread t2 = new Thread(threadFunc2);
            t2.Start(nc);
        }

        private static void threadFunc2(object obj) // type 변환 == 언박싱
        {
            NameCard nameCard = obj as NameCard;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{nameCard.Name}, {nameCard.Age}");
            }
        }

        private static void threadFunc1(object count) // thread의 매개변수는 object로 넘겨야 한다
        {
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"threadFunc1() : {i}");
            }
        }
    }
}
