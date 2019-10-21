using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 선언ㅇ과 동시에 인스턴스 할당, 읽기 전용
            var a = new { Name = "아이유", Age = 26 };
            Console.WriteLine($"{a.Name}, {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.WriteLine($"Subject: {b.Subject}, Scores:");
            foreach (int score in b.Scores)
                Console.WriteLine($"{score}");
        }
    }
}
