using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task06_MakeBreakfast_Sync
{
    internal class Juice
    {
    }
    internal class Toast
    {
    }
    internal class Bacon
    {
    }
    internal class Egg
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("***** 아침식사 준비 시작 *****");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");
            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready!");
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;
            Console.WriteLine($"준비 시간: {elapsed}");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("오렌지 주스를 따른다.");
            Thread.Sleep(new Random().Next(1000, 2000)); // 1초에서 2초사이

            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            Console.WriteLine("토스트 빵에 버터를 바른다.");
            Thread.Sleep(new Random().Next(1000, 2000)); // 1초에서 2초사이
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("토스트 빵에 잼을 바른다.");
            Thread.Sleep(new Random().Next(1000, 2000)); // 1초에서 2초사이
        }

        private static Egg FryEggs(int count)
        {
            Console.WriteLine("계란 준비");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"계란 후라이 만드는 중 {i}");
                Thread.Sleep(new Random().Next(1000, 2000)); // 1초에서 2초사이
            }
            return new Egg();
        }

        private static Bacon FryBacon(int count)
        {
            Console.WriteLine("베이컨 준비");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"베이컨 만드는 중 {i}");
                Thread.Sleep(new Random().Next(1000, 2000)); // 1초에서 2초사이
            }
            return new Bacon();
        }

        private static Toast ToastBread(int count)
        {
            Console.WriteLine("빵 준비");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"빵 만드는 중 {i}");
                Thread.Sleep(new Random().Next(1000, 2000)); // 1초에서 2초사이
            }
            return new Toast();
        }
    }
}
