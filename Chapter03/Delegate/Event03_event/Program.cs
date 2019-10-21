﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event03_event
{
    // EventArgs : 이벤트 데이터를 나타내는 모든 클래스에 대 한 기본 클래스, 이벤트에 사용할 값 제공
    class PrimeCallbackArg : EventArgs // 콜백 값을 담는 클래스
    {
        public int prime;
        public PrimeCallbackArg(int prime)
        {
            this.prime = prime;
        }
    }

    // 소수 생성기 클래스: 소수가 발생할 때마다 등록된 콜백 메서드 호출
    // 게시자: 이벤트를 발생시키는 클래스
    class PrimeGenerator
    {
        // public delegate void EventHandler(object sender, EventArgs e);
        //.NET Framework 클래스 라이브러리의 모든 이벤트는 EventHandler 대리자를 기반으로 한다.
        public event EventHandler PrimeGenerated;

        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i) == true && PrimeGenerated != null)
                    PrimeGenerated(this, new PrimeCallbackArg(i));
            }
        }

        private bool IsPrime(int num)
        {
            if (num == 2) return true;
            for (int i = 2; i < num; i++)
                if (num % i == 0) return false;
            return true;
        }
    }

    // 구독자 : 이벤트를 받거나 처리하는 클래스
    class Program
    {
        static int sum;

        // 이벤트 처리 메서드 선언
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg).prime + " ");
        }

        static void SumPrime(object sender, EventArgs arg)
        {
            sum += (arg as PrimeCallbackArg).prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            // 이벤트 구독
            gen.PrimeGenerated += PrintPrime;
            gen.PrimeGenerated += SumPrime;

            // 2~10까지의 소수를 판별하면서 콜백함수 호출
            gen.Run(10);
            Console.WriteLine($"sum : {sum}");

            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}